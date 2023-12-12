using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PRINCIPLES.Console.Models
{
    public class Product:ItemClassWrapper
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int ProductNumber { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public int DaysToManufacture { get; set; }
        public DateTime SellStartDate { get; set; }
        public DateTime ModifiedDate { get; set;}

       
        public double ListPriceCost => StandardCost * ListPrice;
         
        public List<ProductHistory> Products { get; set; }

        public Product()
        {
            Products=new List<ProductHistory>();
        }
        
    }
}
