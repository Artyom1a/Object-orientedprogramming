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
// на вход подается параметры id
// Необходимо осуществить удаление по Id клиента в массиве БД. 
// Если совпадения по Id нет – ошибка. Добавить проверки 

using NewCalculator;

namespace Server4;

public class ServerDelete
{
    private User[] User;

    public ServerDelete()
    {
        User = new User[4];
        User[0] = new User() { Id = 1, Name = "Yesenia", Age = 22 };
        User[1] = new User() { Id = 2, Name = "Hanna", Age = 22 };
        User[2] = new User() { Id = 3, Name = "Stanislau", Age = 25 };
        User[3] = new User() { Id = 4, Name = "German", Age = 18 };
    }

    public bool Middleware(int id)
    {
        return (id > 0);
    }

    public User[] Controller(int id)
    {
        if (Middleware(id) == true) return Service(id);
        else
        {
            System.Console.WriteLine("Eror");
            return null;
        }
    }
    public User[] Service(int id)
    {
        User[] user = Repository(id);
        if (user == null)
        {
            System.Console.WriteLine("Mistake"); ;
        }
        return user;

    }
    public User[] Repository(int id)
    {

        for (int i = 0; i < User.Length; i++)
        {
            if (User[i].Id == id)
            {

                User[i] = null;
                return User;
            }

            //как вернуть ошибку только в одном случае а не во всех простым способом
        }
        System.Console.WriteLine("Error");
        return User;
    }
}


