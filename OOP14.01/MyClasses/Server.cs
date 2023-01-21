//2. continue 
// +Реализовать класс, который наследуются от абстрактного класса. Назовём этот
// +класс Server. 
//Сервер принимает в конструкторе все свойства объявленные в
// абстрактном классе: user_id, name, surname, pwd. Также сервер содержит
// функцию getUser являющуюся геттером. Ваша задача при вызове функции класса
// сервер получить данные переданые в конструкторе

namespace Users;

public class Server : User
{
    public Server(int user_id, string surname, string pwd) : base(user_id, surname, pwd)
    {
        
    }

    public string GetUser()
    {
        return $"{User_id} {Surname} {Pwd}";
    }
}

