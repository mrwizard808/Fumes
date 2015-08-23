using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Fumes
{
    class UserLogIn  
    {
        string LogInURL = "http://api.steampowerd.com/";
        public UserLogIn(Action<string> callback)
        {
            WebRequest req = WebRequest.Create(LogInURL);
            req.Method = "POST";

           
        }
    }
}
