internal class Program
{
    static void CalculateN() 
    {
        Console.WriteLine("Enter number:");

        string cachedNumberString2 = Console.ReadLine();

        int cachedNumberStringLength2 = cachedNumberString2.Length;

        int cachedNumber2 = Convert.ToInt32(cachedNumberString2);

        if (cachedNumberStringLength2 == 3)
        {
            int firstNumber = cachedNumber2 / 100;
            int secondNumber = cachedNumber2 / 10 % 10;
            int thirdNumber = cachedNumber2 % 10;
            string fourthString = secondNumber.ToString() + firstNumber.ToString() + thirdNumber.ToString();
            Console.WriteLine(fourthString);
            CalculateN();
        }
    }
    static void Main(string[] args)
    {
        CalculateN();
    }
}