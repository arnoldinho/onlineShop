using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
namespace Application
{
    public interface IMethodsRepository
    {
        void Add(Product p);
        void Edit(Product p);
        void Remove(int? productID);
        IEnumerable<Product> GetProducts();
        Product FindById(int? productID);
    }
}
