using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeWorkConstructDeconstruct
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        // Конструктор по умолчанию
        public Product() { }

        // Конструктор с параметрами
        public Product(string name, decimal price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        // Деконструктор
        public void Deconstruct(out string name, out decimal price, out string description)
        {
            name = Name;
            price = Price;
            description = Description;
        }

    }
    


}
