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

namespace Portfolio_opdracht_Panels_XAML_Joris_Wulms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random myRandomizer = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem SelectedCountry = (ComboBoxItem)myCombobox.SelectedItem;
            if (SelectedCountry == null)
            {
                MessageBox.Show("Selecteer aub een land!");
                return;
            }
            string selectFood = SelectedCountry.Name.ToString();
            Button myButton = new Button();


            myButton.Background = new SolidColorBrush(
                Color.FromRgb((byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256)));

            myButton.Foreground = new SolidColorBrush(
                Color.FromRgb((byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256)));

            myButton.Content = selectFood;
            myStackpanel.Children.Add(myButton);

            Button myButton2 = new Button();


            myButton2.Background = new SolidColorBrush(
                Color.FromRgb((byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256)));

            myButton2.Foreground = new SolidColorBrush(
                Color.FromRgb((byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256)));

            myButton2.Content = selectFood;
            myWrappanel.Children.Add(myButton2);

            Button myButton3 = new Button();


            myButton3.Background = new SolidColorBrush(
                Color.FromRgb((byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256)));

            myButton3.Foreground = new SolidColorBrush(
                Color.FromRgb((byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256),
                              (byte)myRandomizer.Next(0, 256)));

            myButton3.Content = selectFood;

            ComboBoxItem SelectedSide = (ComboBoxItem)sidechoser.SelectedItem;
            if (SelectedSide == null)
            {
                MessageBox.Show("Selecteer aub of je hem links, rechts, onder of boven uitgelijnd wilt hebben in de dockpanel!");
                return;
            }
            string selectSide = SelectedSide.Content.ToString();

            if (selectSide == "Left")
            {
                DockPanel.SetDock(myButton3, Dock.Left);
                myDockpanel.Children.Add(myButton3);
            }
            else if(selectSide == "Right")
            {
                DockPanel.SetDock(myButton3, Dock.Right);
                myDockpanel.Children.Add(myButton3);
            }
            else if (selectSide == "Top")
            {
                DockPanel.SetDock(myButton3, Dock.Top);
                myDockpanel.Children.Add(myButton3);
            }
            else if (selectSide == "Bottom")
            {
                DockPanel.SetDock(myButton3, Dock.Bottom);
                myDockpanel.Children.Add(myButton3);
            }

        }

        private void myCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (myCombobox.SelectedIndex != -1)
            {
                ComboBoxItem selItem = (ComboBoxItem)myCombobox.SelectedItem;
                StackPanel selSpItem = selItem.Content as StackPanel;
                Image itemImage = selSpItem.Children[0] as Image;

                Image img = new Image();
                img.Source = itemImage.Source;
                img.Width = 60;
                img.Height = 30;

                myFlagsPanel.Children.Add(img);
            }
        }
    }
}
