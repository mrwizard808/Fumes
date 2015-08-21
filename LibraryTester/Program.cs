using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fumes;

namespace LibraryTester {

    class Program {

        static void Main(string[] args) {

            FumesController controller = new FumesController();
            NetworkOperation op = new NetworkOperation("", (string data) => {
                Console.WriteLine(data);
            });
            controller.AddOperation(op);

        }

    }

}
