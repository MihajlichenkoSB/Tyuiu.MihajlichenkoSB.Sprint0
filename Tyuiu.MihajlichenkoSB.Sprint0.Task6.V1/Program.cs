using System.Security.Cryptography;
using Tyuiu.MihajlichenkoSB.Sprint0.Task6.V1.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint0.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynums));
            Console.WriteLine("Сумма элементов массива = " + DataService.SubtractionArray(arraynums));
            Console.WriteLine("Сумма элементов массива = " + DataService.MulpilicationArray(arraynums));
            Console.ReadKey();
        }
    } 
}