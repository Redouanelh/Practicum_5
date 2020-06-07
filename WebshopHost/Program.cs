using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using WebshopService;

namespace WebshopHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MyService)))
            {
                host.Open();
                Console.WriteLine("Service ready...");
                Console.ReadKey();
            }
        }
    }
}
