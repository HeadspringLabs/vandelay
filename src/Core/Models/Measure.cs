using Headspring;

namespace Core.Models
{
    public class Measure : Enumeration<Measure>
    {
        public static readonly Measure Container = new Measure(1, "Intermodal freight container");
        public static readonly Measure CorrugatedBox = new Measure(2, "Corrugated box");
        public static readonly Measure WoodenBox = new Measure(3, "Wooden box");
        public static readonly Measure Crate = new Measure(4, "Crate");
        public static readonly Measure BulkBox = new Measure(5, "Bulk box");
        public static readonly Measure Drum = new Measure(6, "Drum");
        public static readonly Measure InsulatedContainer = new Measure(7, "Insulated shipping container");

        public static readonly Measure Each = new Measure(8, "Each");
		public static readonly Measure BulkContainer = new Measure(9, "Intermediate bulk shipping container");
		public static readonly Measure FlexibleContainer = new Measure(10, "Flexible Intermediate bulk container");

        public Measure(int value, string displayName) : base(value, displayName)
        {
        }
    }
}