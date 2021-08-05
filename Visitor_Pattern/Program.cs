using System;
using System.Collections.Generic;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
		{
			List<IVisitableElement> items = FillSales();
			var cart = new ObjectStructure(items);
			var discountVisitor = new DiscountVisitor();
			var salesVisitor = new SalesVisitor();

			cart.ApplyVisitor(discountVisitor);
			cart.ApplyVisitor(salesVisitor);


			#region Individual calls
			discountVisitor.Reset();
			cart.RemoveElement(items[2]);
			#endregion

			cart.ApplyVisitor(discountVisitor);
		}

		private static List<IVisitableElement> FillSales()
		{
			return new List<IVisitableElement>
			{
				new Book(12345, 11.99),
				new Book(78910, 22.79),
				new Vinyl(11198, 17.99),
				new Book(63254, 9.79)
			};
		}
	}
}
