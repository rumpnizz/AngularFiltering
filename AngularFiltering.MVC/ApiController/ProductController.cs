using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using AngularFiltering.DAL.Models;
using AngularFiltering.MVC.ApiModels;

namespace AngularFiltering.MVC.Controllers
{
    // /api/get
    public class ProductController : LazyLoaderApiController
    {
        public ProductsVM GetAll(int page = 1, int take = 10)
        {
            var count = Ctx.Products.Count();
            var products = Ctx.Products.Skip((page - 1) * take).Take(take).ToList();

            return new ProductsVM {products = products, count = count};
        }

        public ProductsVM Get(int id)
        {
            var product = Ctx.Products.Find(id);

            return new ProductsVM() { product = product };
        }

        [HttpPost, HttpPut]
        public ProductsVM Save(Product model)
        {
            var isEdit = model.Id > 0;

            var product = isEdit 
                ? Ctx.Products.Find(model.Id) 
                : new Product() { CreatedDate = DateTime.UtcNow };

            product.Name = model.Name;
            product.Price = model.Price;
            product.Description = model.Description;

            Ctx.Entry(product).State = isEdit
                ? EntityState.Modified
                : EntityState.Added;
            
            Ctx.SaveChanges();

            return new ProductsVM() { product = product };
        }
    }
}
