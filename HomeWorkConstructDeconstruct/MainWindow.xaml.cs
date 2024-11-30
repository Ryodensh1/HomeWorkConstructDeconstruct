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

namespace HomeWorkConstructDeconstruct
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Product> products = new List<Product>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            var product = new Product("Sample Product", 19.99m, "This is a sample product.");
            products.Add(product);
            ProductListBox.Items.Add(product.Name);
        }

        private void ShowProductDetails(object sender, RoutedEventArgs e)
        {
            if (ProductListBox.SelectedItem is null)
            {
                return;
            }
            var selectedProductName = ProductListBox.SelectedItem.ToString();
            var product = products.FirstOrDefault(p => p.Name == selectedProductName);

            if (product != null)
            {
                var (name, price, description) = product;
                MessageBox.Show($"Name: {name}\nPrice: {price}\nDescription: {description}", "Product Details");
            }
        }
    }


}
