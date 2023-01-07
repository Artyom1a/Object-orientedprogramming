// // // +Реализуйте класс ServerPost. Обязательными методами считаются методы
// // // Middleware, Controller, Service, Repository. Цепочка взаимодействия между методами
// // // следующая:
// // // Controller -> (Middleware) -> Service -> Repository, где:
// // // +Middleware – метод валидатор
// // // +Controller – метод, принимающий данные. Принимает данные клиента
// // // +Service – метод проверки на то что с Repository вернулось значение
// // // Repository – метод, симулирующая БД. Хранит массив данных. Взаимодействие с
// // // этим массивом осуществляется только в Repository. Массив находится в
// // // приложении
// // // Задание:
// // // +на вход подается параметры name, age
// // // Необходимо добавить в массив БД объект только в том случае, если нет совпадений
// // // по name. Если совпадения нет, то в объект клиента добавить ключ Id с последним
// // // возможным уникальным Id БД, таким образом, чтобы в БД был запушен объект вида
// // // {“Id": 6, Name : "Test", Age : 1}
// // // Если совпадение есть – ошибка. Добавить проверки

using NewCalculator;

namespace Server2;

public class ServerPost
{
    private int NextIdUser = 1;
    private User[] User;

    public ServerPost()
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
            if (User[i].Name != name)
            {
                id = NextIdUser++;
                name = "Test";
                age = 1;

            }
            else if (User[i].Name == name)
            {
                System.Console.WriteLine("Misstake");
                return null;
            }
        }
        User[] UserNew = new User[User.Length + 1];
        Array.Copy(User, UserNew, User.Length);
        UserNew[User.Length] = new User() { Id = UserNew.Length, Name = name, Age = age };
        User = UserNew;
        System.Console.WriteLine($"ID:{User[User.Length - 1].Id},Name:\"{User[User.Length - 1].Name}\",Age: {User[User.Length - 1].Age}");

        // User[4] = new User() { Id = id, Name = name, Age = age };
        // Array.Copy(User, User[4], User.Length);
        return User;
    }
}


