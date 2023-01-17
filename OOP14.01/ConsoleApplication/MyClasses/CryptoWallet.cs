namespace MyClasses;

public class CryptoWallet : Wallet
{
    public CryptoWallet(decimal money) : base(WalletTypes.Crypto, money)
    {

    }

    public override bool TryGetMoney(decimal sum)
    {
        if (Money >= sum)
        {
            Money -= sum;
            System.Console.WriteLine($"You pay of Wallet {sum} of cryptowallet");
            return true;
        }
        return false;
    }

}