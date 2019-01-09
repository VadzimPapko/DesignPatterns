using DesignPatterns.Decorator.Objects.Component;
using DesignPatterns.Decorator.Objects.Decorator;

namespace DesignPatterns.Decorator.Objects.ConcreteDecorator
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
        }

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription()}, {Description}";
        }

        public override double CalculatePrice()
        {
            return Pizza.CalculatePrice() + 1.25;
        }
    }
}