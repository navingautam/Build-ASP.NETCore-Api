using System;
using System.Linq.Expressions;

namespace LandonApi.Infrastructure
{
    public class DefaultSearchExpressionProvider : ISearchExpressionProvider
    {
        public virtual ConstantExpression GetValue(string input)
            => Expression.Constant(input);
    }
}
