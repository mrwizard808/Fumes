using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;

namespace Fumes {

    class SteamGame : ISteamGame {

        public int appId { get; private set; }
        public string name { get; private set; }
        public string logo { get; private set; }
        public string storeLink { get; private set; }
        public string statsLink { get; private set; }
        public string globalStatsLink { get; private set; }
        public double lastTwoWeeks { get; private set; }
        public double hoursOnRecord { get; private set; }

        public SteamGame(XmlNode node) {

            XmlNode tmp;

            tmp = node["appID"];
            if(tmp != null) {
                appId = int.Parse(tmp.InnerText);
            }
            tmp = node["name"];
            if(tmp != null) {
                name = tmp.InnerText;
            }
            tmp = node["logo"];
            if(tmp != null) {
                logo = tmp.InnerText;
            }
            tmp = node["storeLink"];
            if(tmp != null) {
                storeLink = tmp.InnerText;
            }
            tmp = node["statsLink"];
            if(tmp != null) {
                statsLink = tmp.InnerText;
            }
            tmp = node["globalStatsLink"];
            if(tmp != null) {
                globalStatsLink = tmp.InnerText;
            }
            tmp = node["hoursLast2Weeks"];
            if(tmp != null) {
                lastTwoWeeks = double.Parse(tmp.InnerText);
            }
            tmp = node["hoursOnRecord"];
            if(tmp != null) {
                hoursOnRecord = double.Parse(tmp.InnerText);
            }

        }

    }

}
