using Headspring;

namespace Core.Models
{
    public class Jurisdiction : Enumeration<Jurisdiction>
    {
        public static readonly Jurisdiction UnitedStates = new Jurisdiction(1, "UnitedStates", Currency.UnitedStatesDollar);
        public static readonly Jurisdiction Mexico = new Jurisdiction(2, "Mexico", Currency.UnitedStatesDollar);
        public static readonly Jurisdiction Canada = new Jurisdiction(3, "Canada", Currency.CanadianDollar);
        public static readonly Jurisdiction Japan = new Jurisdiction(4, "Japan", Currency.JapaneseYen);
        public static readonly Jurisdiction Finland = new Jurisdiction(5, "Finland", Currency.Euro);
        public static readonly Jurisdiction Spain = new Jurisdiction(6, "Spain", Currency.Euro);
        public static readonly Jurisdiction France = new Jurisdiction(7, "France", Currency.Euro);

        public Jurisdiction(int value, string displayName, Currency currency) : base(value, displayName)
        {
            Currency = currency;
        }

        public Currency Currency { get; private set; }
    }
}
