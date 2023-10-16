using System;
using System.Security.Claims;

namespace numberTasks // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void CalculateDigits()
        {
            Console.WriteLine("Enter number:");

            string cachedNumberString = Console.ReadLine();

            int cachedNumberStringLength = cachedNumberString.Length;
            string cachedNumberStringLengthToString = cachedNumberStringLength.ToString();

            int cachedNumber = Convert.ToInt32(cachedNumberString);

            
                if (cachedNumberStringLength == 2)

                    {
                        int firstNumber = cachedNumber / 10;
                        int secondNumber = cachedNumber % 10;
                        int thirdNumber = firstNumber + secondNumber;

                        Console.WriteLine(thirdNumber);
                    }
                else if (cachedNumberStringLength > 2)
                    {
                        int firstNumber = cachedNumber / 100;
                        int secondNumber = cachedNumber / 10 % 10;
                        int thirdNumber = cachedNumber % 10;
                        int fourthNumber = firstNumber + secondNumber + thirdNumber;

                        Console.WriteLine(fourthNumber);
                    }
                else if (cachedNumberStringLength > 3)
                    {
                        CalculateDigits();
                    }
            CalculateDigits();

        }

        static void RepeatCalculateDigits()
        {

        }
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter number:");

            //string cachedNumberString = Console.ReadLine();

            //int cachedNumber = Convert.ToInt32(cachedNumberString);

            //bool test = false;
            //if (test)
            //{

            //}
            //for (int i = 0; i < length; i++)
            //{

            //}
            //if (cachedNumber != 0 || cachedNumber == 2)
            //{
            //    int firstNumber = cachedNumber / 10;
            //    int secondNumber = cachedNumber % 10;
            //    int thirdNumber = firstNumber + secondNumber;

            //    Console.WriteLine(thirdNumber);
            //}
            //else
            //{
            //    CalculateDigits();
            //}


            //Console.ReadKey();
            CalculateDigits();

        }
    }
}