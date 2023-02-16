using Demo_prg3.Classes;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo_prg3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        demoClassDB _myDemo = new demoClassDB();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btGo_Click(object sender, RoutedEventArgs e)
        {
            DataTable myDataTable = new DataTable();
            myDataTable = _myDemo.GetNumber();
            int counter = 0;

            while(counter < myDataTable.Rows.Count)
            {
                string firstname = myDataTable.Rows[counter]["ContactName"].ToString();
                string compname = myDataTable.Rows[counter]["CompanyName"].ToString();
                MessageBox.Show(firstname + " " + compname);
                counter++;
            }
        }
    }
}
