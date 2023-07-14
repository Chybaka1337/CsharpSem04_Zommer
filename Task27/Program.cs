namespace Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfDigits(1234));
        }

        static int SumOfDigits(int number)
        {
            int result = 0;
            while(number != 0) 
            {
                result += number % 10;
                number /= 10;
            }
            return result;
        }
    }
}