using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WishList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<WishListItem> WishListItems { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            WishListItems = new ObservableCollection<WishListItem>();
            WishListView.ItemsSource = WishListItems;
        }

        private void AddItem_Click(object sender, RoutedEventArgs e)
        {
            AddRealItem();
        }

        private void SelectAllCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            foreach (WishListItem item in WishListItems)
            {
                item.IsSelected = true;
            }
        }

        private void SelectAllCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            foreach (WishListItem item in WishListItems)
            {
                item.IsSelected = false;
            }
        }

        private void ItemCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            WishListItem wishListItem = (WishListItem)checkBox.DataContext;

            MessageBox.Show($"Item '{wishListItem.ItemName}' checked!");
        }

        private void ItemCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            WishListItem wishListItem = (WishListItem)checkBox.DataContext;

            MessageBox.Show($"Item '{wishListItem.ItemName}' unchecked!");
        }

        private void RemoveSelected_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = WishListItems.Where(item => item.IsSelected).ToList();
            foreach (var selectedItem in selectedItems)
            {
                WishListItems.Remove(selectedItem);
            }
        }

        private void AddRealItem()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Icon",
                Filter = "Image files (*.png;*.jpeg;*.jpg;*.gif;*.bmp)|*.png;*.jpeg;*.jpg;*.gif;*.bmp|All files (*.*)|*.*"
            };

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                string itemName = Microsoft.VisualBasic.Interaction.InputBox("Enter Item Name:", "Add Item", "Default Item");
                double price;

                if (double.TryParse(Microsoft.VisualBasic.Interaction.InputBox("Enter Price:", "Add Item", "0.00"), out price))
                {
                    string icon = openFileDialog.FileName;

                    WishListItems.Add(new WishListItem
                    {
                        Icon = icon,
                        ItemName = itemName,
                        Price = price
                    });
                }
                else
                {
                    MessageBox.Show("Invalid price format. Please enter a valid number.");
                }
            }
        }
    }

    public class WishListItem
    {
        public string Icon { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public bool IsSelected { get; set; }
    }
}
