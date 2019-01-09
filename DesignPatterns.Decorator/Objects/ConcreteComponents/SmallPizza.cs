using System.Runtime.InteropServices.WindowsRuntime;
using DesignPatterns.Decorator.Objects.Component;

namespace DesignPatterns.Decorator.Objects.ConcreteComponents
{
    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            Description = "Small Pizza";
        }
        
        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculatePrice()
        {
            return 3.00;
        }
    }
}