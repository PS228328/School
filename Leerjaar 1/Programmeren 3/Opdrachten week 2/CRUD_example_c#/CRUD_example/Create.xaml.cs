﻿using CRUD_example.Classes;
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
using System.Windows.Shapes;

namespace CRUD_example
{
    /// <summary>
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Window
    {
        public Create()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            SchoolDB schoolDB = new SchoolDB();
            if (schoolDB.InsertStudent(tbFirstName.Text, tbPreposition.Text, tbLastName.Text, tbClass.Text))
            {
                MessageBox.Show($"Student aangemaakt");
            }
            else
            {
                MessageBox.Show($"Aanmaken mislukt");
            }
            this.Close();
        }
    }
}
