using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;

namespace Fumes {

    public class SteamGame {

        public int appId;
        public string name;
        public string logo;
        public string storeLink;
        public string statsLink;
        public string globalStatsLink;
        public double lastTwoWeeks;
        public double hoursOnRecord;

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
