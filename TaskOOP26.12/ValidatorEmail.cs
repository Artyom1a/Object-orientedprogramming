// Реализуйте класс ValidatorEmail. Класс содержит 1 метод 
//валидации, называемый
// Middleware, в котором происходит проверка на почту. 
//Вывести true, если провека
// успешна

using NewCalculator;

namespace NewCalculator;

public class ValidatorEmail
{
    public bool Middleware(string email)
    {
        bool result = false;
        if (email.Contains("@mail.ru") && email[email.Length - 1] != '.')
        {
            result = true;
        }
        return result;
    }
    public bool Middleware1(string email)
    {
        string[] mail = email.Split('@');
        return mail.Length == 2 && mail[1].Split('.').Length == 2 ;
    }
}
