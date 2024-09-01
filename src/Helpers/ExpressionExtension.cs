using System.Linq.Expressions;

namespace Pagination.Demo.Helpers
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1,
        Expression<Func<T, bool>> expr2)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T));

            Expression combined = new ReplaceParameterVisitor
            {
                Sub = expr1.Parameters[0],
                New = parameter
            }.Visit(expr1.Body);

            combined = Expression.AndAlso(combined, new ReplaceParameterVisitor
            {
                Sub = expr2.Parameters[0],
                New = parameter
            }.Visit(expr2.Body));

            return Expression.Lambda<Func<T, bool>>(combined, parameter);
        }

        private class ReplaceParameterVisitor: ExpressionVisitor
        {
            public ParameterExpression Sub;
            public ParameterExpression New;

            protected override Expression VisitParameter(ParameterExpression node)
            {
                return ReferenceEquals(node, Sub) ? New : node;
            }
        }
    }

}
