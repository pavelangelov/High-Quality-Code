﻿using Nortwind_Entity_Operations.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind_Entity_Operations.Models
{
    public static class CustomersDAO
    {
        private static NorthwindEntities db = new NorthwindEntities();
        
        public static void AddNewCustomer(string companyName, string customerId, string country, string city, string phone)
        {
            var logFilePath = @"../../Logs/log.txt";
            using (var writer = new StreamWriter(logFilePath, true))
            {
                db.Database.Log = writer.WriteLine;

                db.Customers.Add(new Customer
                {
                    CustomerID = customerId,
                    CompanyName = companyName,
                    Country = country,
                    City = city,
                    Phone = phone
                });

                db.SaveChanges();
            }
        }

        public static void AddNewCustomer(CustomerPoco customer)
        {
            var logFilePath = @"../../Logs/log.txt";
            using (var writer = new StreamWriter(logFilePath, true))
            {
                db.Database.Log = writer.WriteLine;

                db.Customers.Add(new Customer
                {
                    CustomerID = customer.CustomerID,
                    CompanyName = customer.CompanyName,
                    Country = customer.Country,
                    ContactName = customer.ContactName,
                    City = customer.City,
                    ContactTitle = customer.ContactTitle,
                    Address = customer.Address,
                    Region = customer.Region,
                    PostalCode = customer.PostalCode,
                    Phone = customer.Phone
                });

                db.SaveChanges();
            }

        }

        public static string UpdateCustomer(string customerId, string name)
        {
            var customer = db.Customers.Find(customerId);

            if (customer != null)
            {
                customer.ContactName = name;
                db.SaveChanges();
                return $"Customer with CustomerId: {customerId} updated successefully!";
            }
            else
            {
                return $"Customer with CustomerId: {customerId} doesn`t exist!";
            }
        }

        public static string RemoveCustomer(string customerId)
        {
            var customer = db.Customers.Find(customerId);
            if (customer != null)
            {
                db.Customers.Remove(customer);
                db.SaveChanges();
                return $"Customer with CustomerId: {customerId} is removed.";
            }
            else
            {
                return $"Customer with CustomerId: {customerId} doesn`t exist!";
            }

        }

        public static string ListAllCustomersByOrdersYearAndShippedCountry(int year, string country)
        {
            var result = new StringBuilder();
            var orders = db.Orders.Where(o => o.OrderDate.Value.Year == year && o.ShipCountry == country);

            foreach (var order in orders)
            {
                result.AppendLine($"Customer: {order.Customer.CompanyName}, Order date: {order.OrderDate.Value.ToShortDateString()}, Ship country: {order.ShipCountry}");
            }
            return result.ToString();
        }

        public static string ListAllCustomers()
        {
            var result = new StringBuilder();
            foreach (var customer in db.Customers)
            {
                result.AppendLine($"CustomerId: {customer.CustomerID}, Contact name: {customer.ContactName}");
            }

            return result.ToString();
        }
        
    }
}
