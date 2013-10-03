namespace Core.Models
{
    public class Export : Entity
    {
        public Jurisdiction To { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Measure Measure { get; set; }
    }
}
