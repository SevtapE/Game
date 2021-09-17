using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Methods down below are control codes for program functionality.
             You can see results by uncommenting 
            */

            // PersonOperations();
            // ShowGames();
            // CampaignOperations();

            // ValidationAddition();

            MernisValidation();

        }

        private static void MernisValidation()
        {
            Person gamer1 = new Gamer()
            {
                Id = 9,
                FirstName = "SEVTAP",
                LastName = "E",
                DateOfBirth = new DateTime(1987, 1, 1),
                NationalityId = "1111111"
            };
            IPersonManager personManager = new GamerManager(new MernisPersonValidationManager());
            personManager.Add(gamer1);

            Person supplier1 = new Supplier()
            {
                Id = 6,
                FirstName = "SEVTAP",
                LastName = "E",
                DateOfBirth = new DateTime(1988, 1, 1),
                NationalityId = "222222222"


            };
            SupplierManager supplierManager = new SupplierManager(new MernisPersonValidationManager());
            supplierManager.Add(supplier1);
        }

        private static void ValidationAddition()
        {
            Person gamer1 = new Gamer() { Id = 5, FirstName = "Tarık" };
            IPersonManager personManager = new GamerManager(new PersonValidationManager());
            personManager.Add(gamer1);

            Person supplier1 = new Supplier()
            {
                Id = 6,
                FirstName = "Beliz",
                NationalityId = "111222333"


            };
            SupplierManager supplierManager = new SupplierManager(new PersonValidationManager());
            supplierManager.Add(supplier1);
        }

        private static void CampaignOperations()
        {
            Campaign campaign1 = new Campaign() { Id = 1, Name = "Today's chance", DiscountPercentage = 35 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            Campaign campaign2 = new Campaign() { Id = 2, Name = "Holiday discount", DiscountPercentage = 50 };
            List<Campaign> campaigns = new List<Campaign>() { campaign1, campaign2 };
            campaignManager.Show(campaigns);

            GameManager gameManager = new GameManager();
            decimal sellPrice = gameManager.CalculateSellPrice(new Game { UnitPrice = 45 }, new Campaign { DiscountPercentage = 15 });
            Console.WriteLine(sellPrice);

            gameManager.Buy(new Gamer { Id = 3, FirstName = "Bulut", LastName = "Nazır" }, new Game { Id = 6, Name = "Books", UnitPrice = 88 }, campaign2);
        }

        private static void PersonOperations()
        {
            IPersonManager personManager = new GamerManager(new PersonValidationManager());

            Person gamer = new Gamer()
            {
                Id = 1,
                FirstName = "Sevtap",
                LastName = "SevtapE",
                DateOfBirth = new DateTime(1988, 8, 23),
                NationalityId = "111222222"

            };



            personManager.Add(gamer);
            personManager.Update(gamer);
            personManager.Delete(gamer);



            IPersonManager personManager1 = new SupplierManager(new PersonValidationManager());
            personManager1.Add(new Supplier { Id = 2, FirstName = "Yeşim", LastName = "Varlı", NationalityId = "2223334444444", DateOfBirth = new DateTime(1978, 3, 2), TaxNumber = "11144445" });


            Person person = new Person { Id = 2, FirstName = "Ahmet", LastName = "Ay", DateOfBirth = new DateTime(1968, 4, 5), NationalityId = "333445566" };
            personManager.Add(person);
        }

        private static void ShowGames()
        {
            Game game1 = new Game() { Id = 1, Name = "Winwin", UnitPrice = 35, UnitInStock = 5 };
            Game game2 = new Game() { Id = 2, Name = "Lost", UnitPrice = 15, UnitInStock = 3 };


            // List<Game> games = new List<Game> { game1};
            List<Game> games = new List<Game> { game1, game2 };
            GameManager gameManager = new GameManager();
            //gameManager.Buy(gamer, game1);

            gameManager.Show(games);
        }
    }
}
