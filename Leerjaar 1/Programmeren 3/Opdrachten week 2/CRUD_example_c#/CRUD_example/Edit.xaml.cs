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
using System.Windows.Shapes;

namespace CRUD_example
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public Edit(DataRowView student)
        {
            InitializeComponent();
            FillScreen(student);
        }

        private void FillScreen(DataRowView student)
        {
            tbId.Text = student["id"].ToString();
            tbFirstName.Text = student["voornaam"].ToString();
            tbPreposition.Text = student["tussenvoegsel"].ToString();
            tbLastName.Text = student["achternaam"].ToString();
            tbClass.Text = student["klas"].ToString();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            SchoolDB schoolDB = new SchoolDB();
            if(schoolDB.UpdateStudent(tbId.Text, tbFirstName.Text, tbPreposition.Text, tbLastName.Text, tbClass.Text))
            {
                MessageBox.Show($"Student {tbId.Text} aangepast");
            }
            else
            {
                MessageBox.Show($"Aanpassen van {tbId.Text} mislukt");
            }
            this.Close();
        }
    }
}
