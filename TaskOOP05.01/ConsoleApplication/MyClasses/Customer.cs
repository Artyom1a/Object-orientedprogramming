//+Затем напишите класс Customer
// +(Клиент), который является подклассом класса Person. Класс Customer должен
// иметь атрибут данных для номера клиента и атрибут булевых данных,
// указывающий, хочет ли клиент быть в списке рассылки или нет.
// Продемонстрируйте экземпляр класса Custorner в простой программе.

using PersonWork;
namespace CustomerWork;

public class Customer : Person
{
    public bool Ras;
    public Customer(string tel, bool ras)
    {
        Tel = tel;
        Ras = ras;
    }
    public void Print()
    {
        if (Ras = false)
        {
            System.Console.WriteLine($"{Tel}, {Ras}-no message");
        }
        System.Console.WriteLine($"{Tel}, {Ras}-message");
    }
}