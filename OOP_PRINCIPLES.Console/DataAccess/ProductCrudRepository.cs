using OOP_PRINCIPLES.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PRINCIPLES.Console.DataAccess
{
    public class ProductCrudRepository:ICrudRepository<Product>
    {
        private readonly DatabaseManager _context;
        private readonly List<Product> ListSet;
    

        public ProductCrudRepository(DatabaseManager context)
        {
            _context = context;
            ListSet = _context.Products;
         

        }

        public void DeleteRecord(int id)
        {
            ListSet.RemoveAt(id);
        }

        public void InsertData(Product product)
        {
            ListSet.Add(product);
        }

        public IEnumerable<Product> LoadData()
        {
            return ListSet.ToList();
        }

        public void UpdateRecord(Product product)
        {
            var existingProduct = ListSet.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (existingProduct != null)
            {
                existingProduct.ProductNumber = product.ProductNumber;
                existingProduct.ProductNumber = product.ProductNumber;
            }
        }



    }
}
