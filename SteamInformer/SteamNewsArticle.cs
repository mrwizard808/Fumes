using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Fumes {

    public class SteamNewsArticle {

        public long gid;
        public string title;
        public string url;
        public string author;
        public string contents;
        public string feedLabel;
        public DateTime date;
        public string feedName;

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
