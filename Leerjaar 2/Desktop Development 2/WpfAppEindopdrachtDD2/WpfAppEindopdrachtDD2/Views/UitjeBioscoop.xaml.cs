using ConsoleAppEindopdrachtDD2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfAppEindopdrachtDD2.Models;

namespace WpfAppEindopdrachtDD2.Views
{
    /// <summary>
    /// Interaction logic for UitjeBioscoop.xaml
    /// </summary>
    public partial class UitjeBioscoop : Window
    {
        #region Properties
        private BioscoopUitje bioscoopuitje = new();
        public BioscoopUitje Bioscoopuitje
        {
            get { return bioscoopuitje;}
            set { bioscoopuitje = value; }
        }
        #endregion
        #region fields
        private readonly Database db = new Database();
        private readonly string serviceDeskBericht = "\n\nNeem contact op met de service desk";
        #endregion
        public UitjeBioscoop()
        {
            InitializeComponent();
            DataContext = this;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            new MainWindow().Show();
        }
        private void btnAdd10_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan extratime = TimeSpan.FromMinutes(10);
            TimeSpan current = Bioscoopuitje.Duur;
            var newTime = current.Add(extratime);
            Bioscoopuitje.Duur = newTime; 
        }

        private void btnAdd1_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan extratime = TimeSpan.FromMinutes(1);
            TimeSpan current = Bioscoopuitje.Duur;
            var newTime = current.Add(extratime);
            Bioscoopuitje.Duur = newTime;
        }

        private void btnSubtract1_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan downtime = TimeSpan.FromMinutes(1);
            TimeSpan current = Bioscoopuitje.Duur;
            var newTime = current.Subtract(downtime);
            Bioscoopuitje.Duur = newTime;
        }

        private void btnSubtract10_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan downtime = TimeSpan.FromMinutes(10);
            TimeSpan current = Bioscoopuitje.Duur;
            var newTime = current.Subtract(downtime);
            Bioscoopuitje.Duur = newTime;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (Bioscoopuitje.Naam == "" || Bioscoopuitje.Film == "" || Bioscoopuitje.Zaal == "" || Bioscoopuitje.Stoel == "")
            {
                MessageBox.Show("Vul alle tekstvelden in!");
                return;
            }

            if (rbBinneneventT.IsChecked == true)
            {
                Bioscoopuitje.Binnenevent = true;
            }
            else
            {
                Bioscoopuitje.Binnenevent = false;
            }

            if (rbDoorstroomT.IsChecked == true)
            {
                Bioscoopuitje.Doorstroom = true;
            }
            else
            {
                Bioscoopuitje.Doorstroom = false;
            }
            string dbResult = db.CreateBioscoopuitje(Bioscoopuitje);
            if (dbResult != Database.OK)
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
            else
            {
                MessageBox.Show("OK!");
            }
        }
    }
}
