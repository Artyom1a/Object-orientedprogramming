// using Validations;
// using Users;
using Cards;
using MyClasses;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data data = new Data();
            // System.Console.WriteLine(data.IsValidEmail("gre@gmail.com"));
            // Server server = new Server(1,"RTY","gwve42");
            // System.Console.WriteLine(server.GetUser());
            Card card = new Card("1");
            // card.TryGetMoney(100);
            // card.PushMoney(100);
            // card.TryGetMoney(100);

            // System.Console.WriteLine((int)WalletTypes.Crypto);
            // System.Console.WriteLine((int)WalletTypes.Leather);
        
            // wallet1.PushMoney(5);

            // Shop shop = new Shop();
            // shop.Pay(wallet1);
            // shop.Pay(card);

            IPayment wallet = new LeatherWallet(10);
            wallet.PushMoney(10);
            


        }
    }
}



