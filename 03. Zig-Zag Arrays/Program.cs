using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string[] firstArray = new string[input];
            string[] secondArray = new string[input];

            for (int i = 0; i < input; i++)
            {
                string[] currentArray = Console.ReadLine()
                                      .Split(" ")
                                      .ToArray();

                string indexZeroElement = currentArray[0];
                string indexOneElement = currentArray[1];

                if (i % 2 == 0)
                {
                    firstArray[i] = indexZeroElement;
                    secondArray[i] = indexOneElement;
                }
                else
                {
                    secondArray[i] = indexZeroElement;
                    firstArray[i] = indexOneElement;

                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
