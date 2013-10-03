using System;
using System.Diagnostics;
using Core.Models;

namespace Core.Extensions
{
    [DebuggerStepThrough]
    public static class MoneyExtensions
    {
        public static Money Euro(this int self)
        {
            return Euro(Convert.ToDecimal(self));
        }

        public static Money Euro(this decimal self)
        {
            return new Money(self, Currency.Euro);
        }

        public static Money USD(this int self)
        {
            return USD(Convert.ToDecimal(self));
        }

        public static Money USD(this decimal self)
        {
            return new Money(self, Currency.UnitedStatesDollar);
        }
    }
}