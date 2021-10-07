using System;

namespace DecoratorIcecream
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleIceCream simpleIceCream = new();
            HoneyIceCream honeyIceCream = new(simpleIceCream);
            Console.WriteLine(honeyIceCream.MakeIceCream());

            NutsIceCream nutsAndHoneyIceCream = new(honeyIceCream);
            Console.WriteLine(nutsAndHoneyIceCream.MakeIceCream());

            Console.ReadLine();
        }
    }
}
