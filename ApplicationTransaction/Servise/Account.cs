using AppTransaction.ShareModels;

namespace AppTransaction.Servise;

public class Account
{
    private int NextIdUser = 1;
    private User[] Users;
    public Account()
    {
        Users = new User[20];
        Users[0] = new User(NextIdUser++, "test1", "s2345678", "Liubasokolovskay@gmail.com");
        Users[1] = new User(NextIdUser++, "test2", "ergrbrce", "afb@gmail.com");
        Users[2] = new User(NextIdUser++, "test3", "ergrbrcf", "gfns@gmail.com");
        Users[3] = new User(NextIdUser++, "test4", "ergrbrcr", "mren@gmail.com");

    }
    public bool Login(out User? user)
    {
        System.Console.Write("Enter Email ");
        string? email = Console.ReadLine();
        System.Console.Write("Enter pass ");
        string? pass = Console.ReadLine();
        user = Search(email, pass);
        return user != null;
    }

    private User? Search(string? email, string? pass)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
        {
            System.Console.WriteLine("error input");
            return null;
        }
        foreach (User user in Users)
        {
            if (user == null)
            {
                continue;
            }
            // if (user?.Email == email && user?.Password == pass)
            if (user.Email == email && user.Password == pass)
            {
                System.Console.WriteLine("Succesfull login");
                return user;
            }
        }
        System.Console.WriteLine("error input");
        return null;
    }
    public bool Registr(out User? user)
    {
        System.Console.Write("Enter Email ");
        string? email = Console.ReadLine();
        System.Console.Write("Enter pass ");
        string? pass = Console.ReadLine();
        System.Console.Write("Enter Name ");
        string? name = Console.ReadLine();
        user = SearchSimple(email, pass, name);
        if (user != null)
        {
            Users[user.ID-1]= user;
        }
        return user != null;
    }
    private User? SearchSimple(string? email, string? pass, string? name)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))//name
        {
            System.Console.WriteLine("error input");
            return null;
        }
        for (int i = 0; i < Users.Length; i++)
        {
            if (Users[i].Email == email)//isnull
            {
                System.Console.WriteLine("This email not available");
                return null;
            }
        }
        return new User(NextIdUser++, name, pass, email);

    }
}