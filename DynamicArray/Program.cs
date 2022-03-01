using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[1];
            int[] tempNumbers;
            int sumNumbersArray = 0;
            int userInputNumber;
            string userInputCommand;
            string sumCommand = "sum";
            bool isActive = true;

            while (isActive == true)
            {
                userInputCommand = Console.ReadLine();

                if (userInputCommand.Equals(sumCommand))
                {
                    isActive = false;
                    Console.WriteLine("=");
                }
                else
                {
                    Console.WriteLine("+");
                    userInputNumber = Convert.ToInt32(userInputCommand);

                    numbers[numbers.Length - 1] = userInputNumber;
                    tempNumbers = new int[numbers.Length + 1];

                    for (int currentIndex = 0; currentIndex < numbers.Length; currentIndex++)
                    {
                        tempNumbers[currentIndex] = numbers[currentIndex];
                    }

                    numbers = tempNumbers;
                }
            }

            foreach (var number in numbers)
            {
                sumNumbersArray += number;
            }

            Console.WriteLine(sumNumbersArray);
        }
    }
}