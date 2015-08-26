using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes {

    interface IApi {

        SteamNewsArticle[] GetGameNews(int appid);
        AchievementData[] GetGameGlobalAchievements(int appid);
        GameInfo[] GetAllGames();
        SteamGameProfile GetSteamLibrary(string user);

    }

}
