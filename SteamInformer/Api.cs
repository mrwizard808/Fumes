using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;
using Newtonsoft;

namespace Fumes
{
    public class Api
    {

        private string myBaseUrl = "https://api.steampowered.com/";
        private string myKey = "A1C004B8A13F27D9DE916AD6864050E1";

        //get latest news for appid (game, dlc..)
        public object GetGameNews(int appid)
        {
            string result = GetDataFromUrl(myBaseUrl + "ISteamNews/GetNewsForApp/v0002/?appid="+appid+"&count=10&maxlength=300&format=json");
            object retVal = Serialization.MiniJSON.Json.Deserialize(result);
            return retVal;
        }

        //get global achievements for appid
        public object GetGameGlobalAchievements(int appid)
        {
            string result = GetDataFromUrl(myBaseUrl + "ISteamUserStats/GetGlobalAchievementPercentagesForApp/v0002/?gameid="+appid+"&format=json");
            object retVal = Serialization.MiniJSON.Json.Deserialize(result);
            return retVal;
        }

        //get list of all aps on the Steam store
        public object GetGameList()
        {
            string result = GetDataFromUrl(myBaseUrl + "ISteamApps/GetAppList/v2");
            object retVal = Serialization.MiniJSON.Json.Deserialize(result);
            return retVal;
            //try using newtonsoft??
        }

        //get steam library
        public object GetSteamLibrary(string user_id)
        {
            string result = GetDataFromUrl(myBaseUrl + "id/"+user_id+"/games?tab=all&xml=1");
            object retVal = Serialization.MiniJSON.Json.Deserialize(result);
            return retVal;
           
        }


       //http://steamcommunity.com/id/mr_wizard808/games?tab=all&xml=1

        private string GetDataFromUrl(string url)
        {
            WebRequest req = WebRequest.Create(url + "?key=" + myKey);
            Console.WriteLine(req.RequestUri);
            req.Method = "GET";
            HttpWebResponse res = req.GetResponse() as HttpWebResponse;
            Stream dataStream = res.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string result = reader.ReadToEnd();
            //close streams
            return result;

        }

        //public string Test()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
