using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductsApp.Models;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{Id = 1, Name = "Tomato soup", Category = "groceries", Price = 1},
            new Product{Id = 2, Name = "Yo-yo", Category = "toys", Price = 3.75M},
            new Product{Id = 1, Name = "hammer", Category = "Hardware", Price = 16.99M}
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public 
    }
}
