namespace Core.Models
{
    using System.Collections.Generic;

    public class SalesAgent : Entity
    {
        public string ImageUrl { get; set; }

        public Location Location { get; set; }

        public List<Export> Exports { get; set; }

        public List<Import> Imports { get; set; }
    }
}