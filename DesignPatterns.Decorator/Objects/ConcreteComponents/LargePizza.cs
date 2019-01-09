using System.Runtime.InteropServices.WindowsRuntime;
using DesignPatterns.Decorator.Objects.Component;

namespace DesignPatterns.Decorator.Objects.ConcreteComponents
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
        }
        
        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculatePrice()
        {
            return 9.00;
        }
    }
}