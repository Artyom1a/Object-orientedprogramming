using Customers;

namespace ProgramCustomer;



internal class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer("Svet","egr");
        customer.CallCustomer();
    }
}

