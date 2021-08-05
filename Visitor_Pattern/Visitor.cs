using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
	public interface IVisitor
	{
		/// <summary>
		/// Visitor for Book Object
		/// </summary>
		/// <param name="book"></param>
		void VisitBook(Book book);
		/// <summary>
		/// Visitor for Vinyl Object
		/// </summary>
		/// <param name="vinyl"></param>
		void VisitVinyl(Vinyl vinyl);
		/// <summary>
		/// Helpful for debug
		/// </summary>
		void Print();
	}

	public interface IVisitableElement
	{
		/// <summary>
		/// Method that accepts a visitor type
		/// </summary>
		/// <param name="visitor"></param>
		void Accept(IVisitor visitor);
	}
	/// <summary>
	/// Adding Discount Functionality to visitable classes
	/// </summary>
	public class DiscountVisitor : IVisitor
	{
		/// <summary>
		/// Acumulating data example
		/// Savings on the objects we visited. 
		/// </summary>
		private double Savings { get; set; }

		public void VisitBook(Book book)
		{
			var discount = 0.0;

			if(book.Price < 20.00)
			{
				discount = book.GetDiscount(0.10);
				Console.WriteLine($"Discounted: Book #{book.ID} is now ${Math.Round(book.Price - discount, 2)}");
			}
			else 
			{
				Console.WriteLine($"Full Price: Book #{book.ID} is ${book.Price}");
			}

			Savings += discount;
		}

		public void VisitVinyl(Vinyl vinyl)
		{
			var discount = vinyl.GetDiscount(0.15);
			Console.WriteLine($"Super Savings: Vinyl #{vinyl.ID} is now ${Math.Round(vinyl.Price - discount, 2)}");
			Savings += discount;
		}

		public void Print()
		{
			Console.WriteLine($"\nYo saved a total of {Math.Round(Savings, 2)} on today's order!");
		}

		public void Reset()
		{
			Savings = 0.0;
		}
	}

	public class SalesVisitor : IVisitor
	{
		private int BookCount = 0;
		private int VinylCount = 0; 
		public void VisitBook(Book book)
		{
			BookCount++;
		}

		public void VisitVinyl(Vinyl vinyl)
		{
			VinylCount++;
		}

		public void Print()
		{
			Console.WriteLine($"Individual sales:\n{BookCount} books.\n{VinylCount} vinyls." +
				$"\nTotal Sales:\n{BookCount + VinylCount} units.");
		}
	}
}
