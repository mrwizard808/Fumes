using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Fumes {

    class SteamProfile : ISteamProfile {

        public long steamId { get; private set; }
        public string steamName { get; private set; }
        public ISteamGame[] games { get; private set; }

        public SteamProfile(XmlNode node) {

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
