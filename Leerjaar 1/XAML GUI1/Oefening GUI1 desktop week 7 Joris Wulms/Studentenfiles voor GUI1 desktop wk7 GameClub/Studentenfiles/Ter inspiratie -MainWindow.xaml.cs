using System.Windows;

namespace Gui1Wk7_GameClub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _voornaam = null;
        private string _achternaam = null;
        private string _telefoonnummer = null;
        private  string _geboortedatum = null;
        private  string _adres = null;
        private  string _postcode = null;
        private string _land = null;
        private string _geslacht = null;
        private string _favorietSpel = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, RoutedEventArgs e)
        {
            lbMail.Items.Clear();

            //ToDo plaats hier je code waarmee alle fields gevuld worden
            //(zie als voorbeeld onderstaande code voor de geboortedatum)

            _geboortedatum = dpGebDatum.SelectedDate.ToString();
            _geboortedatum = truncDate(_geboortedatum);

            //Roep hier generateMail() aan, waarmee alles wordt ingevuld in de ListBox
            generateMail();
        }

        private string truncDate(string date)
        {
            int length = 10;
            if (date.Length > length)
            {
                date = date.Substring(0, length);
            }
            return date;
        }

        private void generateMail()
        {
            lbMail.Items.Add("Beste " + _voornaam + " " + _achternaam);
            lbMail.Items.Add(" ");
            lbMail.Items.Add("Fijn dat je jezelf wilt inschrijven bij onze club ");
            lbMail.Items.Add("Nadat je de contributie van 25 euro hebt overgemaakt krijg je spoedig een bevestiging van je inschrijving");
            lbMail.Items.Add(" ");
            lbMail.Items.Add("Als er tournooien zijn van het spel " + _favorietSpel + " dan krijg je via mail een uitnodiging");
            lbMail.Items.Add(" ");
            lbMail.Items.Add("Maar zou u nog even onderstaande gegevens willen controleren en ons via mail willen bevestigen dat deze juist zijn!");
            lbMail.Items.Add("naam is " + _voornaam + " " + _achternaam);
            lbMail.Items.Add("Telefoonnummer is " + _telefoonnummer );
            lbMail.Items.Add("Adres is " + _adres + ", " + _postcode + ", te " + _land);
            lbMail.Items.Add("En u bent geboren op de datum " + _geboortedatum);
            lbMail.Items.Add(" ");
            lbMail.Items.Add("En als laatste denken wij dat u hebt doorgegeven dat u een " + _geslacht + " bent");
            lbMail.Items.Add(" ");
            lbMail.Items.Add("Nogmaals hartelijk dank voor uw interesse en graag zien we uw bevestiging tegenmoet");
            lbMail.Items.Add(" ");
            lbMail.Items.Add("GameClub Summa  ---- Game on!!!");
        }
    }
}
