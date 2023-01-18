// +1. Реализовать класс Validation который содержит методы IsValidId, IsValidEmail,
// IsValidPwd.
// +Реализовать класс наследник Data который полностью переопределяет все
// методы своего суперкласса.



namespace Validations;

public abstract class Validation
{

public abstract bool IsValidId(string id);
public abstract bool IsValidEmail(string email);
public abstract bool IsValidPwd(string pass1, string pass2);
}