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

namespace WpfAppCreateTrainLines
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HaalStationsOp _haalOp = new HaalStationsOp();
        string[] _myStations;

        public MainWindow()
        {
            InitializeComponent();
            DataTable stations = _haalOp.Stations();
            string[] myStations = new string[stations.Rows.Count];
            int counter = 0;

            while (counter < myStations.Length)
            {
                myStations[counter] = stations.Rows[counter]["Stad"].ToString();
                counter++;
            }
            _myStations = myStations;
        }
        private void btAddExtraStations_Click(object sender, RoutedEventArgs e)
        {
            int extra = 0;
            try
            {
                extra = Convert.ToInt32(tbAmountExtraStations.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vul een geldig getal in aub!");
                return;
            }

            int counter = 0;
            while (counter < extra)
            {
                StackPanel newStation = new StackPanel();
                newStation.Orientation = Orientation.Horizontal;

                TextBox station = new TextBox();
                station.Width = 200;
                station.TextAlignment = TextAlignment.Center;
                station.FontSize = 15;
                station.Name = "tbStad";
                newStation.Children.Add(station);

                TextBox aankomst = new TextBox();
                aankomst.Width = 200;
                aankomst.TextAlignment = TextAlignment.Center;
                aankomst.FontSize = 15;
                aankomst.Name = "tbAankomst";
                newStation.Children.Add(aankomst);

                TextBox vertrek = new TextBox();
                vertrek.Width = 200;
                vertrek.TextAlignment = TextAlignment.Center;
                vertrek.FontSize = 15;
                vertrek.Name = "tbVertrek";
                newStation.Children.Add(vertrek);

                TextBox spoor = new TextBox();
                spoor.Width = 200;
                spoor.TextAlignment = TextAlignment.Center;
                spoor.FontSize = 15;
                spoor.Name = "tbSpoor";
                newStation.Children.Add(spoor);

                spTussenstations.Children.Add(newStation);
                counter++;
            }
        }

        private void btAddLine_Click(object sender, RoutedEventArgs e)
        {
            CheckStationCity(tbBeginstation.Text, 1);
            int stadteller = 2;

            foreach (StackPanel tussenstation in spTussenstations.Children)
            {
                foreach (TextBox myBox in tussenstation.Children)
                {
                    if (myBox.Name == "tbStad")
                    {
                        CheckStationCity(myBox.Text, stadteller);
                    }
                    else if (myBox.Name == "tbAankomst")
                    {
                        int number = TryToConvert(myBox.Text);
                        if (number == 0)
                        {
                            return;
                        }
                    }
                    else if (myBox.Name == "tbVertrek")
                    {
                        int number = TryToConvert(myBox.Text);
                        if (number == 0)
                        {
                            return;
                        }
                    }
                    else if (myBox.Name == "tbSpoor")
                    {
                        string spoor = myBox.Text;
                    }
                }
                stadteller++;
            }

            CheckStationCity(tbEindstation.Text, stadteller);
            TryToConvert(tbEindAankomsttijd.Text);
            AddTheLine();
        }

        private void CheckStationCity(string stad, int hoeveelste)
        {
            int counter = 0;
            while (counter < _myStations.Length && stad != _myStations[counter])
            {
                counter++;
            }

            if (counter == _myStations.Length)
            {
                MessageBox.Show("De " + hoeveelste + "e stad is geen geldige stad");
            }
        }
        private int TryToConvert(string number)
        {
            int intnumber = 0;
            try
            {
                intnumber = Convert.ToInt32(number);
            }
            catch (Exception)
            {
                MessageBox.Show("Je hebt ergens geen geldig getal ingevuld bij aankomst of vertrektijd!");
            }
            return intnumber;
        }
        private void AddTheLine()
        {
            DataTable station = _haalOp.HaalEenStationOp(tbBeginstation.Text);
            string spoor = tbSpoorBegin.Text;

            int stationsnr = Convert.ToInt32(station.Rows[0]["Stationsnummer"].ToString());
            int lijnnr = _haalOp.CreateLine(stationsnr, spoor);

            int stadteller = 2;

            foreach (StackPanel tussenstation in spTussenstations.Children)
            {
                foreach (TextBox myBox in tussenstation.Children)
                {
                    if (myBox.Name == "tbStad")
                    {
                        _haalOp.UpdateSomething(myBox, stadteller, lijnnr, 0, "");
                    }
                    else if (myBox.Name == "tbAankomst" || myBox.Name == "tbVertrek")
                    {
                        _haalOp.UpdateSomething(myBox, stadteller, lijnnr, Convert.ToInt32(myBox.Text), "");
                    }
                    else if (myBox.Name == "tbSpoor")
                    {
                        _haalOp.UpdateSomething(myBox, stadteller, lijnnr, 0, myBox.Text);
                    }
                }
                stadteller++;
            }

            _haalOp.UpdateSomething(tbEindstation, stadteller, lijnnr, 0, "");
            _haalOp.UpdateSomething(tbEindSpoor, stadteller, lijnnr, 0, tbEindSpoor.Text);
            _haalOp.UpdateSomething(tbEindAankomsttijd, stadteller, lijnnr, Convert.ToInt32(tbEindAankomsttijd.Text), "");

            MessageBox.Show("Het is gelukt!");

            spTussenstations.Children.Clear();
            StackPanel newStation = new StackPanel();
            newStation.Orientation = Orientation.Horizontal;

            TextBox stationn = new TextBox();
            stationn.Width = 200;
            stationn.TextAlignment = TextAlignment.Center;
            stationn.FontSize = 15;
            stationn.Name = "tbStad";
            newStation.Children.Add(stationn);

            TextBox aankomst = new TextBox();
            aankomst.Width = 200;
            aankomst.TextAlignment = TextAlignment.Center;
            aankomst.FontSize = 15;
            aankomst.Name = "tbAankomst";
            newStation.Children.Add(aankomst);

            TextBox vertrek = new TextBox();
            vertrek.Width = 200;
            vertrek.TextAlignment = TextAlignment.Center;
            vertrek.FontSize = 15;
            vertrek.Name = "tbVertrek";
            newStation.Children.Add(vertrek);

            TextBox spoorn = new TextBox();
            spoorn.Width = 200;
            spoorn.TextAlignment = TextAlignment.Center;
            spoorn.FontSize = 15;
            spoorn.Name = "tbSpoor";
            newStation.Children.Add(spoorn);

            spTussenstations.Children.Add(newStation);
            tbBeginstation.Text = "";
            tbSpoorBegin.Text = "";
            tbEindstation.Text = "";
            tbEindSpoor.Text = "";
            tbEindAankomsttijd.Text = "";
        }
    }
}
