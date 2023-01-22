using System;
using BankSystem.Models;


namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User user1 = new User(1, "test");
            // User user2 = user1;

            // System.Console.WriteLine(user1 == user2);
            // System.Console.WriteLine(user1.Equals(user2));
            List<ExchangeRate> rates = new List<ExchangeRate>();
            Currency currency = new Currency((int)CurrencyCodes.USD, "dollar USA", "$", CurrencyCodes.USD.ToString());
            System.Console.WriteLine(currency);
            // ExchangeRate[] rates = { ex1, ex2 };
            rates.Add(new ExchangeRate((int)CurrencyCodes.BYN, (int)CurrencyCodes.USD, 2.67));
            rates.Add(new ExchangeRate((int)CurrencyCodes.BYN, (int)CurrencyCodes.EUR, 2.83));
            rates.Add(new ExchangeRate((int)CurrencyCodes.BYN, (int)CurrencyCodes.GBP, 2.91));
            rates.Add(new ExchangeRate((int)CurrencyCodes.BYN, (int)CurrencyCodes.PLN, 0.4));
            rates.Add(new ExchangeRate((int)CurrencyCodes.USD, (int)CurrencyCodes.EUR, 0.97));
            rates.Add(new ExchangeRate((int)CurrencyCodes.USD, (int)CurrencyCodes.GBP, 0.9));
            rates.Add(new ExchangeRate((int)CurrencyCodes.USD, (int)CurrencyCodes.PLN, 5));
            System.Console.WriteLine(rates.Count);
            System.Console.WriteLine(rates.FirstOrDefault(rate => rate.CurrencyFrom == (int)CurrencyCodes.PLN && rate.CurrencyTo == (int)CurrencyCodes.USD));

        }
    }
}



