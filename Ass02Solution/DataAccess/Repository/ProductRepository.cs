using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {

        public void Create(Product product)
        {
            AssSalesContext.Instance.Add(product);
            AssSalesContext.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            Product product = GetProduct(id);
            AssSalesContext.Instance.Remove(product);
            AssSalesContext.Instance.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return AssSalesContext.Instance.Products.ToList().FirstOrDefault(c => c.ProductId == id);
        }

        public List<Product> GetProducts() => AssSalesContext.Instance.Products.ToList();

        public void Update()
        {
            AssSalesContext.Instance.SaveChanges();
        }
    }
}
