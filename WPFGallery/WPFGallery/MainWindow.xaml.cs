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

namespace WPFGallery
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

        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string imagePath = txtImagePath.Text;

                if (!string.IsNullOrEmpty(imagePath))
                {
                    BitmapImage image = new BitmapImage(new Uri(imagePath));
                    imgGallery.Source = image;
                }
                else
                {
                    MessageBox.Show("Please enter a valid image path.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }

        private void SliderSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double newSize = e.NewValue * 100;
            lblSize.Content = $"{newSize:N0}%";
            imgGallery.Width = imgGallery.ActualWidth * e.NewValue;
        }

        private void SliderTransparency_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double newTransparency = e.NewValue * 100;
            lblTransparency.Content = $"{newTransparency:N0}%";
            imgGallery.Opacity = e.NewValue;
        }
    }
}
