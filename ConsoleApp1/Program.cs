using System;

class Calculator
{
    public virtual void Solution()
    {
        Console.WriteLine("The solution of given equations");
    }
}
class Addition:Calculator
{
    public override void Solution()
    {
        Console.Write("The sum of 2 and 5 is: ");
        Console.WriteLine(2+5);
    }
}
class Substract:Calculator
{
    public override void Solution()
    {
        Console.Write("The substraction of 9 and 3 is: ");
        Console.WriteLine(9 - 3);
    }
}
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism with override");
            Calculator cal = new Calculator();
            Calculator sum = new Addition();
            Calculator sub = new Substract();
            cal.Solution();
            sum.Solution();
            sub.Solution();

            Console.WriteLine("\n");
            Console.WriteLine("Polymorphism with overloading");
            Class1 area = new Class1();
            area.Shape();
            int sq1 = area.Shape(2);
            Console.WriteLine("area of square with side = 2 is " + sq1);
            double sq2 = area.Shape(2.3);
            Console.WriteLine("area of square with side = 2.3 is " + sq2);
            int rec = area.Shape(2,3);
            Console.WriteLine("area of reactangle with side 2X3 is " + rec);
        }
    }
}
