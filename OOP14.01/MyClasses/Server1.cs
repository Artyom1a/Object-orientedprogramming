namespace Dbss;

public class Server1 : Db
{

    public Server1()
    {
        Dbs = new UserDB[2]
        {
        new UserDB("Sveta", "SVT", "drgv@mIL.RU", "123414"),
        new UserDB("RTG", "RKB", "4gb@maiL.RU", "re4214"),
        };
    }

    public void Show()
    {

        for (int i = 0; i < Dbs.Length; i++)
        {

            System.Console.WriteLine($"{Dbs[i].Name}, {Dbs[i].Surname}, {Dbs[i].Email}, {Dbs[i].Pwd}");

        }

    }

    public UserDB[] CreateUser(string name, string surname, string email, string pwd)
    {
        UserDB[] Dbsnew = new UserDB[Dbs.Length + 1];
        Array.Copy(Dbs, Dbsnew, Dbs.Length);
        Dbsnew[Dbs.Length] = new UserDB(name, surname, email, pwd);
        Dbs = Dbsnew;
        System.Console.WriteLine($"Name:{Dbs[Dbs.Length - 1].Name},Surname:\"{Dbs[Dbs.Length - 1].Surname}\",Email: {Dbs[Dbs.Length - 1].Email},Pwd: {Dbs[Dbs.Length - 1].Pwd} ");
        return Dbs;
    }



}