using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAppBlazor.Data
{
    public class ProductService
    {
        private readonly ApplicationDbContext _db;
        public ProductService(ApplicationDbContext db)
        {
            _db = db;
         }
        
        public List<ProductInfo> GetProducts()
        {
            var PList = _db.Products.ToList();
            return PList;
        }
        public string Add(ProductInfo product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            return "Saved";
        }
        public ProductInfo GetProduct(int id)
        {
            ProductInfo product = _db.Products.FirstOrDefault(c => c.ProductId == id);
            return product;
        }
        public string UpdateProduct(ProductInfo product)
        {
            _db.Products.Update(product);
            _db.SaveChanges();
            return "Updated";
        }

        public string DeleteProduct(ProductInfo product)
        {
            _db.Remove(product);
            _db.SaveChanges();
            return "Deleted";
        }

    }
}
