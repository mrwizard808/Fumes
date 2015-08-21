using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumes {

    public class NetworkOperation : INetworkOperation {

        public string urlParams { get; private set; }
        public Action<string> callback { get; private set; }

        public NetworkOperation(string url, Action<string> callback) {
            this.urlParams = url;
            this.callback = callback;
        }

    }

}
