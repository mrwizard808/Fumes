using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fumes;

namespace FumesBurner {

    [TestClass]
    public class FumesToxicity {

        [TestMethod]
        public void NewsNetworkTest() {

            int appid = 221540;
            SteamNewsArticle[] retVal = FumesApiHandler.instance.GetGameNews(appid);

            if(retVal == null) {
                Console.WriteLine("Error in GetGameNews");
                throw new Exception();
            } else {
                if(retVal.Length == 0) {
                    Console.WriteLine("No news returned");
                    throw new Exception();
                } else {
                    Console.WriteLine("All OK");
                }
            }

        }

        [TestMethod]
        public void AchievementsTest() {

            int appid = 221540;
            AchievementData[] retVal = FumesApiHandler.instance.GetGameGlobalAchievements(appid);

            if(retVal == null) {
                Console.WriteLine("Error in GetGameGlobalAchievements");
                throw new Exception();
            } else {
                if(retVal.Length == 0) {
                    Console.WriteLine("No achievements returned");
                    throw new Exception();
                } else {
                    Console.WriteLine("All OK");
                }
            }

        }

        [TestMethod]
        public void AllGamesTest() {

            GameInfo[] retVal = FumesApiHandler.instance.GetAllGames();

            if(retVal == null) {
                Console.WriteLine("Error in GetAllGames");
                throw new Exception();
            } else {
                if(retVal.Length == 0) {
                    Console.WriteLine("No games returned");
                    throw new Exception();
                } else {
                    Console.WriteLine("All OK");
                }
            }

        }

        [TestMethod]
        public void LibraryTest() {

            string user = "mr_wizard808";
            SteamGameProfile retVal = FumesApiHandler.instance.GetSteamLibrary(user);

            if(retVal == null) {
                Console.WriteLine("Error in GetSteamLibrary");
                throw new Exception();
            } else {
                Console.WriteLine("User name: " + retVal.steamName);
                Console.WriteLine("User ID: " + retVal.steamId);
                if(retVal.games.Length == 0) {
                    Console.WriteLine("No games on user returned, its still OK");
                } else {
                    Console.WriteLine("All OK");
                }
            }

        }

    }

}
