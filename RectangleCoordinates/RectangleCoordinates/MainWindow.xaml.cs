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

namespace RectangleCoordinates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var items = new List<Item>
            {
                new Item { Name = "USA", Image = "C:\\Users\\nikit\\OneDrive\\Рабочий стол\\Programming\\C#\\RectangleCoordinates\\RectangleCoordinates\\Images\\usa.png" },
                new Item { Name = "Ukraine", Image = "C:\\Users\\nikit\\OneDrive\\Рабочий стол\\Programming\\C#\\RectangleCoordinates\\RectangleCoordinates\\Images\\ua.png" },
                new Item { Name = "Poland", Image = "C:\\Users\\nikit\\OneDrive\\Рабочий стол\\Programming\\C#\\RectangleCoordinates\\RectangleCoordinates\\Images\\pl.png" }
            };

            listBox.ItemsSource = items;
        }
    }
    public class Item
    {
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
