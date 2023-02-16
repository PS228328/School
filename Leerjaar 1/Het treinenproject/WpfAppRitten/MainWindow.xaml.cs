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

namespace WpfAppRitten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CreateRide _createRide = new CreateRide();
        public MainWindow()
        {
            InitializeComponent();
            DataTable lijnen = _createRide.Lijnen();

            for (int i = 0; i < lijnen.Rows.Count; i++)
            {
                ComboBoxItem myItem = new ComboBoxItem();
                int counter = 1;
                while (lijnen.Rows[i]["S" + counter].ToString() != "" && counter < 25)
                {
                    counter++;
                }

                DataTable beginstation = _createRide.HaalEenStationOp(Convert.ToInt32(lijnen.Rows[i]["S1"].ToString()));
                string begin = beginstation.Rows[0]["Stad"].ToString();

                counter--;

                DataTable eindstation = _createRide.HaalEenStationOp(Convert.ToInt32(lijnen.Rows[i]["S" + counter].ToString()));
                string eind = eindstation.Rows[0]["Stad"].ToString();

                myItem.Content = begin + " - " + eind;
                ridesBox.Items.Add(myItem);
            }
        }

        private void ridesBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbBeginpunt.Items.Clear();
            cbEindpunt.Items.Clear();

            int index = ridesBox.SelectedIndex + 1;
            DataTable lijn = _createRide.HaalEenLijnOp(index);

            int counter = 1;
            while (lijn.Rows[0]["S" + counter].ToString() != "")
            {
                DataTable stad = _createRide.HaalEenStationOp(Convert.ToInt32(lijn.Rows[0]["S" + counter].ToString()));
                cbBeginpunt.Items.Add(stad.Rows[0]["Stad"].ToString());
                cbEindpunt.Items.Add(stad.Rows[0]["Stad"].ToString());
                counter++;
            }
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            int lijnnummer = ridesBox.SelectedIndex + 1;

            string beginstad = cbBeginpunt.SelectedItem.ToString();
            string eindstad = cbEindpunt.SelectedItem.ToString();

            DataTable begin = _createRide.HaalEenStationOpString(beginstad);
            DataTable eind = _createRide.HaalEenStationOpString(eindstad);

            int beginpunt = Int32.Parse(begin.Rows[0]["Stationsnummer"].ToString());
            int eindpunt = Int32.Parse(eind.Rows[0]["Stationsnummer"].ToString());

            string tijd = tbHour.Text + ":" + tbMinute.Text + ":00";

            _createRide.Createride(lijnnummer, beginpunt, eindpunt, tijd, tbTrein.Text);
            MessageBox.Show("Gelukt!");
        }
    }
}
