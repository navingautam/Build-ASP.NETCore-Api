using System;
using System.Linq.Expressions;

namespace LandonApi.Infrastructure
{
    public interface ISearchExpressionProvider
    {
        ConstantExpression GetValue(string input);
    }
}
