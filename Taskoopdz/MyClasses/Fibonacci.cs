namespace consoleapplication.MyClasses
{
    public class Fibonacci
    {
        string surname;
        public Fibonacci()
        {
            System.Console.WriteLine("Class Fibonacci");
        }
        public static string ResultFibonacci(int x, int y)
        {
            System.Console.WriteLine("Write last index element in the roud Fibonacci");
            int indexmassivend = Convert.ToInt32(Console.ReadLine());
            string Fib = "";

            int element0 = x;
            int element1 = y;
            int[] array = new int[indexmassivend];
            for (int i = 2; i < array.Length; i++)
            {
                array[i - 2] = x;
                array[i - 1] = y;
                array[i] = x + y;
                x = y;
                y = array[i];
            }
            Fib = string.Join(',', array);
            return Fib;
        }
    }
}


