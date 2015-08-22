using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes
{
    class GetReview : NetworkOperation
    {
        public GetReview(Action<string> callback) : base("/GetReview", callback)  //by curators . users
        {
            //will return the last review from curator or by users
        }
    }
}
