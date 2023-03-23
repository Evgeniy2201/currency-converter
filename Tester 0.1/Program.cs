using System;
using System.Data.SqlTypes;
using System.Net.Security;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        float rubbelsInWallet;
        float dollarsInWallet;
        float BunRubbelsToWallet;


        int RubToUsd = 66, UsdToRub = 76,BunToRub = 26;

        float excaingCurrencyCount;
        Console.WriteLine("Добро пожаловать в обменник");

        string disaerOperation;

        Console.WriteLine("Введите баланс Российских рублей ");
        rubbelsInWallet = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Введите баланс  Белорусских рублей ");
        BunRubbelsToWallet = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Введите баланс Долларов ");
        dollarsInWallet = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Выберете операцию");
        Console.WriteLine("1 - обменять Российских рублей на доллары");
        Console.WriteLine("2 - обменять доллары на рубли");
        Console.WriteLine("3 - Обмен белорусских рублей на российские рубли");
        disaerOperation = Console.ReadLine();

        switch (disaerOperation) 
        {
            case "1":
                Console.WriteLine("Обмен рублей на доллары! ");
                Console.WriteLine(" Cколько валюты вы хотите обменять ? ");
                excaingCurrencyCount = Convert.ToSingle(Console.ReadLine());
                if(rubbelsInWallet >= excaingCurrencyCount)
                {
                    rubbelsInWallet -= excaingCurrencyCount;
                    dollarsInWallet += excaingCurrencyCount / RubToUsd;
                }
                else 
                {
                    Console.WriteLine("Недопустимое количество рублей!!!");
                }
                break;
            case "2":
                Console.WriteLine("Обмен долларов на рубли! ");
                Console.WriteLine(" Cколько валюты вы хотите обменять ? ");
                excaingCurrencyCount = Convert.ToSingle(Console.ReadLine());
                if (dollarsInWallet >= excaingCurrencyCount)
                {
                    dollarsInWallet -= excaingCurrencyCount;
                    rubbelsInWallet += excaingCurrencyCount * UsdToRub;
                }
                else
                {
                    Console.WriteLine("Недопустимое количество долларов!!!");
                }
                break;
            case "3":
                Console.WriteLine("Обмен белорусских рублей на российские рубли! ");
                Console.WriteLine(" Cколько валюты вы хотите обменять ? ");
                excaingCurrencyCount = Convert.ToSingle(Console.ReadLine());
                if (BunRubbelsToWallet >= excaingCurrencyCount)
                {
                    BunRubbelsToWallet -= excaingCurrencyCount;
                    rubbelsInWallet += excaingCurrencyCount * BunToRub;
                }
                else
                {
                    Console.WriteLine("Недопустимое количество долларов!!!");
                }
                break;
            default:
                Console.WriteLine("Такой операции нет!");
                break;
        }
        Console.WriteLine($"Ваш баланс Российских рублей: {rubbelsInWallet} " 
            + $"Ваш баланс долларов: {dollarsInWallet} " + $"Ваш баланс Белорусских рублей: {BunRubbelsToWallet}  ");





    }
    

}
