using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPeregruzOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*City city1 = new City();
            City city2 = new City();
            city2.People = 5000;
            city1.NameCity = "Kiev";
            city1.NameCountry = "Ukraine";
            city1.NameRegion = "Kievska obl";
            city1.People = 4500000;
            city1+=5;
            city1 -= 4000000;
            if(city1 == city2)
            {
                Console.Write("city1 == city2");

            }
            else { Console.Write("city1 != city2"); };*/

            KreditCard card1 = new KreditCard();
            card1.MoneyinCard = 115000;
            KreditCard card2 = new KreditCard();
            card2.MoneyinCard = 15000;
            if(card1 < card2)
            {
                Console.Write($"card1 has {card1.MoneyinCard}$ < card2 has {card2.MoneyinCard}$\n");
            }
            else { Console.Write($"card1 has {card1.MoneyinCard}$ > card2 has {card2.MoneyinCard}$\n"); }
            if (card1 == card2)
            {
                Console.Write($"card1 CVC {card1.CCVVCC} == card2 CVC {card2.CCVVCC}\n");
            }
            else { Console.Write($"card1 CVC {card1.CCVVCC} != card2 CVC {card2.CCVVCC}\n"); }
            Console.Write(card1);
            Console.ReadLine();
        }
    }
}
