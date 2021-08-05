using System;
using System.Collections.Generic;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
		{
			List<IVisitableElement> items = PerformSales();
			ImplementDiscountVisitor(items);
			ImplementSalesVisitor(items);
		}

		private static List<IVisitableElement> PerformSales()
		{
			return new List<IVisitableElement>
			{
				new Book(12345, 11.99),
				new Book(78910, 22.79),
				new Vinyl(11198, 17.99),
				new Book(63254, 9.79)
			};
		}

		private static void ImplementSalesVisitor(List<IVisitableElement> items)
		{
			var visitor = new SalesVisitor();
			foreach (var item in items)
				item.Accept(visitor);

			visitor.Print();
		}

		private static void ImplementDiscountVisitor(List<IVisitableElement> items)
		{
			var visitor = new DiscountVisitor();
			foreach (var item in items)
				item.Accept(visitor);

			visitor.Print();
		}
	}
}
