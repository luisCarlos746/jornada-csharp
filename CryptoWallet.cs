using System;
using System.Collections.Generic;

namespace CryptoWallet;

internal class Program
{
    static void Main(string[] args)
    {
        int opcao;

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Clear();
        Console.WriteLine("----CryptoWallet Console----");
        Console.WriteLine("Welcome to the CryptoWallet Console Application!");
        Console.WriteLine("Press enter to start ...");
        Console.ReadKey();
        Console.WriteLine("Choose an option:");

        double saldosEuros = 1000.0;
        Dictionary<string, double> myWallet = new Dictionary<string, double>()
        {
            {"BTC", 0.0 },
            {"ETH", 0.0}
        };
        Dictionary<string, double> coinsPrices = new Dictionary<string, double>()
        {
            {"BTC", 50000.0 },
            {"ETH", 3000.0}
        };
        do
        {
            ShowMenu();
            opcao = int.Parse(Console.ReadLine()!);
            if (opcao == 1)
            {
                Console.WriteLine("\n---- Your Wallet ----");
                Console.WriteLine($"Cash: {saldosEuros:F2}");
                Console.WriteLine($"Bitcoin (BTC): {myWallet["BTC"]:F6}");
                Console.WriteLine($"Ethereum (ETH): {myWallet["ETH"]:F4}");
                Console.WriteLine("----------------------");
            }
            else if (opcao == 2)
            {
                Console.Clear();
                Console.WriteLine("\n---- Buy Cryptocurrency ----");
                Console.WriteLine("\n Which cryptocurrency do you want to buy? (BTC/ETH)");
                string coin = Console.ReadLine()!.ToUpper();
                if (!coinsPrices.ContainsKey(coin))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid cryptocurrency");
                    continue;
                }
                Console.Clear();
                Console.WriteLine("How many Euros (€) do you want to spend?");
                double amount = double.Parse(Console.ReadLine()!);
                if (amount > saldosEuros)
                {
                    Console.Clear();
                    Console.WriteLine("Insufficient funds");
                }
                else
                {
                    Console.Clear();
                    double price = coinsPrices[coin];
                    double quantity = amount / price;
                    myWallet[coin] += quantity;
                    saldosEuros -= amount;
                    Console.WriteLine($"You bought {quantity:F6} {coin} for {amount:F2}€");
                }
            }
            else if (opcao == 3)
            {
                Console.Clear();
                Console.WriteLine("\n---- Sell Cryptocurrency ----");
                Console.WriteLine("\n Which cryptocurrency do you want to sell? (BTC/ETH)");
                string coin = Console.ReadLine()!.ToUpper();
                if (!coinsPrices.ContainsKey(coin))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid cryptocurrency");
                    continue;
                }
                Console.Clear();
                Console.WriteLine("Units available: " + myWallet[coin] + " " + coin);
                Console.WriteLine("How many units do you want to sell?");
                double quantity = double.Parse(Console.ReadLine()!);
                if (quantity > myWallet[coin])
                {
                    Console.Clear();
                    Console.WriteLine("Insufficient funds");
                }
                else
                {
                    Console.Clear();
                    double price = coinsPrices[coin];
                    double amount = quantity * price;
                    myWallet[coin] -= quantity;
                    saldosEuros += amount;
                    Console.WriteLine($"You sold {quantity:F6} {coin} for {amount:F2}€");
                }
            }
            else if (opcao == 4)
            {
                Console.Clear();
                Console.WriteLine("Exiting the application...");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid option. Please try again.");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

        } while (opcao != 4);
    }

    static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("1. View Wallet");
        Console.WriteLine("2. Buy Cryptocurrency");
        Console.WriteLine("3. Sell Cryptocurrency");
        Console.WriteLine("4. Exit");
    }
}
