namespace Customers
{

    public interface ICustomers
    {
        public string Name
        {
            get;
            set;
        }
        string Surname
        {
            get;
            set;
        }
        const string text = "Hello";

        void CallCustomer();
    }

}