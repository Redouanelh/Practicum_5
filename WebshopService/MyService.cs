using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PasswordGenerator;

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

        public String RegisterCheck(String username)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var customer = (from c in ctx.Customers
                                where c.Username == username
                                select c);

                if (!customer.Any())
                {
                    Console.WriteLine("\nGenerating password...");

                    // Methode die een password genereerd
                    var passwordGenerator = new Password().LengthRequired(8);
                    var password = passwordGenerator.Next();

                    Console.WriteLine("\nPassword generated...");

                    // Nieuwe customer in de database inserten (balance is als default 10)
                    Customer c = new Customer { Username = username, Password = password, Balance = 10 };
                    ctx.Customers.Add(c);
                    ctx.SaveChanges();

                    Console.WriteLine("\nCustomer saved...");

                    return password;
                }
                else
                {
                    Console.WriteLine("\nUsername already in use...");
                    return null;
                }
            }
        }
    }
}
