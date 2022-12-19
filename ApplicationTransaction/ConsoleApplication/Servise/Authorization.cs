using AppTransaction.ShareModels;

namespace AppTransaction.Servise;

public class Authorization
{
    public bool Login(User[] users, out User? user)
    {
        System.Console.Write("Enter Email ");
        string? email = Console.ReadLine();
        System.Console.Write("Enter pass ");
        string? pass = Console.ReadLine();
        user = Search(users, email, pass);
        return user != null;
    }

    private User? Search(User[] users, string? email, string? pass)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
        {
            System.Console.WriteLine("error input");
            return null;
        }
        foreach (User user in users)
        {
            if (user.Email == email && user.Password == pass)
            {
                System.Console.WriteLine("Succesfull login");
                return user;
            }
        }
        System.Console.WriteLine("error input");
        return null;


    }
}