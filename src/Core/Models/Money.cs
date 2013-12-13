using System;
using Core.Extensions;

namespace Core.Models
{
    public class Money : IEquatable<Money>
    {
        private readonly decimal _money;
        private readonly Currency _currency;

        internal Money(decimal money, Currency currency)
        {
            _money = money;
            _currency = currency;
        }

        public bool Equals(Money other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Equals(_currency, other._currency) && _money == other._money;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Money)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((_currency != null ? _currency.GetHashCode() : 0) * 397) ^ _money.GetHashCode();
            }
        }

        public static implicit operator decimal(Money money)
        {
            return money._money;
        }

        public static bool operator ==(Money left, Money right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Money left, Money right)
        {
            return !Equals(left, right);
        }

        public static Money operator -(Money left, Money right)
        {
            CheckCurrencyMath("subtract", left, right);
            return new Money(left._money - right._money, left._currency);
        }

        public static Money operator +(Money left, Money right)
        {
            CheckCurrencyMath("add", left, right);
            return new Money(left._money + right._money, left._currency);
        }

        private static void CheckCurrencyMath(string action, Money left, Money right)
        {
            if (left._currency != right._currency)
                throw new ArgumentException("Attempt to {0} {1} ({2}) and {3} ({4}) failed. Only amounts in the same currency can be {0}ed."
                    .FormatWith(action, left.ToString(), left._currency.DisplayName, right.ToString(), right._currency.DisplayName));
        }

        public override string ToString()
        {
            return string.Format("{0}{1:0.00}", _currency.Symbol, _money);
        }
    }
}