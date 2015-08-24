
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;

namespace Fumes
{
    public class Api
    {

        private string myBaseUrl = "https://api.steampowered.com/";
        private string myKey = "A1C004B8A13F27D9DE916AD6864050E1";

        public string GetCsgoServers()
        {
            return GetDataFromUrl(myBaseUrl + "ICSGOServers_730/GetGameServersStatus/v1/");
        }


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
    }
}
