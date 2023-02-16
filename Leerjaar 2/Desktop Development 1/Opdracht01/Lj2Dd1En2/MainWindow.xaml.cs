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

using Microsoft.Win32;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;

namespace Lj2Dd1En2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cars _carData = new Cars();
        public MainWindow()
        {
            InitializeComponent();
            RefreshList();
        }

        private void RefreshList()
        {
            DataTable cars = _carData.GetAllCars();
            if (cars == null)
            {
                return;
            }
            LbAutos.ItemsSource = cars.DefaultView;
        }

        private int CheckSelectedIndex()
        {
            int index = LbAutos.SelectedIndex;
            return index;
        }

        private void LbAutos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LbAutos.SelectedItem == null)
            {
                return;
            }
            DataRowView selectedCar = (DataRowView)LbAutos.SelectedItem;
            TbMerk1.Text = selectedCar["make"].ToString();
            TbJaar1.Text = selectedCar["yearOfIntroduction"].ToString();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (CheckSelectedIndex() < 0)
            {
                MessageBox.Show("Er is geen auto geselecteerd. Selecteer graag een auto die je wilt aanpassen");
                return;
            }
            DataRowView selectedCar = (DataRowView)LbAutos.SelectedItem;
            _carData.UpdateCar(TbMerk1.Text, TbJaar1.Text, selectedCar["carId"].ToString());
            RefreshList();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {
            _carData.CreateCar(TbMerk2.Text, TbJaar2.Text);
            RefreshList();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (CheckSelectedIndex() < 0)
            {
                MessageBox.Show("Er is geen auto geselecteerd. Selecteer graag een auto die je wilt verwijderen");
                return;
            }
            DataRowView selectedCar = (DataRowView)LbAutos.SelectedItem;
            _carData.DeleteCar(selectedCar["carId"].ToString());
            RefreshList();
        }

        private void BtnAfbeelding1_Click(object sender, RoutedEventArgs e)
        {
            byte[]? afbeelding = GetLocalPicture();
            if (afbeelding != null)
            {
                imgAfbeelding1.Source = new ImageSourceConverter().ConvertFrom(afbeelding) as ImageSource;
            }
        }

        private void BtnAfbeelding2_Click(object sender, RoutedEventArgs e)
        {
            byte[]? afbeelding = GetLocalPicture();
            if (afbeelding != null)
            {
                imgAfbeelding2.Source = new ImageSourceConverter().ConvertFrom(afbeelding) as ImageSource;
            }
        }

        #region GetLocalPicture
        // GetLocalPicture leest een afbeelding op je computer in een array van byte in.
        // GetLocalPicture heeft de volgende waarden:
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
