using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Fumes {

    class SteamNewsArticle : ISteamNewsArticle {

        public long gid { get; private set; }
        public string title { get; private set; }
        public string url { get; private set; }
        public string author { get; private set; }
        public string contents { get; private set; }
        public string feedLabel { get; private set; }
        public DateTime date { get; private set; }
        public string feedName { get; private set; }

        public SteamNewsArticle(ICollection json) {

            IDictionary dic = json as IDictionary;
            gid = Convert.ToInt64(dic["gid"]);
            title = dic["title"] as string;
            url = dic["url"] as string;
            author = dic["author"] as string;
            contents = dic["contents"] as string;
            feedLabel = dic["feedlabel"] as string;
            date = new DateTime(Convert.ToInt64(dic["date"]));
            feedName = dic["feedname"] as string;

        }

        public void Deserialize(ICollection json) {

            IDictionary dic = json as IDictionary;
            gid = Convert.ToInt64(dic["gid"]);
            title = dic["title"] as string;
            url = dic["url"] as string;
            author = dic["author"] as string;
            contents = dic["contents"] as string;
            feedLabel = dic["feedlabel"] as string;
            date = new DateTime(Convert.ToInt64(dic["date"]));
            feedName = dic["feedname"] as string;

        }

    }

}
