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

namespace WpfAppps228328Oefentoets
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

        int endValue;

        private void btIf_Click(object sender, RoutedEventArgs e)
        {
            if (Joris.Text == "Optie 1")
                MessageBox.Show("Optie 1 is ingevoerd");

            else if (Joris.Text == "Optie 2")
                MessageBox.Show("Optie 2 is ingevoerd");

            else
                MessageBox.Show("Zowel optie 1 als optie 2 zijn niet ingegeven");
        }

        private void btWhile_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            int endValue = 0;
            try
            {
                endValue = int.Parse(Joris2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is not a valid number \n" + ex.Message);
            }
            while (counter < endValue) 
            {
                MessageBoxResult myResult = MessageBox.Show("The counter is now " + counter + " do you want to continue?", "Titel", MessageBoxButton.YesNo, MessageBoxImage.Question);
                counter = counter + 1;
                if (myResult == MessageBoxResult.No)
                {
                    return;
                }
            }
        }

        private void btIfAndWhile_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            string ifBox = Joris.Text;
            int endValue = 0;
            MessageBoxResult myResult = MessageBoxResult.Yes;
            try
            {
                endValue = int.Parse(Joris2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("This is not a valid number \n" + ex.Message);
            }

            
            myResult = MessageBox.Show("Do you want to start?", "Start", MessageBoxButton.YesNoCancel, MessageBoxImage.Question) ;
            if (myResult == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                while (counter < endValue)
                {
                    if (myResult == MessageBoxResult.Yes && ifBox == "Optie 1")
                    {
                        myResult = MessageBox.Show("Optie 1 is getyped en er is op ja geklikt en de counter is nu " + counter, "Start", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                    }
                    else if (myResult == MessageBoxResult.Yes && ifBox != "Optie 1")
                    {
                        myResult = MessageBox.Show("Optie 1 is getyped en er is op ja geklikt en de counter is nu " + counter, "Start", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                    }
                    else
                    {
                        MessageBox.Show("U heeft op cancel geklikt, de counter is nu " + counter + " doei!");
                        return;
                    }
                    counter++;
                }
                
            }
        }
        
    }
}
