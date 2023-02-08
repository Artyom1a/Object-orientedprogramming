using TaskExtencions.Enums;

namespace TaskExtencions.Extencions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string text = "ewfewv324gervbw92";
            //int result = text.ToInt(); 
            //Console.WriteLine(result);

            //object test = null;
            //Console.WriteLine(test.TryToConvert<int>(out int result));
            //Console.WriteLine(result);

            Console.WriteLine(((FileTypes)3).FileTypeMessage());

        }
    }
}