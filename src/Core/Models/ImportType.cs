using Headspring;

namespace Core.Models
{
    public class ImportType : Enumeration<ImportType>
    {
        public static readonly ImportType IndustrialConsumer = new ImportType(1, "Industrial and Consumer goods");
        public static readonly ImportType Intermediate = new ImportType(2, "Intermediate goods and services");

        public ImportType(int value, string displayName) : base(value, displayName)
        {
        }
    }
}