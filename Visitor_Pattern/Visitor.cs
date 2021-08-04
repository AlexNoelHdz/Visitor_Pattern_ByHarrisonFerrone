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
}
