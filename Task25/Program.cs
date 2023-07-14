namespace Task25
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.Write("enter a base = ");
            int.TryParse(Console.ReadLine(), out int x);
            Console.Write("enter a exponent = ");
            uint.TryParse(Console.ReadLine(), out uint exponent);
            Console.WriteLine(Pow(x, exponent));
        }

        static int Pow(int x, uint exponent)
        {
            int result = 1;
            for(int i = 0; i < exponent; i++)
            {
                result *= x;
            }
            return result;
        }
    }
}