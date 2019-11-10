using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCardProj;

namespace PurseProj
{
    class Program
    {

        static void Main(string[] args)
        {
            CreaditCard card = new CreaditCard()
            {
                ID = 0,
                Number = 12553,
                Name = "Vasya"
            };

            Console.WriteLine($"Name: {card.Name} Number: {card.Number}");
            MoneyLib.Money money = new MoneyLib.Money();
            money.Name = "Euro";
            money.Nominal = 500;
            money.Count = 1000;
            Console.WriteLine($"moneyname - {money.Name}, moneynominal - {money.Nominal}, moneysum - {money.Count}");
            Console.ReadKey();
        }
    }
}
