using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes {

    public interface INetworkOperation {

        string urlParams { get; }
        Action<string> callback { get; }

    }

}
