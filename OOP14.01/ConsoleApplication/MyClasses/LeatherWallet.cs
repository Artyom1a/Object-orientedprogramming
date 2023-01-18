namespace MyClasses;

public class LeatherWallet : Wallet
{
    public LeatherWallet(decimal money) : base(WalletTypes.Leather, money)
    {

    }
    public override bool TryGetMoney(decimal sum)
    {
        if (Money >= sum)
        {
            Money -= sum;
            System.Console.WriteLine($"You pay of Wallet {sum} of leatherwallet");
            return true;
        }
        return false;
    }
}