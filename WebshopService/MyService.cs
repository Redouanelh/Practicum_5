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
        public Customer LoginCheck(String username, String password)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var customer = (from c in ctx.Customers
                               where c.Username == username && c.Password == password
                               select c);
               
                if (customer.Any())
                {
                    Console.WriteLine("\n" + username + " tried logging in...");
                    Console.WriteLine("Login successful...");
                    return customer.First();
                } else
                {
                    Console.WriteLine("\n" + username + " tried logging in...");
                    Console.WriteLine("Login failed...");
                    return null;
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

        public Customer GetCustomerById(int id)
        {
            using (Model1Container ctx = new Model1Container()) {
                var customer = (from c in ctx.Customers
                                where c.CustomerId == id
                                select c);

                if (customer.Any())
                {
                    return customer.First();
                } else
                {
                    return null;
                }
            } 
        }

        public List<Product> GetProducts()
        {
            using (Model1Container ctx = new Model1Container())
            {
                // Lege lijst waarin de producten komen die gereturned gaan worden
                List<Product> products = new List<Product>();

                // Haal de producten op uit de database met een stock (voorraad) boven de 0
                Console.WriteLine("\nRetrieving products from database with enough stock...");
                var linqproducts = from p in ctx.Products
                                   where p.Stock > 0
                                   select p;
                
                // Voeg de producten toe aan de lege lijst van hierboven
                foreach (Product p in linqproducts)
                {
                    Console.WriteLine("\nName: " + p.Name + " Price: " + p.Price + " Stock: " + p.Stock);
                    products.Add(p);
                }

                return products;
            }
        }

    }
}
