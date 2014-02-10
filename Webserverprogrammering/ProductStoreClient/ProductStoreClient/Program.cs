using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreClient
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
    }

    class Program
    {
        static void Main()
        {
            RunAsync().Wait();
            Console.ReadKey();
        }

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                // Send HTTP request
                client.BaseAddress = new Uri("http://localhost:23202/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Send GET request
                HttpResponseMessage response = await client.GetAsync("api/products/1");
                if(response.IsSuccessStatusCode)
                {
                    Product product = await response.Content.ReadAsAsync<Product>();
                    Console.WriteLine("{0}\t${1}\t{2}",product.Name, product.Price,product.Category);
                }
                // HTTP POST
                var gizmo = new Product() { Name = "Gizmo", Price = 100, Category = "Widget" };
                response = await client.PostAsJsonAsync("api/products", gizmo);
                if(response.IsSuccessStatusCode)
                {
                    //get the uri of the created resource.
                    Uri gizmoUri = response.Headers.Location;

                    // HTTP PUT
                    gizmo.Price = 80; //update price
                    response = await client.PutAsJsonAsync(gizmoUri, gizmo);

                    // HTTP DELETE
                    response = await client.DeleteAsync(gizmoUri);
                }
                

            }
        }
    }

    

}
