using System;
using ConsoleApp3.ConcreteFactory;
using ConsoleApp3.Factory;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ShapeFactory();
            ShapeProduct product = factory.Create<TriangleProduct>();
            Console.WriteLine(product.Corners);
            product = factory.Create<RectangleProduct>();
            Console.WriteLine(product.Corners);
        }
    }
}