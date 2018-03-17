using System;
using System.Linq;

namespace ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] numbers = text.Select(long.Parse).ToArray();
            long count = 0;
            long min = long.MaxValue;
            long max = long.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if(min > numbers[i])
                {
                    min = numbers[i];
                }
                if(max < numbers[i])
                {
                    max = numbers[i];
                }
                count += numbers[i];
            }
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {count}");
            Console.WriteLine($"Average = {((decimal)count/numbers.Length):f1}");
        }
    }
}
