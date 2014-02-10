using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HttpClient client = new HttpClient();
        ProductsCollection _Products = new ProductsCollection();

        public MainWindow()
        {
            InitializeComponent();

            client.BaseAddress = new Uri("http://localhost:23202");
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            this.ProductsList.ItemsSource = _Products;
        }

        private async void PostProduct(object sender, RoutedEventArgs e)
        {
            btnPostProduct.IsEnabled = false;

            try
            {
                var product = new Product()
                {
                    Name = textName.Text,
                    Price = double.Parse(textPrice.Text),
                    Category = textCategory.Text
                };
                var response = await client.PostAsJsonAsync("api/products",product);
                response.EnsureSuccessStatusCode(); // Throw on error code.

                _Products.Add(product);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Price must be a number");
            }
            finally
            {
                btnPostProduct.IsEnabled = true;
            }
        }

        private async void GetProducts(object sender, RoutedEventArgs e)
        {
            try
            {
                btnGetProducts.IsEnabled = false;

                var response = await client.GetAsync("api/Products");
                response.EnsureSuccessStatusCode(); //throws on errors code

                var products = await response.Content.ReadAsAsync<IEnumerable<Product>>();
                _Products.CopyFrom(products);
            }
            catch (Newtonsoft.Json.JsonException jEx)
            {
                // This exception indicates a problem deserializing the request body.
                MessageBox.Show(jEx.Message);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnGetProducts.IsEnabled = true;
            }
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }

    class ProductsCollection : ObservableCollection<Product>
    {
        public void CopyFrom(IEnumerable<Product> products)
        {
            this.Items.Clear();
            foreach (var p in products)
            {
                this.Items.Add(p);
            }

            this.OnCollectionChanged(
                new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
    }
}
