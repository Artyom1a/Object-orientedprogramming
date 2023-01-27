namespace Excepts
{
    internal class Except
    {

        public int X;
        public int Y;

        public Except(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Raschet()
        {
            string? z = Console.ReadLine();
            if (z.Length < 6)
            {
                throw new Exception("vedy dlinye");
            }
            try
            {
                return X / Y;
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine($"Mistake---{0}");
            }
            finally
            {
                System.Console.WriteLine(X * Y);
            }
            return X;
        }

    }

}