using OOP_PRINCIPLES.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PRINCIPLES.Console.DataAccess
{
    public class ProductHistoryCrudRepository : ICrudRepository<ProductHistory>
    {
        private readonly DatabaseManager _context;
        private readonly List<ProductHistory> ListSet;


        public ProductHistoryCrudRepository(DatabaseManager context)
        {
            _context = context;
            ListSet = _context.ProductPriceHistories;
        }

        public void DeleteRecord(int id)
        {
            ListSet.RemoveAt(id);
        }

        public void InsertData(ProductHistory product)
        {
            ListSet.Add(product);
        }

        public IEnumerable<ProductHistory> LoadData()
        {
            return ListSet.ToList();
        }

        public void UpdateRecord(ProductHistory product)
        {
            var existingProduct = ListSet.FirstOrDefault(p => p.ProductId == product.ProductId);
            if (existingProduct != null)
            {
                existingProduct.ListPrice = product.ListPrice;
                existingProduct.ModifiedDate = product.ModifiedDate;
            }
        }



    }
}
