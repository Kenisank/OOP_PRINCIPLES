using OOP_PRINCIPLES.Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PRINCIPLES.Console.DataAccess
{
    public class DatabaseManager
    {

        private readonly string DirectoryPath;
        private readonly string ProductsFileName;
        private readonly string HistoriesFileName;


        public List<Product> Products { get; set; }=new List<Product>();
        public List<ProductHistory> ProductPriceHistories { get; set; }


        }
}
