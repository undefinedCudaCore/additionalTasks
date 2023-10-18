internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        //Console.WriteLine("Task No. 1");
        //Console.WriteLine();

        //Console.WriteLine("Enter first number:");
        //var getA = Console.ReadLine();

        //Console.WriteLine("Enter second number:");
        //var getB = Console.ReadLine();

        //if (getA == getB)
        //{
        //    Console.WriteLine($"First number {getA} equals to second number {getB}.");
        //} else
        //{
        //    Console.WriteLine($"The first and second numbers do not equal each other.");
        //}

        //Console.WriteLine("Task No. 2");
        //Console.WriteLine();

        //Console.WriteLine("Enter number:");
        //var getNumberThree = Console.ReadLine();

        //int getNumberThreeOne = Convert.ToInt32(getNumberThree) / 1000;
        //Console.WriteLine(getNumberThreeOne);

        //if ((getNumberThreeOne % 2) == 0)
        //{
        //    Console.WriteLine($"The digit {getNumberThreeOne} of the number {getNumberThree} is even.");
        //}
        //else
        //{
        //    Console.WriteLine($"The digit {getNumberThreeOne} of the number {getNumberThree} is odd.");
        //}
        Console.WriteLine("Task No. 3");
        Console.WriteLine();

        Console.WriteLine("Enter two-digit number:");
        string getNumberFour = Console.ReadLine();

        int getNumberFourOne = Convert.ToInt32(getNumberFour) / 10;
        int getNumberFourTwo = Convert.ToInt32(getNumberFour) % 10;
        int sumOne = getNumberFourOne + getNumberFourTwo;

        if ((sumOne % 2) == 0)
        {
            Console.WriteLine("The sum of the digits of this number is divisible without a remainder.");
        }
        else
        {
            Console.WriteLine("The sum of the digits of this number is divisible with a remainder.");

        }

    }
}