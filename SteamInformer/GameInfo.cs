using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Fumes {

    public class GameInfo {

        public int appId;
        public string name;

        public GameInfo(ICollection json) {

            IDictionary dic = json as IDictionary;
            appId = Convert.ToInt32(dic["appid"]);
            name = dic["name"] as string;

        }

        public void Deserialize(ICollection json) {

            IDictionary dic = json as IDictionary;
            appId = Convert.ToInt32(dic["appid"]);
            name = dic["name"] as string;

        }

    }

}
