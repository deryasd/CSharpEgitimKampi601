﻿using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;

namespace CSharpEgitimKampi601.Services
{
    public class CustomerOperations
    {
        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerColection = connection.GetCustomerCollection();

            var document = new BsonDocument
            {
                {"CustomerName", customer.CustomerName},
                {"CustomerSurname",customer.CustomerSurname},
                {"CustomerCity",customer.CustomerCity},
                {"CustomerBalance",customer.CustomerBalance},
                {"CustomerShoppingCount",customer.CustomerShoppingCount}
            };

            customerColection.InsertOne(document);
        }
    }
}

