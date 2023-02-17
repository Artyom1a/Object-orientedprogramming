using ConsoleApp1;

//--------------------------------------------

//Напишите программу, в которой с помощью делегатов и анонимных методов (лямбдавыражений) создается экземпляр делегата, 
//    который вызывается без аргументов, а
//результатом возвращает текстовое значение с названием дня недели ("Понедельник",
//"Вторник" и так до "Воскресенья"). При каждом новом вызове экземпляра результатом
//возвращается название следующего дня недели. После "Воскресенья" результатом
//возвращается "Понедельник" и так далее

internal class Program
{
    public delegate string AWeek();
    public delegate double DelTask2(double x);
    static void Main(string[] args)
    {
        int kolvyzov = 0;
        AWeek week = delegate ()
        {
            string[] Weeks = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            return Weeks[kolvyzov % 7];
        };

        for (int i = 1; i < 50; i++)
        {
            Console.WriteLine($"{week()}");
            kolvyzov = i;

        }
        //------------------------------------

        //        Напишите программу, содержащую статический метод с тремя действительными(тип
        //double) аргументами.Результатом статического метода является ссылка на метод,
        //вычисляющий квадратичный трехчлен с коэффициентами, определяемыми аргументами
        //статического метода. Другими словами, если статический метод вызывается с числовыми
        //аргументами a, b и с, то результатом является ссылка на метод, который для аргумента x
        //типа double результатом вычисляет значение выражения a*x * x + b * x + c.



        Console.WriteLine("_____________________TASK2_______________________");
        double x = 2;
        Console.WriteLine(Test()(x));



        Console.WriteLine("_____________________TASK4_______________________");
        StockExchangeMonitor stockExchangeMonitor = new StockExchangeMonitor();
        stockExchangeMonitor.PriceChangeHandler = ShowPrice;
        stockExchangeMonitor.Start();


    }
    public static DelTask2 Test(double a = 1, double b = 2, double c = 3)
    {
        return x => a * x * x + b * x + c;
    }

    public static void ShowPrice(int price)
    {
        Console.WriteLine(price);
    }

}






