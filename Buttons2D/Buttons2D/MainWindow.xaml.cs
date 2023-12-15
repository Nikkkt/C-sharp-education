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

namespace Buttons2D
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int rowCount = 10;
        private int columnCount = 10;
        private Button[,] buttonGrid;

        public MainWindow()
        {
            InitializeComponent();
            InitializeButtonGrid();
        }

        private void InitializeButtonGrid()
        {
            Grid mainGrid = new Grid
            {
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch
            };

            buttonGrid = new Button[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                mainGrid.RowDefinitions.Add(new RowDefinition());
                for (int j = 0; j < columnCount; j++)
                {
                    mainGrid.ColumnDefinitions.Add(new ColumnDefinition());
                    Button button = new Button
                    {
                        Content = (i * columnCount) + j + 1,
                        Width = 40,
                        Height = 40,
                        Background = GetRandomColor()
                    };

                    button.Click += Button_Click;
                    buttonGrid[i, j] = button;
                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);
                    mainGrid.Children.Add(button);
                }
            }

            Content = mainGrid;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            ((Grid)Content).Children.Remove(clickedButton);

            if (buttonGrid[rowCount - 1, columnCount - 1] != null) buttonGrid[rowCount - 1, columnCount - 1].IsEnabled = false;
        }

        private SolidColorBrush GetRandomColor()
        {
            Random random = new Random();
            Color color = Color.FromRgb((byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256));
            return new SolidColorBrush(color);
        }
    }
}
