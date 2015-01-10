using System.Collections.Generic;
using AngularFiltering.DAL.Models;

namespace AngularFiltering.MVC.ApiModels
{
    public class ProductsVM
    {
        public Product product { get; set; }

        public List<Product> products { get; set; }

        public int count { get; set; } 
    }
}