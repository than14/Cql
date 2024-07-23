using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;
using Expression = System.Linq.Expressions.Expression;

namespace ManagementApp
{
    public static class IQueryableExtensions
    {
        //public static IQueryable<T> OrderByDynamicAll<T>(this IQueryable<T> query, string orderByMember, bool ascending)
        //{
        //        var parameter = Expression.Parameter(typeof(T), "p");
        //        var memberAccess = Expression.PropertyOrField(parameter, orderByMember);
        //        var orderByLambda = Expression.Lambda(memberAccess, parameter);

        //        var orderByMethod = ascending ? "OrderBy" : "OrderByDescending";
        //        var resultExpression = Expression.Call(typeof(Queryable), orderByMethod,
        //            new Type[] { typeof(T), memberAccess.Type },
        //            query.Expression, Expression.Quote(orderByLambda));

        //        return query.Provider.CreateQuery<T>(resultExpression);
            
            
        //}
        //public static IQueryable<T> OrderByDynamic1<T>(this IQueryable<T> query, string sortColumn, bool ascending)
        //{
        //    var parameter = Expression.Parameter(typeof(T), "p");
        //    var property = Expression.Property(parameter, sortColumn);
        //    var sortExpression = Expression.Lambda(property, parameter);

        //    var method = ascending ? "OrderBy" : "OrderByDescending";
        //    var resultExpression = Expression.Call(typeof(Queryable), method, new Type[] { typeof(T), property.Type }, query.Expression, Expression.Quote(sortExpression));
        //    return query.Provider.CreateQuery<T>(resultExpression);
        //}
        //public static IQueryable<T> OrderByDynamic<T>(this IQueryable<T> source, string propertyName, bool ascending)
        //{
        //    var parameter = Expression.Parameter(typeof(T), "p");
        //    var property = Expression.Property(parameter, propertyName);
        //    var lambda = Expression.Lambda(property, parameter);
        //    var methodName = ascending ? "OrderBy" : "OrderByDescending";
        //    var method = typeof(Queryable).GetMethods()
        //                                  .Single(m => m.Name == methodName && m.GetParameters().Length == 2)
        //                                  .MakeGenericMethod(typeof(T), property.Type);
        //    return (IQueryable<T>)method.Invoke(null, new object[] { source, lambda });
        //}
        public static IQueryable<T> OrderByDynamic<T>(this IQueryable<T> source, string propertyName, bool ascending)
        {
            var parameter = Expression.Parameter(typeof(T), "p");
            var property = Expression.Property(parameter, propertyName);
            var lambda = Expression.Lambda(property, parameter);
            var methodName = ascending ? "OrderBy" : "OrderByDescending";
            var method = typeof(Queryable).GetMethods()
                                          .Single(m => m.Name == methodName && m.GetParameters().Length == 2)
                                          .MakeGenericMethod(typeof(T), property.Type);
            return (IQueryable<T>)method.Invoke(null, new object[] { source, lambda });
        }
    }
}