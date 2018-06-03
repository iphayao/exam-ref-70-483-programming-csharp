using System;
using System.Linq.Expressions;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-78 Creating "Hello World!" with an expression tree
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BlockExpression blockExpr = Expression.Block(
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("Write", new Type[] { typeof(String) }),
                    Expression.Constant("Hello")
                ),
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("WriteLine", new Type[] { typeof(String) }),
                    Expression.Constant("Hello")
                )
            );

            Expression.Lambda<Action>(blockExpr).Compile()();
        }
    }
}
