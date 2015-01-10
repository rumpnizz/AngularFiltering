
using System;
using System.ComponentModel.DataAnnotations;

namespace AngularFiltering.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
