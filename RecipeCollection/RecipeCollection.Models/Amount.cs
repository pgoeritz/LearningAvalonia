namespace RecipeCollection.Models
{
    public enum EUnit
    {
        Gram,
        Liter,

    }

    public class Amount
    {
        public Amount(EUnit unit)
        {
            Unit = unit;
        }

        public ushort Value { get; set; }
        public EUnit Unit { get; }
    }
}