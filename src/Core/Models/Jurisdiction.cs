using Headspring;

namespace Core.Models
{
    public class Jurisdiction : Enumeration<Jurisdiction>
    {
        public static readonly Jurisdiction UnitedStates = new Jurisdiction(1, "UnitedStates");
        public static readonly Jurisdiction Mexico = new Jurisdiction(2, "Mexico");
        public static readonly Jurisdiction Canada = new Jurisdiction(3, "Canada");
        public static readonly Jurisdiction Japan = new Jurisdiction(4, "Japan");
        public static readonly Jurisdiction Finland = new Jurisdiction(5, "Finland");
        public static readonly Jurisdiction Spain = new Jurisdiction(6, "Spain");
        public static readonly Jurisdiction France = new Jurisdiction(7, "France");

        public Jurisdiction(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
