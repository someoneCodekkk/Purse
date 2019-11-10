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

            Console.ReadKey();
        }
    }
}
