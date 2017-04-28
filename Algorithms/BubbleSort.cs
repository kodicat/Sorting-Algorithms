using System.Collections.Generic;
using Contracts;

namespace Algorithms
{
	public class BubbleSort : ISortable<int>
	{
		public void Sort(IList<int> list)
		{
			var listLength = list.Count;
			bool swapped;
			do
			{
				swapped = false;
				for (var i = 1; i < listLength; i++)
				{
					if (list[i - 1] > list[i])
					{
						list.Swap(i - 1, i);
						swapped = true;
					}
				}
			} while (swapped);
		}
	}
}
