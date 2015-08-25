using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fumes;
using System.IO;


namespace LibraryTester
{

    class Program
    {

        static void Main(string[] args)
        {
            Api test = new Api();
            test.GetGameList();
            //test.GetGameNews(208200);

            //FileStream ostrm = null;
            //StreamWriter writer = null;

            //try
            //{
            //    ostrm = new FileStream("./Output.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //    writer = new StreamWriter(ostrm);
            //    writer.WriteLine("**************" + DateTime.Now.ToString() + "**************");
            //    //writer.WriteLine(new Fumes.Api().Test());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Cannot open Output.txt for writing");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (writer != null) { writer.Close(); }
            //    if (ostrm != null) { ostrm.Close(); } 
            //}

        }
    }

}