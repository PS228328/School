using MySql.Data.MySqlClient;
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

using System.Data;
using Microsoft.Win32;
using System.IO;
using System.Data.Common;

namespace Lj2Dd1En2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection _dbConnection = new("server=localhost;database=carsdb;uid=root;pwd=;");
        byte[]? _nieuw;
        byte[]? _wijzig;

        public MainWindow()
        {
            InitializeComponent();
            GetAllCars();
        }


        //Hieronder halen we alle auto's op
        private void GetAllCars()
        {
            DataTable cars = new();

            try
            {
                _dbConnection.Open();

                MySqlCommand command = _dbConnection.CreateCommand();
                command.CommandText = "select * from cars order by make;";
                cars.Load(command.ExecuteReader());
                LbAutos.ItemsSource = cars.DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("Er ging iets mis met het ophalen van de database of het laden van alle items uit de database. Raadpleeg de ontwikkelaar!");
                return;
            }
            finally
            {
                _dbConnection.Close();
            }
        }

        // Eventhandler zet de gegevens van de auto die in de ListBox is geselecteerd, in de controls te zetten
        // Zo word bijvoorbeeld in een textbox het jaar van de auto gezet zodat de gebruiker dit kan zien
        // Is er geen auto geselecteerd, worden de controles leeggemaakt
        private void LbAutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LbAutos.SelectedItem == null)
            {
                return;
            }

            DataRowView selectedCar = (DataRowView)LbAutos.SelectedItem;

            tbauto.Text = selectedCar["make"].ToString();
            TbJaar.Text = selectedCar["yearOfIntroduction"].ToString();

            if (selectedCar["picture"] == DBNull.Value)
            {
                _wijzig = null;
                imgAfbeelding1.Source = null;
            }
            else
            {
                _wijzig = (byte[])selectedCar["picture"];
                imgAfbeelding1.Source = new ImageSourceConverter().ConvertFrom(_wijzig) as ImageSource;
            }
        }


        // Eventhandeler voegt een nieuwe auto toe aan de database
        private void CreateCar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _dbConnection.Open();

                MySqlCommand sqlQuery = _dbConnection.CreateCommand();
                sqlQuery.CommandText = $"INSERT INTO cars(carId,  make,  picture, yearOfIntroduction) " +
                $"         VALUES ( null, @make, @picture, {TbJaar1.Text});";
                sqlQuery.Parameters.AddRange(
                    new[]   {
                    new MySqlParameter(){ ParameterName = "@make", Value = TbMerk2.Text},
                    new MySqlParameter(){ ParameterName = "@picture", Value = _nieuw, }
                        }
                    );

                sqlQuery.ExecuteReader();
            }
            catch (Exception)
            {
                MessageBox.Show("Er ging iets mis met het toevoegen van een nieuwe auto in de database. Raadpleeg de ontwikkelaar!");
                return;
            }
            finally
            {
                _dbConnection.Close();
            }

            GetAllCars();
        }

        //Hieronder doen we de geselecteerde auto veranderen met de waardes die de gebruiker heeft ingevuld
        private void UpdateCar_Click(object sender, RoutedEventArgs e)
        {
            if (LbAutos.SelectedItem == null)
            {
                MessageBox.Show("Selecteer aub een auto die je wilt bewerken");
                return;
            }
            if (string.IsNullOrEmpty(tbauto.Text))
            {
                MessageBox.Show("Vul aub het nieuwe merk van de auto in");
                return;
            }
            if (string.IsNullOrEmpty(TbJaar.Text))
            {
                MessageBox.Show("Vul aub het nieuwe introductiejaar van de auto in");
                return;
            }

            if (!int.TryParse(TbJaar.Text, out int jaar) || jaar < 1769)
            {
                MessageBox.Show("Het introductiejaar mag alleen uit cijfers bestaan en mag niet voor 1769 liggen. Vul een geldig jaar in");
                return;
            }

            try
            {
                DataTable cars = new DataTable();
                _dbConnection.Open();

                MySqlCommand sqlQuery = _dbConnection.CreateCommand();
                sqlQuery.CommandText =
                    $"UPDATE cars SET make= '{tbauto.Text}',picture = @picture, yearOfIntroduction = {TbJaar.Text} " +
                    $" WHERE carId = {LbAutos.SelectedValue};";
                sqlQuery.Parameters.AddWithValue("@picture", _wijzig);
                cars.Load(sqlQuery.ExecuteReader());
                LbAutos.ItemsSource = cars.DefaultView;

                _dbConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Er is iets fout gegaan met het updaten van het geselecteerde item uit de database. Raadpleeg de ontwikkelaar!");
                return;
            }
            finally
            {
                new MainWindow().Show();
                _dbConnection.Close();
            }
        }

        //Hieronder verwijderen we de geselecteerde auto

        private void DeleteCar_Click(object sender, RoutedEventArgs e)
        {
            if (LbAutos.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst de auto die u wilt verwijderen.");
                return;
            }

            try
            {
                _dbConnection.Open();

                MySqlCommand sqlQuery = _dbConnection.CreateCommand();
                sqlQuery.CommandText = $"DELETE FROM cars WHERE carId = " + LbAutos.SelectedValue;
                sqlQuery.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Er is iets fout gegaan met het verwijderen van het geselecteerde item uit de database. Raadpleeg de ontwikkelaar!");
                return;
            }
            finally
            {
                _dbConnection.Close();
            }

            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
        }

        private void BtnNewImage_Click(object sender, RoutedEventArgs e)
        {
            _wijzig = GetLocalPicture();
            if (_wijzig != null)
            {
                imgAfbeelding1.Source =
                    new ImageSourceConverter().ConvertFrom(_wijzig) as ImageSource;
            }
            else
            {
                imgAfbeelding1.Source = null;
            }
        }

        private void BtnNewImage2_Click(object sender, RoutedEventArgs e)
        {
            _nieuw = GetLocalPicture();
            if (_nieuw != null)
            {
                imgAfbeelding2.Source = new ImageSourceConverter().ConvertFrom(_nieuw) as ImageSource;
            }
            else
            {
                imgAfbeelding2.Source = null;
            }
        }

        #region GetLocalPicture
        // GetLocalPicture leest een afbeelding op je computer in een array van byte in.
        // GetLocalPicture heef de volgende waarden:
        // - null: geen afbeelding ingelezen
        // - ongelijk null: de ingelezen afbeelding
        private byte[]? GetLocalPicture()
        {
            // Create OpenFileDialog 
            OpenFileDialog dlg = new OpenFileDialog();

            // Set filter for file extension and default file extension 
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            dlg.FilterIndex = 3;    // 3de blok, is jpg

            // Display OpenFileDialog by calling ShowDialog method 
            bool? result = dlg.ShowDialog();

            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                return File.ReadAllBytes(dlg.FileName);
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
