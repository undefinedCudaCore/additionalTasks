using System;
using System.Diagnostics;
using System.Security.Claims;

namespace numberTasks
{
    internal class Program
    {
        static void CalculateDigits()
        {

            Console.WriteLine("Enter number:");

            string cachedNumberString = Console.ReadLine();

            int cachedNumberStringLength = cachedNumberString.Length;

            int cachedNumber = Convert.ToInt32(cachedNumberString);

            switch (cachedNumberStringLength)
            {
                case 1:
                    if (cachedNumberStringLength < 2)
                    {
                        Console.WriteLine(cachedNumber);
                        CalculateDigits();
                    }
                    break;

                case 2:
                    if (cachedNumberStringLength == 2)

                    {
                        int firstNumber = cachedNumber / 10;
                        int secondNumber = cachedNumber % 10;
                        int thirdNumber = firstNumber + secondNumber;

                        Console.WriteLine(thirdNumber);
                        CalculateDigits();
                    }
                    break;
                case 3:
                    if (cachedNumberStringLength >= 3)
                    {
                        int firstNumber = cachedNumber / 100;
                        int secondNumber = cachedNumber / 10 % 10;
                        int thirdNumber = cachedNumber % 10;
                        int fourthNumber = firstNumber + secondNumber + thirdNumber;

                        Console.WriteLine(fourthNumber);
                        CalculateDigits();
                    }
                    break;
                case 4:
                    if (cachedNumberStringLength >= 4)
                    {
                        CalculateDigits();
                    }
                    break;
                default:
                    CalculateDigits();
                    break;
            }
        }

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            CalculateDigits();
        }

    }
    
}