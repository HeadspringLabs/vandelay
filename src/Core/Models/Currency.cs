using System.Globalization;
using Headspring;

namespace Core.Models
{
    public class Currency : Enumeration<Currency>
    {
        public static readonly Currency Euro = new Currency(1, '\u20AC'.ToString(CultureInfo.InvariantCulture), "Euro");
        public static readonly Currency PoundSterling = new Currency(2, '\u00A3'.ToString(CultureInfo.InvariantCulture), "Pound Sterling");
        public static readonly Currency AustralianDollar = new Currency(3, "$", "Australian Dollar");
        public static readonly Currency NewZealandDollar = new Currency(4, "$", "New Zealand Dollar");
        public static readonly Currency UnitedStatesDollar = new Currency(5, "$", "United States Dollar");
        public static readonly Currency CanadianDollar = new Currency(6, "$", "Canadian Dollar");
        public static readonly Currency SwissFranc = new Currency(7, "Fr", "Swiss Franc");
        public static readonly Currency JapaneseYen = new Currency(8, '\u00A5'.ToString(CultureInfo.InvariantCulture), "Japanese Yen");

        public Currency(int value, string symbol, string displayName) : base(value, displayName)
        {
            Rank = value;
            Symbol = symbol;
        }

        public int Rank { get; private set; }

        public string Symbol { get; private set; }
    }
}