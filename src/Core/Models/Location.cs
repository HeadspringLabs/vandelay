namespace Core.Models
{
    public class Location : Entity
    {
        public Jurisdiction Jurisdiction { get; set; }

        public Address Address { get; set; }
    }
}