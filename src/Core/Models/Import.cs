namespace Core.Models
{
    public class Import : Entity
    {
        public Jurisdiction From { get; set; }

        public ImportType Type { get; set; }
    }
}