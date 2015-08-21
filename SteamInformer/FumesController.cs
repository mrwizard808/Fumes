using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.IO;

namespace Fumes {

    public class FumesController {

        List<INetworkOperation> pendingOperations;
        INetworkOperation currentOperation;
        Thread myThread;
        AutoResetEvent semaphore = new AutoResetEvent(true);
        bool closeThread = false;
        string urlBase = "http://steamreader.herokuapp.com/";

        public FumesController() {
            pendingOperations = new List<INetworkOperation>();
            myThread = new Thread(ThreadLoop);
            myThread.Start();
        }

        void ThreadLoop() {

            while(!closeThread) {

                if(pendingOperations.Count > 0) {
                    currentOperation = pendingOperations[0];
                    pendingOperations.RemoveAt(0);
                } else {
                    currentOperation = null;
                }

                if(currentOperation == null) {
                    semaphore.WaitOne();
                } else {

                    
                    WebRequest req = WebRequest.Create(urlBase + currentOperation.urlParams);
                    Console.WriteLine(req.RequestUri);
                    req.Method = "GET";
                    HttpWebResponse res = req.GetResponse() as HttpWebResponse;
                    Stream dataStream = res.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    currentOperation.callback(reader.ReadToEnd());

                }

            }

        }

        public void AddOperation(INetworkOperation op) {
            pendingOperations.Add(op);
            semaphore.Set();
        }

        ~FumesController() {
            closeThread = true;
        }

    }

}