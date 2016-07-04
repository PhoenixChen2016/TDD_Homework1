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
        public IEnumerable<int> GroupingFieldValues<T>(IEnumerable<T> data, string fieldName, int pagingCount)
        {
            var paramExpr = Expression.Parameter(data.GetType().GetElementType(), "item");

            var lambdaExpr = Expression.Lambda(Expression.Property(paramExpr, fieldName), paramExpr);

            var expr = lambdaExpr.Compile();

            var query = from item in data.Select((item, index) => new { Index = index, Item = item })
                        let paging = Math.Truncate(item.Index / (double)pagingCount)
                        group item.Item by paging into g
                        select g.Sum(item => (int)expr.DynamicInvoke(item));

            return query.ToArray();
        }
    }
}
