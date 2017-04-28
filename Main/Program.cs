using System;
using System.Collections.Generic;
using Algorithms;

namespace Main
{
	class Program
	{
		static void Main(string[] args)
		{
			var list = new List<int>()
			{
				3, 5, 1, 8, 2, 9, 0, 4, 7, 6
			};

			list.ForEach(i => Console.Write($"{i} "));
			Console.WriteLine();

			var algorithm = new BubbleSort();
			algorithm.Sort(list);

			list.ForEach(i => Console.Write($"{i} "));
			Console.WriteLine();
		}
	}
}
