

using Business.Concretes;
using Entities.Concretes;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "BlackFriday";
            campaign1.Discount = 50;

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.Name = "Mehmet";
            gamer1.IdentityNo = "12345678999";
            gamer1.BirthYear = 1994;

            Game game1 = new Game();
            game1.Id = 1;
            game1.Name = "csgo";
            game1.UnitPrice = 100;
            game1.Campaign = campaign1;

            Game game2 = new Game();
            game2.Id = 2;
            game2.Name = "lol";
            game2.UnitPrice = 50;
            game2.Campaign = campaign1;





            GamerManager gamerManager = new GamerManager(new ValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);


            Console.WriteLine("---------------");

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);

            gameManager.Add(game2);


            Console.WriteLine("---------------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            Console.WriteLine("---------------");

            SaleManager saleManager = new SaleManager();
            saleManager.SellGame(gamer1, game1);
            saleManager.SellGame(gamer1, game2);


        }
    }
}