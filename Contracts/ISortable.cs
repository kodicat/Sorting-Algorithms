using System.Collections.Generic;

namespace Contracts
{
	public interface ISortable<T>
	{
		void Sort(IList<T> list);
	}
}
