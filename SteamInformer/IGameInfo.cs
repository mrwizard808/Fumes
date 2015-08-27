using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes {

    /// <summary>
    /// Interface for game information data structures
    /// </summary>
    public interface IGameInfo {

        int appId { get; }
        string name { get; }

    }

}
