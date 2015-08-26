using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Fumes {

    public class AchievementData {

        string name;
        double percent;

        public AchievementData(ICollection json) {

            IDictionary dic = json as IDictionary;
            name = dic["name"] as string;
            percent = Convert.ToDouble(dic["percent"]);

        }

        public void Deserialize(ICollection json) {

            IDictionary dic = json as IDictionary;
            name = dic["name"] as string;
            percent = Convert.ToDouble(dic["percent"]);

        }

    }

}
