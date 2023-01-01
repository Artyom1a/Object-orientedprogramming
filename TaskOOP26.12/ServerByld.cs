// 4. +Реализуйте класс ServerById. Обязательными методами считаются 
// методы
// +Middleware, Controller, Service, Repository. Цепочка взаимодействия 
// +между
//+ методами следующая:
// +Controller -> (Middleware) -> Service -> Repository, 
// где: Middleware – метод валидатор
// +Controller – метод, принимающий данные. Принимает данные клиента
// +Service – метод проверки на то что с Repository вернулось значение
// +Repository – метод, симулирующая БД. Хранит массив данных. 
// Взаимодействие с этим массивом осуществляется только в Repository. 
// +Массив находится в приложении
// Задание: на вход подается параметр id
// Необходимо вывести в консоль найденный элемент массива по id если 
// таковой имеется. В противном случае бросить исключение. Добавить 
// проверки 

using NewCalculator;
namespace Server1;

public class ServerByld
{
    public User[] User;

    public ServerByld()
    {
        User = new User[4];
        User[0] = new User() { Id = 1, Name = "Yesenia", Age = 22 };
        User[1] = new User() { Id = 2, Name = "Hanna", Age = 22 };
        User[2] = new User() { Id = 3, Name = "Stanislau", Age = 25 };
        User[3] = new User() { Id = 4, Name = "German", Age = 18 };
    }

    public bool Middleware(int x)
    {
        return x > 0;
    }
    public User[] Controller(int x)
    {
        if (Middleware(x)) return Service(x);
        else
        {
            System.Console.WriteLine("Mistake");
            return null;
        }
    }

    private User[] Service(int x)
    {
        User[] user = Repository(x);
        if (user == null)
        {
            System.Console.WriteLine("Mistake");
        }
        return user;
    }

    private User[] Repository(int x)
    {
        for (int i = 0; i < User.Length; i++)
        {
            if (User[i].Id == x)
            {
                System.Console.WriteLine(string.Join(',', User[i]));
                return User;
            }
        }
        return null;
    }
}