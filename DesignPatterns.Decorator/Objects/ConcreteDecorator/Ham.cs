using DesignPatterns.Decorator.Objects.Component;
using DesignPatterns.Decorator.Objects.Decorator;

namespace DesignPatterns.Decorator.Objects.ConcreteDecorator
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza) : base(pizza)
        {
            Description = "Ham";
        }

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription()}, {Description}";
        }

        public override double CalculatePrice()
        {
            return Pizza.CalculatePrice() + 1.00;
        }
    }
}