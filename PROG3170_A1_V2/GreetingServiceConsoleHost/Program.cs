using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

using GreetingService;

namespace GreetingServiceConsoleHost
{
    public class Program
    {
        public static void Main(string[] args)
        {

            using (ServiceHost host = new ServiceHost(typeof(GreetingServiceType)))
            {
                host.Open();

                Console.WriteLine("The greeting service ready - press any key to shutdown.");
                Console.ReadKey(true);

                host.Close();
            }

        }
    }
}
