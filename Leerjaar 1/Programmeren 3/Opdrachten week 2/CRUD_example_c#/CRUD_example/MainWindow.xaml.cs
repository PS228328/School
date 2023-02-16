using CRUD_example.Classes;
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

namespace CRUD_example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SchoolDB _schoolDB = new SchoolDB();
        public MainWindow()
        {          
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            DataTable students = _schoolDB.SelectStudents();
            if (students != null)
            {
                dgStudents.ItemsSource = students.DefaultView;
            }
        }

        private void FillDataZoekGrid(string Zoekterm, string word)
        {
            DataTable students = _schoolDB.ZoekStudents(Zoekterm, word);
            if (students != null)
            {
                dgStudents.ItemsSource = students.DefaultView;
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dgStudents.SelectedItem as DataRowView;
            
            Edit edit = new Edit(selectedRow);
            edit.ShowDialog();

            FillDataGrid();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dgStudents.SelectedItem as DataRowView;

            MessageBoxResult myResult = MessageBox.Show("Weet je zeker dat je student " + selectedRow["id"] + " wilt verwijderen?", "Student verwijderen", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (myResult == MessageBoxResult.No)
            {
                return;
            }

            if (_schoolDB.DeleteStudent(selectedRow["id"].ToString()))
            {
                MessageBox.Show($"Student {selectedRow["id"]} verwijderd");
            }
            else
            {
                MessageBox.Show($"Verwijderen van {selectedRow["id"]} mislukt");
            }

            FillDataGrid();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            Create create = new Create();
            create.ShowDialog();
            FillDataGrid();
        }

        private void Zoek_Click(object sender, RoutedEventArgs e)
        {
            if (zoekherstel.Background == Brushes.Red)
            {
                zoekherstel.Content = "Zoek";
                zoekherstel.Background = Brushes.LightGray;
                FillDataGrid();
            }
            else
            {
                string Zoekterm = Zoekveld.Text;
                ComboBoxItem searchWord = (ComboBoxItem)searchBox.SelectedItem;
                if (searchWord == null)
                {
                    MessageBox.Show("Please select what you would like to find!");
                    return;
                }

                string word = searchWord.Content.ToString();
                FillDataZoekGrid(Zoekterm, word);
                Zoekveld.Text = "";

                zoekherstel.Content = "Herstel";
                zoekherstel.Background = Brushes.Red;
            }
        }
    }
}
