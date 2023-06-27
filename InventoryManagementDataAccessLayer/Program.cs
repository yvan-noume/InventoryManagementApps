using InventoryManagementApplicationLayer;
using InventoryManagementApplicationLayer.Data_Transfer_Objects;
using InventoryManagementApplicationLayer.Services;
using InventoryManagementDataAccessLayer;
using InventoryManagementDomainLayer;
using System;
using System.Collections.Generic;

public class Program
{

    public static void Main(string[] args)
    {
        //Code to be executed when the application runs
        //bool result = CustomerDataOperations.CreateCustomer("Yvan", "Yvan", "Yvan", 4555, "yvan", DateTime.Now);
        //var customer = new CustomerDTO {FirstName="Peter",LastName="Peter",Email="Yvan",PhoneNumber=4555, Address="Yvan",DateMembership= null};
        //CustomerDataOperations customerDataOperations = new CustomerDataOperations();
        //var result = customerDataOperations.GetAllCustomers();
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item.FirstName);
        //}

        var category = new CategoryDTO { Name = "Yvan", Description="Peter", Products = null };
        CategoryDataOperations categoryDataOperations = new CategoryDataOperations();
        var result = categoryDataOperations.GetAllCategories();
        foreach (var item in result)
        {
            Console.WriteLine(item.Name);
        }
    }
}


