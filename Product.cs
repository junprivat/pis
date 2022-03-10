using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Product
    {
        public string Name { set; get; }
        public int Number { set; get; }
        public float Price { set; get; }
        
        public Product(string Name, int Number, float Price)
        {
            this.Name = Name;
            this.Number = Number;
            this.Price = Price;
        }
        public Product()
        { }
    }
}
