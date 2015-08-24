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
            SteamAPISession session = new SteamAPISession();

            Console.Write("Username: ");
            String username = Console.ReadLine();
            Console.Write("Password: ");
            String password = Console.ReadLine();

            SteamAPISession.LoginStatus status = session.Authenticate(username, password);
            if (status == SteamAPISession.LoginStatus.SteamGuard)
            {
                Console.Write("SteamGuard code: ");
                String code = Console.ReadLine();

                status = session.Authenticate(username, password, code);
            }

            if (status == SteamAPISession.LoginStatus.LoginSuccessful)
            {
               
                Console.WriteLine("grate sucsess !!!");
            }
            else
            {
                Console.WriteLine("Failed to log in!");
            }


           // WebRequest req = WebRequest.Create(LogInURL);
           // req.Method = "POST";

           
        }
    }
}
