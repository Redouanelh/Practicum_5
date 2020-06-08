﻿using System;
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
        Boolean LoginCheck(String username, String password);

        [OperationContract]
        String RegisterCheck(String username);

        // deze moet verplaatst worden naar een productservice file
        [OperationContract]
        List<Product> GetProducts();
    }
}
