// 1
//+++ Создайте класс Phone, который содержит поля 
//+++Number, Model и Weight.
// +++Создайте три экземпляра этого класса.
// Выведите на консоль значения их полей.
// +++Добавить в класс Phone методы: ReceiveCall, 
//имеет один параметр – имя звонящего. Выводит на консоль 
//сообщение “Звонит {name}”. Метод GetNumber – возвращает 
//номер телефона. Вызвать эти методы для каждого из 
//объектов.
// ++Добавить конструктор в класс Phone, который принимает 
//на вход три параметра для инициализации полей класса -
// Number, Model и Weight.
// +++Добавить конструктор, который принимает на вход два 
//параметра для инициализации полей класса - - Number, 
//Model.
// +++Добавить конструктор без параметров.
// ++Вызвать из конструктора с тремя параметрами конструктор 
//с двумя.
// ++Добавьте перегруженный метод ReceiveCall, который 
//принимает два параметра - имя звонящего и номер телефона
// звонящего. Вызвать этот метод.
// Создать метод SendMessage с аргументами переменной длины.
// Данный метод принимает на вход номера телефонов, которым
// будет отправлено сообщение. Метод выводит на консоль
// номера этих телефонов.
namespace TaskOOP2.MyClasses;
public class Phone
{
    private string Number = "+375-XX-YYY-YY-YY";
    private string Model = "Phone";
    private string Weight = "Empty";

    public Phone(string number, string model, string weight) : this(number, model)
    {
        Weight = weight;
    }
    public Phone()
    {

    }
    public Phone(string number, string model)
    {
        Number = number;
        Model = model;
    }

    public void ReceiveCall(string name)
    {
        System.Console.WriteLine($"Call {name}");
    }
    public void ReceiveCall(string name, string number)
    {
        System.Console.WriteLine($"Call {name} number {number}");
    }
    public static void SendMessage(string message, params string[] numbers)
    {
        foreach (string item in numbers)
        {
            System.Console.WriteLine(string.Format("Phone: {0} message:{1}", item, message));
        }
    }
    public string GetNumber()
    {
        return Number;
    }

    // Создать метод SendMessage с аргументами переменной длины.
    // Данный метод принимает на вход номера телефонов, которым
    // будет отправлено сообщение. Метод выводит на консоль
    // номера этих телефонов.


    public override string ToString()
    {
        return string.Join(",", Number, Model, Weight);
    }
}