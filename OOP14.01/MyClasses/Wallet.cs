namespace MyClasses;

public abstract class Wallet : IPayment
{
    public decimal Money { get; protected set; }
    public readonly WalletTypes Type;
    public Wallet(WalletTypes type, decimal money = 0)
    {
        Money = money;
        Type = type;
    }
    public void PushMoney(decimal money)
    {
        Money += money;
        System.Console.WriteLine($"You put on Wallet {Money}");
    }

    public abstract bool TryGetMoney(decimal sum);

    public override string ToString()
    {
        return $"{Money}";
    }
}