using AppTransaction.ShareModels;
using AppTransaction.Servise;

namespace AppTransaction.Core;

public class ApplicationTransaction
{
    


    public void SignIn()
    {
        Account authorization = new Account();
        if (authorization.Login(out User? user))
        {
            WorkflowTransaction workflowTransactions = new WorkflowTransaction();
            workflowTransactions.Show(user);
        }
    }
}