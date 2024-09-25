using Tyuiu.KovcharukEO.Sprint0.Task5.V0.Lib;
namespace Tyuiu.KovcharukEO.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(5, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(15, 7));
            Console.WriteLine("A * B = " + DataService.Multiplication(15, 10));
            Console.WriteLine("a / b = " + DataService.Division(9, 9));
            Console.ReadKey();
        }
    }
}
