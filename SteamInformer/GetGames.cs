using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes
{
    class GetGames : NetworkOperation
    {
        public GetGames(Action<string> callback) : base("/GetGames", callback) //by price, genre, on-sale user review
        {
            //will return a 10 long game list according to filter parameter provided
        }
    }
}
