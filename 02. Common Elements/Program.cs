using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputOne = Console.ReadLine().Split(" "); ;
            string[] inputTwo = Console.ReadLine().Split(" "); ;
          
            foreach (string elementTwo in inputTwo)
            {
                for (int i = 0; i < inputOne.Length; i++)
                {
                    if (elementTwo == inputOne[i])
                    {
                        Console.Write(elementTwo + " ");
                        break;
                    }
                }
            }
        }
    }
}