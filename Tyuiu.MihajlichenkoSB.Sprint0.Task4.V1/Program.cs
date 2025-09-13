using Tyuiu.MihajlichenkoSB.Sprint0.Task4.V1.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint0.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Subtraction(5, 10));
            Console.WriteLine(DataService.Multiplication(5, 10));
            Console.WriteLine(DataService.Division(5, 5));
            Console.ReadKey();
        }
    }
}