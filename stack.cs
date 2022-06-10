using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
	internal class Stack
	{

		public static void Main(string[] args)
		{
			//Creating a Stack
			Stack<int> st = new Stack<int>(5);

			//push()

			st.Push(110);
			st.Push(120);
			st.Push(130);
			st.Push(140);
			st.Push(150);

			//displaying stack elements
			Console.WriteLine("Elements in Stack are: ");
			foreach (int element in st)
				Console.WriteLine(element);

			//st.Pop();
			//st.Pop();
			Console.WriteLine("1st popped element " + st.Pop());
			Console.WriteLine("2nd popped element: " + st.Pop()); ;
			Console.WriteLine("top most element is: " + st.Peek());


			//resultant stack
			Console.WriteLine("The updated Stack is: ");
			foreach (int element in st)
				Console.WriteLine(element);
			Console.ReadLine();
		}


	}

}
