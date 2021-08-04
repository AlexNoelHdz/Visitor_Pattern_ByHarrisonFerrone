using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class Item
    {
        public int ID;
        public double Price;

        public Item(int id, double price)
        {
            this.ID = id;
            this.Price = price;
        }

        public double GetDiscount(double percentage)
        {
            return Math.Round(Price * percentage, 2);
        }
    }

    public class Book: Item
    {
        public Book(int id, double price) : base(id, price) { }
    }

    public class Vinyl: Item
    {
        public Vinyl(int id, double price) : base(id, price) { }
    }
}
