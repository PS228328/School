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
    /// Interaction logic for UitjeMuseum.xaml
    /// </summary>
    public partial class UitjeMuseum : Window
    {
        #region Properties
        private MuseumUitje museumuitje = new();
        public MuseumUitje Museumuitje
        {
            get { return museumuitje; }
            set { museumuitje = value; }
        }
        #endregion
        #region fields
        private readonly Database db = new Database();
        private readonly string serviceDeskBericht = "\n\nNeem contact op met de service desk";
        #endregion
        public UitjeMuseum()
        {
            InitializeComponent();
            DataContext = this;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            new MainWindow().Show();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (Museumuitje.Naam == "")
            {
                MessageBox.Show("Het uitje heeft geen naam");
                return;
            }
            if (rbBinneneventT.IsChecked == true)
            {
                Museumuitje.Binnenevent = true;
            }
            else
            {
                Museumuitje.Binnenevent = false;
            }
            if (rbDoorstroomT.IsChecked == true)
            {
                Museumuitje.Doorstroom = true;
            }
            else
            {
                Museumuitje.Doorstroom = false;
            }
            string dbResult = db.CreateMuseumuitje(Museumuitje);
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
