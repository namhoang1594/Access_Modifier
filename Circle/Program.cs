using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine(circle.GetRadius());
            Console.WriteLine(circle.GetColor());
        }
    }
}
