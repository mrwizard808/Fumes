using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes {

    /// <summary>
    /// Interface for steam game content data structure
    /// </summary>
    public interface ISteamGame {

        int appId { get; }
        string name { get; }
        string logo { get; }
        string storeLink { get; }
        string statsLink { get; }
        string globalStatsLink { get; }
        double lastTwoWeeks { get; }
        double hoursOnRecord { get; }

    }

}
