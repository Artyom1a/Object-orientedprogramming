using AppTransaction.ShareModels;

namespace AppTransaction.Servise;

public class WorkflowTransaction
{
    private Transaction[] Transactions;
    public WorkflowTransaction()
    {
        Transactions = new Transaction[2]
        {
        new Transaction(1, 23, "Pokupka svetilnika", 100, DateTime.Now.AddDays(-1)),
        new Transaction(2, 5345, "Pokupka divan", 600, DateTime.Now.AddDays(-1)),
        };
    }

    public void Show(User user)
    {
        bool check = true;
        for (int i = 0; i < Transactions.Length; i++)
        {
            if (Transactions[i].UserId == user.ID)
            {
                check = false;
                System.Console.WriteLine(Transactions[i]);
            }

        }
        if (check)
        {
            System.Console.WriteLine("No information");
        }

    }
}

