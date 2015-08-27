using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes {

    /// <summary>
    /// Interface for the entire api
    /// </summary>
    public interface IApi {

        ISteamNewsArticle[] GetGameNews(int appid);
        IAchievementData[] GetGameGlobalAchievements(int appid);
        IGameInfo[] GetAllGames();
        ISteamProfile GetSteamLibrary(string user);

    }

}
