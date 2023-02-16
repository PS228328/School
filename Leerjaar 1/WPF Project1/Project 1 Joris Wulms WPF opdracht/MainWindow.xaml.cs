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

namespace Project_1_Joris_Wulms_WPF_opdracht
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int hoeveel = 0;
        double prijsgerecht = 0;
        double totalekosten = 0;
        double subtotaal = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem SelectedFood = (ComboBoxItem)Foodbox.SelectedItem;
            string selectFood = SelectedFood.Content.ToString();

            if (selectFood == "Pizza Margarita" || selectFood == "Pizza Napolitana" || selectFood == "Pizza Hawaii" || selectFood == "Pizza Funghi" || selectFood == "Pizza Calzone" || selectFood == "Pizza Peperone" || selectFood == "Pizza Prosciutto" || selectFood == "Pizza Tonno" || selectFood == "Pizza Diavola" || selectFood == "Pizza Quattro Stagoini" || selectFood == "Pizza Frute di Mare")
            {
                formaat.Visibility = Visibility.Visible;
                rb25.Visibility = Visibility.Visible;
                rb35.Visibility = Visibility.Visible;
                aanbieding.Visibility = Visibility.Visible;
            }
            else
            {
                formaat.Visibility = Visibility.Hidden;
                rb25.Visibility = Visibility.Hidden;
                rb35.Visibility = Visibility.Hidden;
                aanbieding.Visibility = Visibility.Hidden;
            }

            if (selectFood == "Fusilli Pesto")
            {
                prijs.Text = "7,00";
                prijs.Foreground = Brushes.Black;
            }
            else if (selectFood == "Pizza Margarita" || selectFood == "Macaroni Bolognese")
            {
                prijs.Text = "8,00";
                prijs.Foreground = Brushes.Black;
            }
            else if (selectFood == "Pizza Peperone")
            {
                prijs.Text = "9,00";
                prijs.Foreground = Brushes.Black;
            }
            else if (selectFood == "Farfalle Gorgonzola")
            {
                prijs.Text = "9,50";
                prijs.Foreground = Brushes.Black;
            }
            else if (selectFood == "Pizza Napolitana" || selectFood == "Pizza Hawaii" || selectFood == "Pizza Quattro Stagoini")
            {
                prijs.Text = "10,00";
                prijs.Foreground = Brushes.Black;
            }
            else if (selectFood == "Pizza Funghi" || selectFood == "Pizza Diavola")
            {
                prijs.Text = "10,50";
                prijs.Foreground = Brushes.Black;
            }
            else if (selectFood == "Pizza Calzone" || selectFood == "Pizza Prosciutto" || selectFood == "Lasagne Classico")
            {
                prijs.Text = "11,00";
            }
            else if (selectFood == "Pizza Tonno")
            {
                prijs.Text = "12,00";
                prijs.Foreground = Brushes.Black;
            }
            else if (selectFood == "Spaghetti Vongole")
            {
                prijs.Text = "12,50";
                prijs.Foreground = Brushes.Black;
            }
            else if (selectFood == "Pizza Frute di Mare")
            {
                prijs.Text = "14,00";
                prijs.Foreground = Brushes.Black;
            }
            else
            {
                prijs.Text = "0,00";
                prijs.Foreground = Brushes.Black;
            }

            try
            {
                prijsgerecht = Double.Parse(prijs.Text);
                hoeveel = Int32.Parse(aantal.Text);
            }
            catch (Exception)
            {
                totaal.Text = "Error";
                totaal.Foreground = Brushes.Red;
                return;
            }

            if (rb25.IsChecked == true && selectFood == "Pizza Margarita" || rb25.IsChecked == true && selectFood == "Pizza Napolitana" || rb25.IsChecked == true && selectFood == "Pizza Hawaii" || rb25.IsChecked == true && selectFood == "Pizza Funghi" || rb25.IsChecked == true && selectFood == "Pizza Calzone" || rb25.IsChecked == true && selectFood == "Pizza Peperone" || rb25.IsChecked == true && selectFood == "Pizza Prosciutto" || rb25.IsChecked == true && selectFood == "Pizza Tonno" || rb25.IsChecked == true && selectFood == "Pizza Diavola" || rb25.IsChecked == true && selectFood == "Pizza Quattro Stagoini" || rb25.IsChecked == true && selectFood == "Pizza Frute di Mare")
            {
                totalekosten = prijsgerecht * 0.7 * hoeveel;
            }
            else
            {
                totalekosten = prijsgerecht * hoeveel;
            }
            if (totaal == null)
            {
                return;
            }
            totaal.Foreground = Brushes.Black;
            totaal.Text = totalekosten.ToString("0.00");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem SelectedFood = (ComboBoxItem)Foodbox.SelectedItem;
            if (SelectedFood == null)
            {
                MessageBox.Show("Kies aub een gerecht!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string selectFood = SelectedFood.Content.ToString();

            if (rb25.IsChecked == false && rb35.IsChecked == false && selectFood == "Pizza Margarita" || rb25.IsChecked == false && rb35.IsChecked == false && selectFood == "Pizza Napolitana" || rb25.IsChecked == false && rb35.IsChecked == false && selectFood == "Pizza Hawaii" || rb25.IsChecked == false && rb35.IsChecked == false && selectFood == "Pizza Funghi" || rb25.IsChecked == false && rb35.IsChecked == false && selectFood == "Pizza Calzone" || rb25.IsChecked == false && rb35.IsChecked == false && selectFood == "Pizza Peperone" || rb25.IsChecked == false && rb35.IsChecked == false && selectFood == "Pizza Prosciutto" || rb25.IsChecked == false && rb35.IsChecked == false && selectFood == "Pizza Tonno" || rb25.IsChecked == false && rb35.IsChecked == false && selectFood == "Pizza Diavola" || rb25.IsChecked == false && rb35.IsChecked == false && selectFood == "Pizza Quattro Stagoini" || rb25.IsChecked == false && rb35.IsChecked == false && selectFood == "Pizza Frute di Mare")
            {
                MessageBox.Show("Selecteer aub de grootte van de pizza", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (aantal.Text == "0")
            {
                MessageBox.Show("Je moet een gerecht minimaal 1 keer bestellen!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                totaal.Text = "Error";
                totaal.Foreground = Brushes.Red;
                return;
            }

            try
            {
                hoeveel = Int32.Parse(aantal.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Je hebt geen geldig getal ingevuld! Je hebt nu: " + "'" + aantal.Text + "' " + " ingevuld", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                totaal.Text = "Error";
                totaal.Foreground = Brushes.Red;
                return;
            }

            prijsgerecht = Double.Parse(prijs.Text);
            subtotaal = Double.Parse(subtotaals.Text);

            if (selectFood == "Pizza Margarita" || selectFood == "Pizza Napolitana" || selectFood == "Pizza Hawaii" || selectFood == "Pizza Funghi" || selectFood == "Pizza Calzone" || selectFood == "Pizza Peperone" || selectFood == "Pizza Prosciutto" || selectFood == "Pizza Tonno" || selectFood == "Pizza Diavola" || selectFood == "Pizza Quattro Stagoini" || selectFood == "Pizza Frute di Mare")
            {
                if (rb35.IsChecked == true)
                {
                    totalekosten = prijsgerecht * hoeveel;
                }
                else
                {
                    totalekosten = prijsgerecht * 0.7 * hoeveel;
                }
            }
            else
            {
                totalekosten = prijsgerecht * hoeveel;
            }
            Math.Round(totalekosten, 2);
            Math.Round(subtotaal, 2);
            subtotaal = subtotaal + totalekosten;

            subtotaals.Text = subtotaal.ToString("0.00");

            goCalculate();
        }

        private void goCalculate()
        {
            ComboBoxItem SelectedFood = (ComboBoxItem)Foodbox.SelectedItem;
            string selectFood = SelectedFood.Content.ToString();

            if (rb35.IsChecked == true && selectFood == "Pizza Margarita" || rb35.IsChecked == true && selectFood == "Pizza Napolitana" || rb35.IsChecked == true && selectFood == "Pizza Hawaii" || rb35.IsChecked == true && selectFood == "Pizza Funghi" || rb35.IsChecked == true && selectFood == "Pizza Calzone" || rb35.IsChecked == true && selectFood == "Pizza Peperone" || rb35.IsChecked == true && selectFood == "Pizza Prosciutto" || rb35.IsChecked == true && selectFood == "Pizza Tonno" || rb35.IsChecked == true && selectFood == "Pizza Diavola" || rb35.IsChecked == true && selectFood == "Pizza Quattro Stagoini" || rb35.IsChecked == true && selectFood == "Pizza Frute di Mare")
            {
                tbOutput.Items.Add(aantal.Text + " " + selectFood + " " + "35cm" + " " + "€ " + totalekosten.ToString("0.00") + "\n");
            }
            else if (rb25.IsChecked == true && selectFood == "Pizza Margarita" || selectFood == "Pizza Napolitana" || selectFood == "Pizza Hawaii" || selectFood == "Pizza Funghi" || selectFood == "Pizza Calzone" || selectFood == "Pizza Peperone" || selectFood == "Pizza Prosciutto" || selectFood == "Pizza Tonno" || selectFood == "Pizza Diavola" || selectFood == "Pizza Quattro Stagoini" || selectFood == "Pizza Frute di Mare")
            {
                tbOutput.Items.Add(aantal.Text + " " + selectFood + " " + "25cm" + " " + "€ " + totalekosten.ToString("0.00") + "\n");
            }
            else
            {
                tbOutput.Items.Add(aantal.Text + " " + selectFood + " " + "€ " + totalekosten.ToString("0.00") + "\n");
            }
        }

        private void aantal_TextChanged(object sender, TextChangedEventArgs e)
        {
            ComboBoxItem SelectedFood = (ComboBoxItem)Foodbox.SelectedItem;
            if (SelectedFood == null)
            {
                return;
            }
            string selectFood = SelectedFood.Content.ToString();

            try
            {
                prijsgerecht = Double.Parse(prijs.Text);
                hoeveel = Int32.Parse(aantal.Text);
            }
            catch (Exception)
            {
                totaal.Text = "Error";
                totaal.Foreground = Brushes.Red;
                return;
            }

            if (rb25.IsChecked == true && selectFood == "Pizza Margarita" || rb25.IsChecked == true && selectFood == "Pizza Napolitana" || rb25.IsChecked == true && selectFood == "Pizza Hawaii" || rb25.IsChecked == true && selectFood == "Pizza Funghi" || rb25.IsChecked == true && selectFood == "Pizza Calzone" || rb25.IsChecked == true && selectFood == "Pizza Peperone" || rb25.IsChecked == true && selectFood == "Pizza Prosciutto" || rb25.IsChecked == true && selectFood == "Pizza Tonno" || rb25.IsChecked == true && selectFood == "Pizza Diavola" || rb25.IsChecked == true && selectFood == "Pizza Quattro Stagoini" || rb25.IsChecked == true && selectFood == "Pizza Frute di Mare")
            {
                totalekosten = prijsgerecht * 0.7 * hoeveel;
            }
            else
            {
                totalekosten = prijsgerecht * hoeveel;
            }
            if (totaal == null)
            {
                return;
            }
            totaal.Foreground = Brushes.Black;
            totaal.Text = totalekosten.ToString("0.00");
        }

        private void rb25_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem SelectedFood = (ComboBoxItem)Foodbox.SelectedItem;
            if (SelectedFood == null)
            {
                return;
            }
            string selectFood = SelectedFood.Content.ToString();

            try
            {
                prijsgerecht = Double.Parse(prijs.Text);
                hoeveel = Int32.Parse(aantal.Text);
            }
            catch (Exception)
            {
                totaal.Text = "Error";
                totaal.Foreground = Brushes.Red;
                return;
            }

            if (rb25.IsChecked == true && selectFood == "Pizza Margarita" || rb25.IsChecked == true && selectFood == "Pizza Napolitana" || rb25.IsChecked == true && selectFood == "Pizza Hawaii" || rb25.IsChecked == true && selectFood == "Pizza Funghi" || rb25.IsChecked == true && selectFood == "Pizza Calzone" || rb25.IsChecked == true && selectFood == "Pizza Peperone" || rb25.IsChecked == true && selectFood == "Pizza Prosciutto" || rb25.IsChecked == true && selectFood == "Pizza Tonno" || rb25.IsChecked == true && selectFood == "Pizza Diavola" || rb25.IsChecked == true && selectFood == "Pizza Quattro Stagoini" || rb25.IsChecked == true && selectFood == "Pizza Frute di Mare")
            {
                totalekosten = prijsgerecht * 0.7 * hoeveel;
            }
            else
            {
                totalekosten = prijsgerecht * hoeveel;
            }
            if (totaal == null)
            {
                return;
            }
            totaal.Foreground = Brushes.Black;
            totaal.Text = totalekosten.ToString("0.00");
        }

        private void rb35_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem SelectedFood = (ComboBoxItem)Foodbox.SelectedItem;
            if (SelectedFood == null)
            {
                return;
            }
            string selectFood = SelectedFood.Content.ToString();

            try
            {
                prijsgerecht = Double.Parse(prijs.Text);
                hoeveel = Int32.Parse(aantal.Text);
            }
            catch (Exception)
            {
                totaal.Text = "Error";
                totaal.Foreground = Brushes.Red;
                return;
            }

            if (rb25.IsChecked == true && selectFood == "Pizza Margarita" || rb25.IsChecked == true && selectFood == "Pizza Napolitana" || rb25.IsChecked == true && selectFood == "Pizza Hawaii" || rb25.IsChecked == true && selectFood == "Pizza Funghi" || rb25.IsChecked == true && selectFood == "Pizza Calzone" || rb25.IsChecked == true && selectFood == "Pizza Peperone" || rb25.IsChecked == true && selectFood == "Pizza Prosciutto" || rb25.IsChecked == true && selectFood == "Pizza Tonno" || rb25.IsChecked == true && selectFood == "Pizza Diavola" || rb25.IsChecked == true && selectFood == "Pizza Quattro Stagoini" || rb25.IsChecked == true && selectFood == "Pizza Frute di Mare")
            {
                totalekosten = prijsgerecht * 0.7 * hoeveel;
            }
            else
            {
                totalekosten = prijsgerecht * hoeveel;
            }
            if (totaal == null)
            {
                return;
            }
            totaal.Foreground = Brushes.Black;
            totaal.Text = totalekosten.ToString("0.00");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int postcodecheck;
            string postletter;

            if (Naam.Text == "")
            {
                MessageBox.Show("Vul aub je naam in!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (Adres.Text == "")
            {
                MessageBox.Show("Vul aub je adres in!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                postcodecheck = Int32.Parse(Postcodecijfers.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vul aub 4 cijfers in bij de postcode!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (postcodecheck < 1000 || postcodecheck > 9999)
            {
                MessageBox.Show("Een postcode kan niet meer of minder dan 4 letters hebben. Vul aub een postcode in tussen 1000 en 9999", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(Postcodeletters.Text == "")
            {
                MessageBox.Show("Vul aub de 2 letters van je postcode in!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                postletter = Postcodeletters.Text;

                if (postletter.Length != 2)
                {
                    MessageBox.Show("Vul aub niet meer of minder dan 2 letters in bij je postcode!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                int postletter2;
                postletter2 = Int32.Parse(Postcodeletters.Text);
                MessageBox.Show("Vul aub 2 letters in bij je postcode!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            catch (Exception)
            {
                //Nothing
            }

            if (Plaats.Text == "")
            {
                MessageBox.Show("Vul aub je woonplaats in!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (tbOutput.Items.IsEmpty)
            {
                MessageBox.Show("Je hebt nog niets besteld!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string helebestelling = "";

            foreach (string bestelling in tbOutput.Items)
            {
                helebestelling += bestelling + "\n";
            }

            MessageBoxResult myResult = MessageBox.Show("Beste " + Naam.Text + ", hartelijk dank voor je bestelling bij ons! Controleer nog even of je bestelling juist is, klik dan op OK. Als er iets niet juist is, klik dan op cancel om alles nog te kunnen wijzigen. " + "\n" + "Mijn bestelling: " + "\n" + "\n" + helebestelling + "\n" + "Subtotaal: €" + subtotaals.Text, "Bestelling bevestigen", MessageBoxButton.OKCancel, MessageBoxImage.Question);

            if (myResult == MessageBoxResult.OK)
            {
                hoeveel = 0;
                prijsgerecht = 0;
                totalekosten = 0;
                subtotaal = 0;
                tbOutput.Items.Clear();
                Naam.Text = "";
                Adres.Text = "";
                Postcodecijfers.Text = "";
                Postcodeletters.Text = "";
                Plaats.Text = "";
                rb25.IsChecked = false;
                rb35.IsChecked = false;
                rb25.Visibility = Visibility.Hidden;
                rb35.Visibility = Visibility.Hidden;
                formaat.Visibility = Visibility.Hidden;
                aanbieding.Visibility = Visibility.Hidden;
                prijs.Text = "0,00";
                aantal.Text = "0";
                totaal.Text = "0,00";
                subtotaals.Text = "0,00";

                MessageBox.Show("Je bestelling is naar de keuken gestuurd voor bereiding!");

            }

        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (tbOutput.Items.IsEmpty)
            {
                MessageBox.Show("Je hebt geen gerechten in je lijst staan om te verwijderen!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBoxResult deleteResult = MessageBox.Show("Weet je zeker dat je alle maaltijden in je lijst wilt verwijderen?", "Verwijderen maaltijden", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (deleteResult == MessageBoxResult.Yes)
            {
                tbOutput.Items.Clear();
                subtotaal = 0;
                subtotaals.Text = "0,00";
                return;
            }
            else
            {
                return;
            }
        }

        private void tbOutput_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var Item = tbOutput.SelectedItem;
            string select = (string)tbOutput.SelectedItem;

            string[] subs = select.Split('€');

            foreach (string sub in subs)
            {
                MessageBoxResult myResult = MessageBox.Show("Weet je zeker dat je dit gerecht wilt verwijderen? " + Item, "Gerecht verwijderen", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (myResult == MessageBoxResult.Yes)
                {
                    double minus = Double.Parse(subs[1]);

                    subtotaal = subtotaal - minus;
                    subtotaals.Text = subtotaal.ToString("0.00");

                    tbOutput.Items.Remove(Item);
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
