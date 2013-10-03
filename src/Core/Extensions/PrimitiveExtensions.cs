using System.Diagnostics;

namespace Core.Extensions
{
    [DebuggerStepThrough]
    public static class PrimitiveExtensions
    {
        public static string FormatWith(this string self, params object[] args)
        {
            return string.Format(self, args);
        }
    }
}