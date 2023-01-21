// Реализуйте класс Singer, который будет наследовать от класса Worker. Класс
// +Worker состоит из: свойства Name, свойства Surname, метода GetFullName(), с
// +помощью которого можно вывести одновременно имя и фамилию; 

namespace WorkerWork;

public class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public Worker(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }
    public void GetFullName()
    {
        System.Console.WriteLine($"{Name}{Surname}");
    }
}