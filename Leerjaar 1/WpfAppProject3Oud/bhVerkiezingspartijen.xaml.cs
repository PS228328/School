﻿using System;
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

namespace WpfAppProject3
{
    /// <summary>
    /// Interaction logic for bhVerkiezingspartijen.xaml
    /// </summary>
    public partial class bhVerkiezingspartijen : Window
    {
        public bhVerkiezingspartijen()
        {
            InitializeComponent();
        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow home = new MainWindow();
            this.Close();
            home.ShowDialog();
        }
    }
}
