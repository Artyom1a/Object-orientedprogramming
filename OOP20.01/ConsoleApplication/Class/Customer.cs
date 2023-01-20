// task7ofincapsulation 
//Класс Покупатель: Фамилия, Имя, Отчество, Адрес, Номер кредитной карточки,
// Номер банковского счета; Конструктор; Методы: установка значений атрибутов,
// получение значений атрибутов, вывод информации. Создать массив объектов
// данного класса. Вывести список покупателей в алфавитном порядке и список
// покупателей, у которых номер кредитной карточки находится в заданном
// диапазоне

namespace Customers
{
    public class Customer : ICustomers
    {
        public string CustomerName;
        public string CustomerSurname;
        string ICustomers.Name
        {
            set
            {
                CustomerName = value;
            }
            get
            {
                return CustomerName;
            }
        }
        string ICustomers.Surname
        {
            set
            {
                CustomerSurname = value;
            }
            get
            {
                return CustomerSurname;
            }
        }

        public Customer(string customerName, string customerSurname)
        {
            CustomerName = customerName;
            CustomerSurname = customerSurname;
        }

        public void CallCustomer()
        {
            System.Console.WriteLine($"{CustomerName} {CustomerSurname}");
        }
    }

}




