using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Produkt
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public Produkt() { }
        public Produkt(string name, int amount, double price) {
            this.Name = name;
            this.Amount = amount;
            this.Price = price;
        }
    }
}
