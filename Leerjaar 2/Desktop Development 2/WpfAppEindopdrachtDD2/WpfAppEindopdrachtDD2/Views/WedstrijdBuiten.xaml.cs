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
    /// Interaction logic for WedstrijdBuiten.xaml
    /// </summary>
    public partial class WedstrijdBuiten : Window
    {
        #region Properties
        private Buitenwedstrijd buitenwedstrijd = new();
        public Buitenwedstrijd Buitenwedstrijd
        {
            get { return buitenwedstrijd; }
            set { buitenwedstrijd = value; }
        }
        #endregion
        #region fields
        private readonly Database db = new Database();
        private readonly string serviceDeskBericht = "\n\nNeem contact op met de service desk";
        #endregion
        public WedstrijdBuiten()
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
            TimeSpan current = Buitenwedstrijd!.WedstrijdDuur;
            var newTime = current.Add(extratime);
            Buitenwedstrijd.WedstrijdDuur = newTime;
        }

        private void btnAdd1_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan extratime = TimeSpan.FromMinutes(1);
            TimeSpan current = Buitenwedstrijd!.WedstrijdDuur;
            var newTime = current.Add(extratime);
            Buitenwedstrijd.WedstrijdDuur = newTime;
        }

        private void btnSubtract1_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan downtime = TimeSpan.FromMinutes(1);
            TimeSpan current = Buitenwedstrijd!.WedstrijdDuur;
            var newTime = current.Subtract(downtime);
            Buitenwedstrijd.WedstrijdDuur = newTime;
        }

        private void btnSubtract10_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan downtime = TimeSpan.FromMinutes(10);
            TimeSpan current = Buitenwedstrijd!.WedstrijdDuur;
            var newTime = current.Subtract(downtime);
            Buitenwedstrijd.WedstrijdDuur = newTime;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (Buitenwedstrijd.Naam == "")
            {
                MessageBox.Show("De wedstrijd heeft geen naam. Vul die aub in");
                return;
            }
            if (Buitenwedstrijd.WedstrijdDuur == TimeSpan.FromMinutes(0))
            {
                MessageBox.Show("De wedstrijdduur is 0. Vul aub een geldig aantal in");
                return;
            }
            string dbResult = db.CreateBuitenwedstrijd(Buitenwedstrijd);
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
