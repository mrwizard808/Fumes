using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Fumes {

    public class SteamGameProfile {

        public long steamId;
        public string steamName;
        public SteamGame[] games;

        public SteamGameProfile(XmlNode node) {

            steamId = long.Parse(node["steamID64"].InnerText);
            steamName = node["steamID"].InnerText;
            XmlNodeList gamesXml = node["games"].ChildNodes;
            games = new SteamGame[gamesXml.Count];
            for(int i = 0; i < gamesXml.Count; ++i) {
                games[i] = new SteamGame(gamesXml[i]);
            }

        }

    }

}
