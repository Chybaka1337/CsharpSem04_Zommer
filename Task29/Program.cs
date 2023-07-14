namespace Task29
{
    class Program
    {
        static void Main(string[] args) 
        {
            PrintArray(FillArray());
        }

        static int[] FillArray() 
        {
            int upBound = 1024;
            int[] array = new int[8];
            for(int i = 0; i < array.Length; i++) 
            {
                array[i] = new Random().Next(0, upBound);
            }
            return array;
        }

        static void PrintArray(int[] array) 
        {
            foreach(var element in array) 
            {
                Console.Write(element + "\t");
            }
        }
    }
}