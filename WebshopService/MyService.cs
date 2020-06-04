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

        // Test methode
        public int Add(int x, int y)
        {
            return (x + y);
        }
    }
}
