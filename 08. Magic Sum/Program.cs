using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();

            int numberForEquel = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int secondNumber = arr[j];
                    int sum = currentNumber + secondNumber;

                    if (sum == numberForEquel)
                    {
                        Console.WriteLine(arr[i] + " " + arr[j]);
                    }                    
                }
            }

        }
    }
}
