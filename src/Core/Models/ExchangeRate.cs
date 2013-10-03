namespace Core.Models
{
    public class ExchangeRate
    {
        public Currency From { get; set; }

        public Currency To { get; set; }

        public decimal Rate { get; set; }
    }
}