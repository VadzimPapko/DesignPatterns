using System;
using DesignPatterns.Decorator.Objects.Component;
using DesignPatterns.Decorator.Objects.ConcreteComponents;
using DesignPatterns.Decorator.Objects.ConcreteDecorator;

namespace DesignPatterns.Decorator
{
    class Program
    {
        static void Main()
        {
            Pizza largePizza = new LargePizza();

            //Adding Cheese to Large Pizza
            largePizza = new Cheese(largePizza);
            
            //Adding Ham to Large Pizza
            largePizza = new Ham(largePizza);
            
            //Adding Peppers to Large
            largePizza = new Peppers(largePizza);
            
            Console.WriteLine(largePizza.GetDescription());
            Console.WriteLine("{0:C2}", largePizza.CalculatePrice());
            Console.ReadKey();
        }
    }
}