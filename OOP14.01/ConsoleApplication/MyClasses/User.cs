// 2. +Реализовать абстрактный класс User. Класс содержит в себе следующие поля:
// +user_id, name, surname, pwd/
// Реализовать класс, который наследуются от абстрактного класса. Назовём этот
// класс Server. Сервер принимает в конструкторе все свойства объявленные в
// абстрактном классе: user_id, name, surname, pwd. Также сервер содержит
// функцию getUser являющуюся геттером. Ваша задача при вызове функции класса
// сервер получить данные переданые в конструкторе

namespace Users;

public abstract class User
{
    public int User_id;
    public string Surname;
    public string Pwd;

    public User(int user_id, string surname, string pwd)
    {
        User_id=user_id;
        Surname= surname;
        Pwd = pwd;
    }
}