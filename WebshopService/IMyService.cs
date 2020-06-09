using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebshopService
{    [ServiceContract]
    public interface IMyService
    {

        [OperationContract]
        Customer LoginCheck(String username, String password);

        [OperationContract]
        String RegisterCheck(String username);

        [OperationContract]
        Customer GetCustomerById(int id);

        [OperationContract]
        List<Product> GetProducts();

        [OperationContract]
        List<Product> GetProductsFromCustomer(int customerId);

        [OperationContract]
        String BuyProduct(Product product, Customer customer);

    }
}