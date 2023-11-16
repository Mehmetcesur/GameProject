using Business.Absracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class SaleManager : ISalesService
    {
        public void SellGame(Gamer gamer, Game game)
        {
            if (game.Campaign!= null)
            {
                decimal discountAmount = (game.UnitPrice * game.Campaign.Discount) / 100;
                game.UnitPrice -= discountAmount;
                gamer.PurchasedGames.Add(game);
                Console.WriteLine("You purchased the game: " + game.Name + " " + game.UnitPrice);


            }
            else
            {
                gamer.PurchasedGames.Add(game);
                Console.WriteLine("You purchased the game: " + game.Name + " " + game.UnitPrice);

            }
            

        }
    }
}
