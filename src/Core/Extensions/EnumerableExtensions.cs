using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Core.Extensions
{
    [DebuggerStepThrough]
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> self, Action<T> action)
        {
            foreach (var item in self)
                action(item);
        }
    }
}