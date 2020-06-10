using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;
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
        public Product GetProductById(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var product = (from p in ctx.Products
                                where p.ProductId == id
                                select p);

                if (product.Any())
                {
                    return product.First();
                }
                else
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
                    Console.WriteLine("Name: " + p.Name + " Price: " + p.Price + " Stock: " + p.Stock);
                    products.Add(p);
                }

                return products;
            }
        }

        public List<Product> GetProductsFromCustomer(int customerId)
        {
            using (Model1Container ctx = new Model1Container())
            {
                // Lege lijst waarin de producten komen die gereturned gaan worden
                List<Product> products = new List<Product>();

                // Haal de producten op uit de database van de desbetreffende customer
                Console.WriteLine("\nRetrieving products from current customer...");
                var linqproducts = from p in ctx.Products
                                   join pr in ctx.PaymentRules on p.ProductId equals pr.Product.ProductId
                                   join c in ctx.Customers on pr.Customers.CustomerId equals c.CustomerId
                                   where pr.Customers.CustomerId == customerId
                                   select new { ProductNaam = p.Name, ProductPrijs = p.Price, ProductAantal = pr.Amount, Totaal = pr.Amount * p.Price };

                foreach (var p in linqproducts)
                {
                    Product product = new Product { Name = p.ProductNaam, Price = p.ProductPrijs, Amount = p.ProductAantal };
                    Console.WriteLine("Name: " + product.Name + ", Price: " + product.Price + ", Amount: " + product.Amount);

                    products.Add(product);
                }

                return products;
            }
        }

        public String BuyProduct(Product product, Customer customer)
        {
            using (Model1Container ctx = new Model1Container())
            {
                Console.WriteLine("\nTrying to buy: " + product.Name + " with price: " + product.Price + " and stock: " + product.Stock + "...");
                // Check of er voldoende saldo is voor de betreffende product
                if (customer.Balance < product.Price)
                {
                    Console.WriteLine("Insufficient balance for product...");
                    return "Onvoldoende saldo voor product: '" + product.Name + "' met prijs: €" + product.Price;
                }

                // Check of de actuele voorraad van product groter dan 0 is
                int voorraad = GetProductById(product.ProductId).Stock;
                if (voorraad == 0)
                {
                    Console.WriteLine("Product is out of stock...");
                    return "Product: '" + product.Name + "' is uit voorraad";
                }

                // Saldo van customer verlagen
                var c = ctx.Customers.Where(cs => cs.CustomerId == customer.CustomerId).First();
                c.Balance -= product.Price;

                //voorraad van product verlagen
                Product p = ctx.Products.Where(pd => pd.ProductId == product.ProductId).First();
                p.Stock -= 1;

                // Check of product al in koppeltabel zit bij die customer. Zo ja, dan update aantal + 1. Zo nee, dan insert nieuwe rij in tabel
                var payment =   (from pm in ctx.PaymentRules
                                 join prod in ctx.Products on pm.Product.ProductId equals prod.ProductId
                                 join cust in ctx.Customers on pm.Customers.CustomerId equals cust.CustomerId
                                 where pm.Product.ProductId == p.ProductId && pm.Customers.CustomerId == c.CustomerId
                                select pm);

                if (payment.Any())
                {
                    PaymentRule pr = payment.First();
                    pr.Amount += 1;
                }
                else
                {
                    ctx.PaymentRules.Add(new PaymentRule { Customers = c, Product = p, Amount = 1 });
                }

                // Save de changes
                ctx.SaveChanges();

                return "Product: '" + product.Name + "'  met prijs: €" + product.Price + " is gekocht!";
            }

        }
    }
}
