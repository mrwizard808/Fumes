using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes {

    /// <summary>
    /// Interface for basic user steam profile
    /// </summary>
    public interface ISteamProfile {

        long steamId { get; }
        string steamName { get; }
        ISteamGame[] games { get; }

    }

}
