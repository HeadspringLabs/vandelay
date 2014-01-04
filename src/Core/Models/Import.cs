namespace Core.Models
{
    public class Import : Entity
    {
        public Jurisdiction From { get; set; }

        public ImportType Type { get; set; }

		public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}