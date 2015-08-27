using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes {

    /// <summary>
    /// Interface for steam news articles data structure
    /// </summary>
    public interface ISteamNewsArticle {

        long gid { get; }
        string title { get; }
        string url { get; }
        string author { get; }
        string contents { get; }
        string feedLabel { get; }
        DateTime date { get; }
        string feedName { get; }

    }

}
