// Реализуйте класс ServerPut. Обязательными методами считаются методы
// Middleware, Controller, Service, Repository. Цепочка взаимодействия между методами
// следующая:
// Controller -> (Middleware) -> Service -> Repository, где:
// Middleware – метод валидатор
// Controller – метод, принимающий данные. Принимает данные клиента
// Service – метод проверки на то что с Repository вернулось значение
// Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с
// этим массивом осуществляется только в Repository. Массив находится в
// приложении
// Задание:
// на вход подается параметры id, name, age
// Необходимо найти Id клиента в массиве БД. Если совпадение есть, произвести
// обновление значений для соответствующих ключей.
// Если совпадения по Id нет – ошибка. Добавить проверки 

using NewCalculator;

namespace Server3;

public class ServerPut
{
    private int NextIdUser = 1;
    private User[] User;

    public ServerPut()
    {
        User = new User[4];
        User[0] = new User() { Id = NextIdUser++, Name = "Yesenia", Age = 22 };
        User[1] = new User() { Id = NextIdUser++, Name = "Hanna", Age = 22 };
        User[2] = new User() { Id = NextIdUser++, Name = "Stanislau", Age = 25 };
        User[3] = new User() { Id = NextIdUser++, Name = "German", Age = 18 };
    }

    public bool Middleware(int id, string name, int age)
    {
        return (age > 0 && age < 120 && !string.IsNullOrEmpty(name));
    }

    public User[] Controller(int id, string name, int age)
    {
        if (Middleware(id, name, age) == true) return Service(id, name, age);
        else
        {
            System.Console.WriteLine("Eror");
            return null;
        }
    }
    public User[] Service(int id, string name, int age)
    {
        User[] user = Repository(id, name, age);
        if (user == null)
        {
            System.Console.WriteLine("Mistake"); ;
        }
        return user;

    }
    public User[] Repository(int id, string name, int age)
    {

        for (int i = 0; i < User.Length; i++)
        {
            if (User[i].Id == id)
            {
                User[i].Name = name;
                User[i].Age = age;
            }
        }
        return User;
    }
}


