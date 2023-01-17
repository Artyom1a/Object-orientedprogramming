//1. continue
//// Ваша задача написать функционал для всех трёх методов.
// ++Где, основная задача первого метода проверить является ли входное значение
// принимаемые в параметры функции числом.
// ++Основная задача второго метода проверить является ли входная строка почтой:
// то есть содержит ли знак «@» а также оканчивается ли на .by, .com
// ++Говоря о последнем методе то он принимает две строки: пароль и
// подтверждения пароля. Необходимо проверить совпадают ли данный пароли.
// ++Результат каждой из функций должен возвращать true или false в зависимости от
// условий

namespace Validations;

public class Data : Validation
{
    public override bool IsValidId(string id)
    {
        if (Int32.TryParse(id, out int chislo))
        {
            return true;
        }
        return false;
    }
    public override bool IsValidEmail(string email)
    {
        if (email.Split("@").Length == 2 && (email.EndsWith(".by") || email.EndsWith(".com")))
        {
            return true;
        }
        return false;
    }
    public override bool IsValidPwd(string pass1, string pass2)
    {
        if (pass1.Equals(pass2))
        {
            return true;
        }
        return false;
    }
}