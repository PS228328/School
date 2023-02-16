using System;
using System.Collections.Generic;
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

namespace NS_Bord
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] cities = {"Alkmaar", "Castricum", "Zaandam", "Amsterdam Sloterdijk", "Amsterdam Centraal", "Amsterdam Amstel", "Utrecht", "Den Bosch", "Eindhoven", "Weert", "Roermond", "Sittard"};

        public MainWindow()
        {
            InitializeComponent();
        }         

        private void selectcity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            alleswatermoetgebeuren();
        }

        private void Times_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            alleswatermoetgebeuren();
        }

        private void alleswatermoetgebeuren()
        {
            ComboBoxItem SelectedCity = (ComboBoxItem)selectcity.SelectedItem;
            if (SelectedCity == null)
            {
                return;
            }
            string selectedcity = SelectedCity.Content.ToString();


            int counter = 0;

            switch (selectedcity)
            {
                case "Alkmaar":
                    viavia.Text = "";
                    counter = 1;
                    viavia.Text = "Via";
                    break;
                case "Castricum":
                    viavia.Text = "";
                    counter = 2;
                    viavia.Text = "Via";
                    break;
                case "Zaandam":
                    viavia.Text = "";
                    counter = 3;
                    viavia.Text = "Via";
                    break;
                case "Amsterdam Sloterdijk":
                    viavia.Text = "";
                    counter = 4;
                    viavia.Text = "Via";
                    break;
                case "Amsterdam Centraal":
                    viavia.Text = "";
                    counter = 5;
                    viavia.Text = "Via";
                    break;
                case "Amsterdam Amstel":
                    viavia.Text = "";
                    counter = 6;
                    viavia.Text = "Via";
                    break;
                case "Utrecht":
                    viavia.Text = "";
                    counter = 7;
                    viavia.Text = "Via";
                    break;
                case "Den Bosch":
                    viavia.Text = "";
                    counter = 8;
                    viavia.Text = "Via";
                    break;
                case "Eindhoven":
                    viavia.Text = "";
                    counter = 9;
                    viavia.Text = "Via";
                    break;
                case "Weert":
                    viavia.Text = "";
                    counter = 10;
                    viavia.Text = "Via";
                    break;
                case "Roermond":
                    viavia.Text = "";
                    counter = 11;
                    viavia.Text = "Via";
                    break;
                case "Sittard":
                    viavia.Text = "";
                    counter = 12;
                    break;
            }

            while (counter < cities.Length)
            {
                if (viavia.Text == "Via")
                {
                    viavia.Text = viavia.Text + " " + cities[counter];
                    counter++;
                }
                else if (viavia.Text == "")
                {
                    viavia.Text = "";
                    counter++;
                }
                else
                {
                    viavia.Text = viavia.Text + ", " + cities[counter];
                    counter++;
                }
            }

            var Item = Times.SelectedItem;

            ComboBoxItem SelectedTime = (ComboBoxItem)Times.SelectedItem;
            if (SelectedTime == null)
            {
                return;
            }
            string selectedtime = SelectedTime.Content.ToString();

            string[] subs = selectedtime.Split(':');

            int uur;
            int minuut;

            uur = Int32.Parse(subs[0]);
            minuut = Int32.Parse(subs[1]);

            if (selectedcity == "Amsterdam Centraal")
            {
                uur = uur + 0;
                minuut = minuut + 0;
            }
            switch (selectedcity)
            {
                case "Alkmaar":
                    uur = uur + 0;
                    minuut = minuut + 0;
                    break;
                case "Castricum":
                    uur = uur + 0;
                    minuut = minuut + 8;
                    break;
                case "Zaandam":
                    uur = uur + 0;
                    minuut = minuut + 22;
                    break;
                case "Amsterdam Sloterdijk":
                    uur = uur + 0;
                    minuut = minuut + 28;
                    break;
                case "Amsterdam Centraal":
                    uur = uur + 0;
                    minuut = minuut + 38;
                    break;
                case "Amsterdam Amstel":
                    uur = uur + 0;
                    minuut = minuut + 46;
                    break;
                case "Utrecht":
                    uur = uur + 1;
                    minuut = minuut + 6;
                    break;
                case "Den Bosch":
                    uur = uur + 1;
                    minuut = minuut + 39;
                    break;
                case "Eindhoven":
                    uur = uur + 2;
                    minuut = minuut + 0;
                    break;
                case "Weert":
                    uur = uur + 2;
                    minuut = minuut + 18;
                    break;
                case "Roermond":
                    uur = uur + 2;
                    minuut = minuut + 33;
                    break;
                case "Sittard":
                    uur = uur + 2;
                    minuut = minuut + 49;
                    break;
            }

            while (minuut >= 60)
            {
                minuut = minuut - 60;
                uur++;
            }

            while (uur >= 24)
            {
                uur = uur - 24;
            }

            if (uur >= 10 && minuut >= 10)
            {
                vertrektijd.Text = uur.ToString() + ":" + minuut.ToString();
            }
            else if (uur < 10 && minuut >= 10)
            {
                vertrektijd.Text = "0" + uur.ToString() + ":" + minuut.ToString();
            }
            else if (uur >= 10 && minuut < 10)
            {
                vertrektijd.Text = uur.ToString() + ":0" + minuut.ToString();
            }
            else
            {
                vertrektijd.Text = "0" + uur.ToString() + ":0" + minuut.ToString();
            }
        }
    }
}
