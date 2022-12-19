using AppTransaction.ShareModels;
using AppTransaction.Servise;

namespace AppTransaction.Core;

public class ApplicationTransaction
{
    private User[] Users;

    public ApplicationTransaction()
    {
        Users = new User[4] {
            new User(1234, "test1", "s2345678", "Liubasokolovskay@gmail.com"),
            new User(5345, "test2", "ergrbrce", "afb@gmail.com"),
            new User(1235, "test3", "ergrbrcf", "gfns@gmail.com"),
            new User(1245, "test4", "ergrbrcr", "mren@gmail.com"),
        };
    }
    public void SignIn()
    {
        Authorization authorization = new Authorization();
        if (authorization.Login(Users, out User? user))
        {
            WorkflowTransaction workflowTransactions = new WorkflowTransaction();
            workflowTransactions.Show(user);
        }
    }
}