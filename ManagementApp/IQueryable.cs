using System;
using System.Linq;
using System.Linq.Expressions;

namespace YourNamespace
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> OrderByDynamic<T>(this IQueryable<T> query, string orderByMember, bool ascending)
        {
            var parameter = Expression.Parameter(typeof(T), "p");
            var memberAccess = Expression.PropertyOrField(parameter, orderByMember);
            var orderByLambda = Expression.Lambda(memberAccess, parameter);

            var orderByMethod = ascending ? "OrderBy" : "OrderByDescending";
            var resultExpression = Expression.Call(typeof(Queryable), orderByMethod,
                new Type[] { typeof(T), memberAccess.Type },
                query.Expression, Expression.Quote(orderByLambda));

            return query.Provider.CreateQuery<T>(resultExpression);
        }
    }
}