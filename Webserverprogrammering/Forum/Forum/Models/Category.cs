using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Topic> topic { get; set; }
    }
}