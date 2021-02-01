using System;
using System.Collections.Generic;

namespace GameProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User() { BirthYear = 1995, IdentityNumber = 12345678910, UserId = 1, UserLastName = "Bilgin", UserName = "Efe", Mail = "bilginefe@outlook.com" };

            UserManager userManager = new UserManager(new UserValidateManager());
            userManager.UserCreate(user1);

            Console.WriteLine("\n\n--------------------------------------\n\n");

            GamesManager gamesManager = new GamesManager();
            Games game1 = new Games() { GameId = 1, GameName = "Cyberpunk 2077", CompanyName = "CD Project Red", Platform = "PC and PS4" };
            Games game2 = new Games() { GameId = 2, GameName = "AC Valhalla", CompanyName = "Ubisoft", Platform = "PC and PS4" };
            gamesManager.GameAdd(game1);
            gamesManager.GameAdd(game2);

            Console.WriteLine("\n\n------------------------------\n\n");

            CampaingManager campaingManager = new CampaingManager();
            Campaings campaing = new Campaings(){ CampaingId = 1, CampaingName = "Kış Sezonu İndirimi", DiscountRate = 18};
            campaingManager.CampaingAdd(campaing);

            Console.WriteLine("\n\n-----------------------\n\n");

            List<Games> gameList = new List<Games>();
            gameList.Add(game1);
            gameList.Add(game2);
            OrderManager orderManager = new OrderManager();
            orderManager.ToOrder(user1, campaing, gameList);
        }
    }
}
