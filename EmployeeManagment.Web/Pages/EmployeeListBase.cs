using EmployeeManagement.Models;
using EmployeeManagment.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
       
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        //protected override Task OnInitializedAsync()
        //{
        //    LoadEmployees();
        //    return base.OnInitializedAsync();
        //}

        //private void LoadEmployees()
        //{
        //    Employee e1 = new Employee
        //    {
        //        EmployeeId = 1,
        //        FirstName = "Thyagaraju",
        //        LastName = "Govardhan",
        //        Email = "Raj@kpmg.com",
        //        Gender = Gender.Male,
        //        PhotoPath = "images/kpmg.jpg",
        //        DepartmentId = 1,
        //    };

        //    Employee e2 = new Employee
        //    {
        //        EmployeeId = 2,
        //        FirstName = "Sachin",
        //        LastName = "M S",
        //        Email = "Sachin@kpmg.com",
        //        Gender = Gender.Male,
        //        PhotoPath = "images/kpmg.jpg",
        //        DepartmentId = 1,
        //    };

        //    Employee e3 = new Employee
        //    {
        //        EmployeeId = 3,
        //        FirstName = "Ansar",
        //        LastName = "Shaik",
        //        Email = "Ansar@kpmg.com",
        //        Gender = Gender.Male,
        //        PhotoPath = "images/kpmg.jpg",
        //        DepartmentId = 2
        //    };

        //    Employee e4 = new Employee
        //    {
        //        EmployeeId = 4,
        //        FirstName = "Kesavan",
        //        LastName = "J",
        //        Email = "Kesavan@kpmg.com",
        //        Gender = Gender.Male,
        //        PhotoPath = "images/kpmg.jpg",
        //        DepartmentId = 1,
        //    };

        //    Employee e5 = new Employee
        //    {
        //        EmployeeId = 4,
        //        FirstName = "Vimal",
        //        LastName = "Kumar",
        //        Email = "Vimal@kpmg.com",
        //        Gender = Gender.Male,
        //        PhotoPath = "images/kpmg.jpg",
        //        DepartmentId = 1,
        //    };

        //    Employees = new List<Employee> { e1, e2, e3, e4, e5 };
        //}
    }
}
