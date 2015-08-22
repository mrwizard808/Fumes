using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes
{
    class GetHoursPlayed : NetworkOperation
    {
        public GetHoursPlayed(Action<string> callback) : base("/GerHoursPlayed", callback) //for registerd user
        {
            //will provide the TOTAL hours played by specific user 
        }
    }
}
