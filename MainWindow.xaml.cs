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

namespace MiiCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            HeadTab.IsChecked = true;
            Head1.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Head1.Fill = Brushes.Cornsilk;
            Head2.Fill = Brushes.Cornsilk;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Head1.Fill = Brushes.BurlyWood;
            Head2.Fill = Brushes.BurlyWood;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Head1.Fill = Brushes.SaddleBrown;
            Head2.Fill = Brushes.SaddleBrown;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(HeadTab.IsChecked == true)
            {
                HeadOptions1.Visibility = Visibility.Visible;
                HeadOptions2.Visibility = Visibility.Visible;
            }
            else
            {
                HeadOptions1.Visibility = Visibility.Hidden;
                HeadOptions2.Visibility = Visibility.Hidden;
            }
        }

        private void HeadOptions1_Click(object sender, RoutedEventArgs e)
        {
            Head1.Visibility = Visibility.Visible;
            Head2.Visibility = Visibility.Hidden;
        }

        private void HeadOptions2_Click(object sender, RoutedEventArgs e)
        {
            Head2.Visibility = Visibility.Visible;
            Head1.Visibility = Visibility.Hidden;
        }

        private void MouthTab_Checked(object sender, RoutedEventArgs e)
        {
            if (MouthTab.IsChecked == true)
            {
                MouthOptions1.Visibility = Visibility.Visible;
                MouthOptions2.Visibility = Visibility.Visible;
            }
            else
            {
                MouthOptions1.Visibility = Visibility.Hidden;
                MouthOptions2.Visibility = Visibility.Hidden;
            }
        }

        private void EyesTab_Checked(object sender, RoutedEventArgs e)
        {
            if (EyesTab.IsChecked == true)
            {
                EyeOptions1.Visibility = Visibility.Visible;
                EyeOptions2.Visibility = Visibility.Visible;
            }
            else
            {
                EyeOptions1.Visibility = Visibility.Hidden;
                EyeOptions2.Visibility = Visibility.Hidden;
            }
        }

        private void NoseTab_Checked(object sender, RoutedEventArgs e)
        {
            if (NoseTab.IsChecked == true)
            {
                NoseOptions1.Visibility = Visibility.Visible;
                NoseOptions2.Visibility = Visibility.Visible;
            }
            else
            {
                NoseOptions1.Visibility = Visibility.Hidden;
                NoseOptions2.Visibility = Visibility.Hidden;
            }
        }

        private void OtherTab_Checked(object sender, RoutedEventArgs e)
        {
            if (OtherTab.IsChecked == true)
            {
                OtherOptions1.Visibility = Visibility.Visible;
                OtherOptions2.Visibility = Visibility.Visible;
            }
            else
            {
                OtherOptions1.Visibility = Visibility.Hidden;
                OtherOptions2.Visibility = Visibility.Hidden;
            }
        }

        private void MouthOptions1_Click(object sender, RoutedEventArgs e)
        {
            Mouth2.Visibility = Visibility.Hidden;
            Mouth1.Visibility = Visibility.Visible;
        }

        private void MouthOptions2_Click(object sender, RoutedEventArgs e)
        {
            Mouth1.Visibility = Visibility.Hidden;
            Mouth2.Visibility = Visibility.Visible;
        }

        private void EyeOptions1_Click(object sender, RoutedEventArgs e)
        {
            Eyes2.Visibility = Visibility.Hidden;
            Eyes1.Visibility = Visibility.Visible;
        }

        private void EyeOptions2_Click(object sender, RoutedEventArgs e)
        {
            Eyes1.Visibility = Visibility.Hidden;
            Eyes2.Visibility = Visibility.Visible;
        }

        private void NoseOptions1_Click(object sender, RoutedEventArgs e)
        {
            Nose2.Visibility = Visibility.Hidden;
            Nose1.Visibility = Visibility.Visible;
        }

        private void NoseOptions2_Click(object sender, RoutedEventArgs e)
        {
            Nose1.Visibility = Visibility.Hidden;
            Nose2.Visibility = Visibility.Visible;
        }

        private void OtherOptions1_Click(object sender, RoutedEventArgs e)
        {
            Other.Visibility = Visibility.Hidden;
        }

        private void OtherOptions2_Click(object sender, RoutedEventArgs e)
        {
            Other.Visibility = Visibility.Visible;
        }
    }
}
