
using System;

namespace numberTask03
{
    internal class Program
    {
        static void ReplaceNumberPositions()
        {
            Console.WriteLine("Enter number:");

            string cachedNumberString2 = Console.ReadLine();

            int cachedNumberStringLength2 = cachedNumberString2.Length;

            int cachedNumber2 = Convert.ToInt32(cachedNumberString2);


            if (cachedNumberStringLength2 == 2)
            {
                int firstNumber = cachedNumber2 / 10;
                int secondNumber = cachedNumber2 % 10;
                string thirdString = secondNumber.ToString() + firstNumber.ToString();
                Console.WriteLine(thirdString);
                ReplaceNumberPositions();
            }else if (cachedNumberStringLength2 == 3)
            {
                int firstNumber = cachedNumber2 / 100;
                int secondNumber = cachedNumber2 / 10 % 10;
                int thirdNumber = cachedNumber2 % 10;
                string fourthString = thirdNumber.ToString() + secondNumber.ToString() + firstNumber.ToString();
                Console.WriteLine(fourthString);
                ReplaceNumberPositions();
            }
            else if (cachedNumberStringLength2 == 4)
            {
                int firstNumber = cachedNumber2 / 1000;
                int secondNumber = cachedNumber2 / 10 % 100 /10;
                int thirdNumber = cachedNumber2 % 100 / 10;
                int fourthNumber = cachedNumber2 % 100 %10;
                string sixthString = thirdNumber.ToString() + fourthNumber.ToString() + firstNumber.ToString() + secondNumber.ToString();
                Console.WriteLine(sixthString);
                int seventhNumbet = thirdNumber + fourthNumber + firstNumber + secondNumber;
                Console.WriteLine(seventhNumbet);

                ReplaceNumberPositions();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            ReplaceNumberPositions();

        }
    }
}