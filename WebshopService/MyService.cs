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
            using (Model1Container ctx = new Model1Container())
            {
                var customer = (from c in ctx.Customers
                               where c.Username == username && c.Password == password
                               select c);
               
                if (customer.Any())
                {
                    Console.Write("\nLogin successful...");
                    return true;
                } else
                {
                    Console.WriteLine("\nLogin failed...");
                    return false;
                }
            }
           
        }
    }
}
