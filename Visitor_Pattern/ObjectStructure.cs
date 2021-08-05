using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
	public class ObjectStructure
	{
		private List<IVisitableElement> Cart;

		public ObjectStructure(List<IVisitableElement> cart)
		{
			Cart = cart; 
		}

		public void RemoveElement(IVisitableElement element)
		{
			Cart.Remove(element);
		}

		public void ApplyVisitor(IVisitor visitor)
		{
			Console.WriteLine("\n-------- Visitor Breakdown --------");

			foreach (var item in Cart)
				item.Accept(visitor);

			visitor.Print();
		}
	}
}
