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
            const string SumCommand = "sum";
            const string ExitCommand = "exit";

            int[] numbers = new int[1];
            int[] tempNumbers;
            int sumNumbersArray = 0;
            int userInputNumber;
            string userInputCommand;
            bool isActive = true;

            while (isActive == true)
            {
                userInputCommand = Console.ReadLine();

                switch (userInputCommand)
                {
                    case SumCommand:
                        Console.WriteLine("=");
                        sumNumbersArray = 0;
                        foreach (int number in numbers)
                        {
                            sumNumbersArray += number;
                        }
                        Console.WriteLine(sumNumbersArray + "\n+");
                        break;
                    case ExitCommand:
                        isActive = false;
                        Console.WriteLine("Выход ...");
                        break;
                    default:
                        Console.WriteLine("+");
                        userInputNumber = Convert.ToInt32(userInputCommand);

                        numbers[numbers.Length - 1] = userInputNumber;
                        tempNumbers = new int[numbers.Length + 1];

                        for (int currentIndex = 0; currentIndex < numbers.Length; currentIndex++)
                        {
                            tempNumbers[currentIndex] = numbers[currentIndex];
                        }

                        numbers = tempNumbers;
                        break;
                }
            }
        }
    }
}