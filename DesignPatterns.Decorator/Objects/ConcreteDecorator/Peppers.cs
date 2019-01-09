using DesignPatterns.Decorator.Objects.Component;
using DesignPatterns.Decorator.Objects.Decorator;

namespace DesignPatterns.Decorator.Objects.ConcreteDecorator
{
    public class Peppers : PizzaDecorator
    {
        public Peppers(Pizza pizza) : base(pizza)
        {
            Description = "Peppers";
        }

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription()}, {Description}";
        }

        public override double CalculatePrice()
        {
            return Pizza.CalculatePrice() + 2.00;
        }
    }
}