using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace PagingGroup
{
	public class PagingGroup
	{
		public IEnumerable<int> GroupingFieldValues<T, TResult>(IEnumerable<T> data, Func<T, TResult> field, int pagingCount)
		{
			var query = from item in data.Select((item, index) => new { Index = index, Item = item })
						let paging = Math.Truncate(item.Index / (double)pagingCount)
						group item.Item by paging into g
						select g.Sum(item => (dynamic)field(item));

			return query.ToArray();
		}
	}
}
