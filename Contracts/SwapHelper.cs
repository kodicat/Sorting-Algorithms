using System.Collections.Generic;

namespace Contracts
{
	public static class SwapHelper
	{
		public static void Swap<T>(this IList<T> list, int i1, int i2)
		{
			var temp = list[i2];
			list[i2] = list[i1];
			list[i1] = temp;
		}
	}
}
