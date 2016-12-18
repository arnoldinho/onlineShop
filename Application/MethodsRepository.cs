using ProductDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity;
using System.Net;
//using System.Web.Mvc;
using Domain.Model;

namespace Application
{
    public class MethodsRepository : IMethodsRepository
    {
        ProductDbContext context = new ProductDbContext();
        public void Add(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }

        public void Edit(Product p)
        {
            context.Entry(p).State = System.Data.Entity.EntityState.Modified;
        }

        public Product FindById(int? productID)
        {
            var bloodDonor = (from p in context.Products where p.Id == productID select p).FirstOrDefault();
            return bloodDonor;
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products;
        }

        public void Remove(int? productID)
        {
            Product p = context.Products.Find(productID);
            context.Products.Remove(p);
            context.SaveChanges();
        }
    }
}
