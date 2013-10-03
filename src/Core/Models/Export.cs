namespace Core.Models
{
    public class Export : Entity
    {
        public Jurisdiction To { get; set; }

        public Money Tarriff { get; set; }

        public Money Price { get; set; }

        public int Quantity { get; set; }

        public Measure Measure { get; set; }
    }
}
