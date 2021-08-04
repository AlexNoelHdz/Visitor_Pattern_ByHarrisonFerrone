using System;
using System.Collections.Generic;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Object> items = new List<Object>
            {
                new Book(12345, 11.99),
                new Book(78910, 22.79),
                new Vinyl(11198, 17.99),
                new Book(63254, 9.79)
            };

        }
    }
}
