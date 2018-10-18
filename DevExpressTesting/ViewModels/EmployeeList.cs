using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpressTesting.ViewModels
{
    public class EmployeeList
    {
        public static EmployeeSelectListItem[] EmployeeListItems = new[]
        {
            new EmployeeSelectListItem
            {
                EmployeeNumber = "1234",
                FirstName = "Thomas",
                LastName = "Jones",
                HomeDepartment = "Admin"
            },
            new EmployeeSelectListItem
            {
            EmployeeNumber = "5678",
            FirstName = "Robert",
            LastName = "Bloom",
            HomeDepartment = "IS"
            },
            new EmployeeSelectListItem
            {
                EmployeeNumber = "9101",
                FirstName = "Jane",
                LastName = "Griffin",
                HomeDepartment = "Admin"
            },
            new EmployeeSelectListItem
            {
                EmployeeNumber = "1121",
                FirstName = "Rebecca",
                LastName = "Adams",
                HomeDepartment = "Admin"
            },
            new EmployeeSelectListItem
            {
                EmployeeNumber = "3141",
                FirstName = "Crystal",
                LastName = "Vega",
                HomeDepartment = "IS"
            },
        };
    }
}