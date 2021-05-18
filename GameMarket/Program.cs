using GameMarket.Concrete;
using GameMarket.Entities;
using System;

namespace GameMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Mehmet Taha",
                LastName = "Kocal",
                DateOfBirth = new DateTime(2002, 06, 03),
                NationalityId = 12341256235
            };

            GamerManager gamerManager = new GamerManager(new VerificationManager());
            gamerManager.SignUp(gamer1);


            Game game1 = new Game()
            {
                Id = 1,
                GameName = "GTA V",
                GamePrice = 180
            };


            GameManager gameManager = new GameManager();
            gameManager.Add(game1);


            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "KIS INDIRIMI !!!!",
                Discount = 50
            };


            SellManager sellManager = new SellManager();
            sellManager.Sell(game1, gamer1, campaign1);

            Console.ReadLine();

        }
    }
}
