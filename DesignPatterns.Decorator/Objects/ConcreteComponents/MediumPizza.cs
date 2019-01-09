using System.Runtime.InteropServices.WindowsRuntime;
using DesignPatterns.Decorator.Objects.Component;

namespace DesignPatterns.Decorator.Objects.ConcreteComponents
{
    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            Description = "Medium Pizza";
        }
        
        public override string GetDescription()
        {
            return Description;
        }

        public override double CalculatePrice()
        {
            return 6.00;
        }
    }
}