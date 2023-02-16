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

namespace SDLC2Week5Encryptie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private string? salt;
        private string? hash;

        private void btUpdate_Click(object sender, RoutedEventArgs e)
        {
            salt = BCrypt.Net.BCrypt.GenerateSalt();
            hash = BCrypt.Net.BCrypt.HashPassword(Password.Text, salt);
            tbHash.Text = hash;
        }

        private void btCheck_Click(object sender, RoutedEventArgs e)
        {
            bool correct = BCrypt.Net.BCrypt.Verify(Password.Text, hash);
            if (correct)
            {
                CheckPassword.Background = Brushes.Green;
            }
            else
            {
                CheckPassword.Background = Brushes.Red; 
            }
        }
    }
}
