using Customers;

namespace ProgramCustomer;



internal class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Vadim","EGE");
        customer.CustomerName = "Sergey";
        customer.CustomerSurname = "RGdf";
        customer.CallCustomer();
    }
}

// using System;

// namespace ConsoleApplication1
// {
//     interface IUserInfo
//     {
//         string Name
//         {
//             get;
//             set;
//         }
//     }

//     class UI : IUserInfo
//     {
//         string myName;

//         public string Name
//         {
//             set
//             {
//                 myName = value;
//             }

//             get
//             {
//                 return myName;
//             }
//         }
//     }

//     class Program
//     {
//         static void Main()
//         {
//             UI user1 = new UI();
//             user1.Name = "Alexandr";

//             Console.ReadLine();
//         }
//     }
// }