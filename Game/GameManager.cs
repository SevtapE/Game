using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GameManager
    {
        private decimal _sellPrice;
        public void Buy(Person person,Game game)
        {
            Console.WriteLine(person.FirstName+ " You bought this game:\" "+game.Name+"\" with this price: "+game.UnitPrice);
        }
        public void Buy(Person person, Game game,Campaign campaign)
        {
           
            Console.WriteLine(person.FirstName + " You bought this game: \"" + game.Name + "\" with this price: " + CalculateSellPrice(game, campaign));
        }

        public void Show(List<Game> games)
        {
            foreach (var game in games)
            {
                Console.WriteLine("***Game properties***");
                Console.WriteLine("Name: "+game.Name);
                Console.WriteLine("Price: "+game.UnitPrice);
                Console.WriteLine("Total in stock:  "+ game.UnitInStock);
            }
        }

        public decimal CalculateSellPrice(Game game,Campaign campaign)
        {
            _sellPrice = (game.UnitPrice * (100 - campaign.DiscountPercentage)) / 100;
            return _sellPrice;

        }
    }
}
