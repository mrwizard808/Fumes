using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;
using Newtonsoft;
using System.Collections;
using System.Xml;

namespace Fumes {

    public class FumesApiHandler : IApi {

        public static FumesApiHandler instance {get; private set;}
        static FumesApiHandler() {
            instance = new FumesApiHandler();
        }

        private FumesApiHandler() {

        }

        /// <summary>
        /// Retrieves the 100 latest news for the an app
        /// </summary>
        /// <param name="appid">The app to retrieve news for</param>
        /// <returns>SteamNewArticle Array containing the retrived news</returns>
        public SteamNewsArticle[] GetGameNews(int appid) {

            string result = GetDataFromUrl(Tags.steamApiUrl + "ISteamNews/GetNewsForApp/v0002/?appid=" + appid + "&count=100&format=json");
            IDictionary mainDic = Serialization.MiniJSON.Json.Deserialize(result) as IDictionary;
            IDictionary secDic = mainDic["appnews"] as IDictionary;
            IList newsList = secDic["newsitems"] as IList;
            SteamNewsArticle[] retVal = new SteamNewsArticle[newsList.Count];

            for(int i = 0; i < retVal.Length; ++i) {
                retVal[i] = new SteamNewsArticle(newsList[i] as ICollection);
            }

            return retVal;

        }

        /// <summary>
        /// Retrived the global achievements stats for a game
        /// </summary>
        /// <param name="appid">The game to retrive the achievements for</param>
        /// <returns>AchievementData Array containing all the achivements that the game has</returns>
        public AchievementData[] GetGameGlobalAchievements(int appid) {

            string result = GetDataFromUrl(Tags.steamApiUrl + "ISteamUserStats/GetGlobalAchievementPercentagesForApp/v0002/?gameid=" + appid + "&format=json");
            IDictionary mainDic = Serialization.MiniJSON.Json.Deserialize(result) as IDictionary;
            IDictionary secDic = mainDic["achievementpercentages"] as IDictionary;
            IList achievements = secDic["achievements"] as IList;
            AchievementData[] retVal = new AchievementData[achievements.Count];

            for(int i = 0; i < retVal.Length; ++i) {
                retVal[i] = new AchievementData(achievements[i] as ICollection);
            }

            return retVal;

        }

        /// <summary>
        /// Retieves the basic information for all the games in the steam store
        /// </summary>
        /// <returns>GameInfo Array containing all the games in the steam store</returns>
        public GameInfo[] GetAllGames() {

            string result = GetDataFromUrl(Tags.steamApiUrl + "ISteamApps/GetAppList/v2");
            IDictionary mainDic = Serialization.MiniJSON.Json.Deserialize(result) as IDictionary;
            IDictionary secDic = mainDic["applist"] as IDictionary;
            IList games = secDic["apps"] as IList;
            GameInfo[] retVal = new GameInfo[games.Count];

            for(int i = 0; i < retVal.Length; ++i) {
                retVal[i] = new GameInfo(games[i] as ICollection);
            }

            return retVal;

        }

        /// <summary>
        /// Retirves a user's steam games and their basic info with links
        /// </summary>
        /// <param name="user">The user name for which the library should be retrived</param>
        /// <returns>SteamGameProfile of the user containing its info</returns>
        public SteamGameProfile GetSteamLibrary(string user) {

            string result = GetDataFromUrl(Tags.steamCommunityUrl + "/id/" + user + "/games?tab=all&xml=1");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(result);
            SteamGameProfile retVal = new SteamGameProfile(doc["gamesList"]);
            return retVal;

        }

        /// <summary>
        /// Helper function for networked calls
        /// </summary>
        string GetDataFromUrl(string url) {

            WebRequest req = WebRequest.Create(url); //  + "?key=" + Tags.apiKey);
            // Console.WriteLine(req.RequestUri);
            req.Method = "GET";
            HttpWebResponse res = req.GetResponse() as HttpWebResponse;
            Stream dataStream = res.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string result = reader.ReadToEnd();
            //close streams
            return result;

        }

    }

}
