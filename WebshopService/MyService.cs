using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebshopService
{
    public class MyService : IMyService
    {
        public Boolean LoginCheck(String username, String password)
        {
            Console.WriteLine("Username: " + username + " en password: " + password);
            return false;
        }
    }
}
