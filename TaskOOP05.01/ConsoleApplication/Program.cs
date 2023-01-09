
using MyClasses.Cars;
using MyClasses.Transport;
using ProductionWorkerWork;
using EmployeeWork;
using ShiftSupervisorWork;
using CustomerWork;
using SingerWork;
using CircleWork;

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

            //-----------------------
            // Employee employee = new Employee();
            // ProductionWorker productionWorker = new ProductionWorker();
            // System.Console.WriteLine("Vvedity id");
            // int id = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine("Vvedity name");
            // string? name = Console.ReadLine();
            // System.Console.WriteLine("Vvedity idsmen");
            // int idsmen = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine("Vvedity stavkahr");
            // int stavkahr = Convert.ToInt32(Console.ReadLine());
            // productionWorker.Giveinarray(id, name, idsmen, stavkahr);
            // productionWorker.Vyvod();
            ShiftSupervisor shiftsupervisor = new ShiftSupervisor("Svetoslav", 1, 120000, 12);
            shiftsupervisor.ItogPremy();
            Customer customer = new Customer("37529333333", false);
            customer.Print();
            Singer singer = new Singer(22, "2000-11-11", "Piano", "Evgen", "Drozd");
            singer.GetMoreInfo();
            Circle circle = new Circle("Raschet",0,0,3);
            circle.Area();

        }
    }
}
