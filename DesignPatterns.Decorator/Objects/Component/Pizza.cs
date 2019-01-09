namespace DesignPatterns.Decorator.Objects.Component
{
    /// <summary>
    /// Base Decorator Pattern Component.
    /// </summary>
    public abstract class Pizza
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double CalculatePrice();
    }
}