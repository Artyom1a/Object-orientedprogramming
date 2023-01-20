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
        public string Name;
        public string Surname;

        public Customer(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }


        public void CallCustomer()
        {
            System.Console.WriteLine($"{Name} {Surname}");
        }
    }

}


