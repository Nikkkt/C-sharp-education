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

namespace ButtonRGB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button button;
        public MainWindow()
        {
            InitializeComponent();

            button = new Button();
            button.Content = "My Button";
            button.Height = 50;
            button.Width = 100;

            Content = button;

            RoutedCommand commandR = new RoutedCommand();
            commandR.InputGestures.Add(new KeyGesture(Key.R, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(commandR, ChangeColorRed));

            RoutedCommand commandG = new RoutedCommand();
            commandG.InputGestures.Add(new KeyGesture(Key.G, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(commandG, ChangeColorGreen));

            RoutedCommand commandB = new RoutedCommand();
            commandB.InputGestures.Add(new KeyGesture(Key.B, ModifierKeys.Control));
            CommandBindings.Add(new CommandBinding(commandB, ChangeColorBlue));
        }

        void ChangeColorRed(object sender, ExecutedRoutedEventArgs e) { button.Background = Brushes.Red; }
        void ChangeColorGreen(object sender, ExecutedRoutedEventArgs e) { button.Background = Brushes.Green; }
        void ChangeColorBlue(object sender, ExecutedRoutedEventArgs e) { button.Background = Brushes.Blue; }
    }
}
