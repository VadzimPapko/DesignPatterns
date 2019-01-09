using DesignPatterns.Decorator.Objects.Component;

namespace DesignPatterns.Decorator.Objects.Decorator
{
    public class PizzaDecorator : Pizza
    {
        protected readonly Pizza Pizza;

        public PizzaDecorator(Pizza pizza)
        {
            Pizza = pizza;
        }
        
        public override string GetDescription()
        {
            return Pizza.Description;
        }

        public override double CalculatePrice()
        {
            return Pizza.CalculatePrice();
        }
    }
}