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

namespace MyFirstWpfHelloWorldApp_Joris_Wulms
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

        private void btHelloWorld(object sender, RoutedEventArgs e)
        {
            TextBox Joris = new TextBox();
            Joris.Name = "Hello!";
        }
    }
}
//UITLEG: Dit werkt in principe hetzelfde als bij de les van 13 sep 2021, alleen nu werken we met een MessageBox.
//Een MessageBox.Show zorgt ervoor dat als je op een knop klikt er een melding verschijnt van tekst. In dit geval "Well done Joris! :)"