using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes
{
    class GetNumOfPlayers : NetworkOperation
    {
        public GetNumOfPlayers(Action<string> callback) : base("/GetNumOfPlayers", callback)  //for game
        {
            //will return the the number of players for game
        }
    }
}
