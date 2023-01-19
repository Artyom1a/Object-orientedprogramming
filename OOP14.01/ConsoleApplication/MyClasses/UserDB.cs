namespace Dbss;
public class UserDB
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Pwd { get; set; }

    public UserDB(string name, string surname, string email, string pwd)
    {

        Name = name;
        Surname = surname;
        Email = email;
        Pwd = pwd;
    }

}