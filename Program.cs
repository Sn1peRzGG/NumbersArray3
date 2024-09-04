using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersArray3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] numbers = new int[20];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(10, 100);
            }

            int maxSum = int.MinValue;
            int maxIndex = 0;

            for (int i = 0;i < numbers.Length - 2; i++)
            {
                int currentSum = numbers[i] + numbers[i + 1] + numbers[i + 2];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxIndex = i;
                }
            }

            Console.WriteLine("Масив чисел:");
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine($"\nНайбільша сума трьох послідовних чисел: {maxSum}");
            Console.WriteLine($"Індекси підмасиву з найбільшою сумою: {maxIndex}, {maxIndex + 1}, {maxIndex + 2}");
            Console.WriteLine($"Числа в цьому підмасиві: {numbers[maxIndex]}, {numbers[maxIndex + 1]}, {numbers[maxIndex + 2]}");
        }
    }
}
