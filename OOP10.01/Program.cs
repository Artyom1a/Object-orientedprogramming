
using MyClasses.Cars;
using MyClasses.Transport;
using Times;
using PaymentSystems;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Transport transport = new Transport(20, "car");

            // transport.Moving();
            // // transport.Stopping();
            // Car bugatti = new Car("vasy", 22);
            // System.Console.WriteLine(bugatti.ToString());

            // // bugatti.Drift();
            // Transport lambo = new Car("artem", 22);

            // Transport[] array = new Transport[3] { transport, bugatti, lambo };
            // foreach (Transport item in array)
            // {
            //     System.Console.WriteLine(item.ToString());
            //     if(item is Car car)
            //     {
            //         System.Console.WriteLine("This is car");
            //         car.Drift();
            //     }
            //     if(item is Transport)
            //     {
            //        // System.Console.WriteLine("This is Sparta");
            //     }
            //     item.Stopping();
            //     item.Moving();
            // }
            // System.Console.WriteLine("Transport class");
            // Transport transport = new Transport();
            // System.Console.WriteLine(transport.Name);
            // transport.Moving();
            // System.Console.WriteLine("Car class");
            // Car car = new Car();
            // System.Console.WriteLine(car.Name);
            // car.Moving();
            // System.Console.WriteLine("Transport-car class");
            // Transport transportCar = new Car();
            // System.Console.WriteLine(transportCar.Name);
            // transportCar.Moving();

            // Time time = new Time(13,39,46);
            // System.Console.WriteLine(time.TimeNow());
            // time.TimeCorrectHour(18);
            // System.Console.WriteLine(time.TimeNow());

            PaymentTerminal terminal = new PaymentTerminal("terminal");
            Visa dima = new Visa("001", 1);
            terminal.SetMoneyByPaymentSystem(10, dima);
            dima.SetMoney(100);
            terminal.SetMoneyByPaymentSystem(10, dima);
            Console.WriteLine(dima);
            Console.WriteLine();
            Console.WriteLine(dima.GetHistory());
            Console.WriteLine();
            Console.WriteLine(terminal);
            Console.WriteLine();
            UnionPay artem = new UnionPay("002", 1);
            artem.SetMoney(15000);
            terminal.SetMoneyByPaymentSystem(15000, artem);
            terminal.SetMoneyByPaymentSystem(10000, artem);
            Console.WriteLine(artem);
            Console.WriteLine();
            Console.WriteLine(artem.GetHistory());
            Console.WriteLine();
            Console.WriteLine(terminal);
        }
    }
}
