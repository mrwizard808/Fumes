using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes
{
    class GetStats : NetworkOperation
    {
        public GetStats(Action<string> callback) : base("/GetStats", callback) 
        {
            //will return the concurrent Steam Users 
        }
    }
}
