using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PRINCIPLES.Console.Models
{
    public class ItemClassWrapper
    {
        public virtual ItemArticle Article { get; set; }
        public virtual  ItemElements Elements { get; set; }
    }
}
