namespace Tyuiu.MihajlichenkoSB.Sprint0.Task6.V1.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            return total;
        }
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;

            while (index < numbers.Length)
            {
                total = numbers[index]; 
            }
            return total;
        }
        public static object MulpilicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = numbers[index];
                index++;
            }
            while (index < numbers.Length);

            return total;
        }
    }
}
