using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Thyagaraju",
                LastName = "Govardhan",
                Email = "Raj@kpmg.com",
                Gender = Gender.Male,
                PhotoPath = "images/kpmg.jpg",
                DepartmentId = 1,
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Sachin",
                LastName = "M S",
                Email = "Sachin@kpmg.com",
                Gender = Gender.Male,
                PhotoPath = "images/kpmg.jpg",
                DepartmentId = 1,
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Ansar",
                LastName = "Shaik",
                Email = "Ansar@kpmg.com",
                Gender = Gender.Male,
                PhotoPath = "images/kpmg.jpg",
                DepartmentId = 2
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Kesavan",
                LastName = "J",
                Email = "Kesavan@kpmg.com",
                Gender = Gender.Male,
                PhotoPath = "images/kpmg.jpg",
                DepartmentId = 1,
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 5,
                FirstName = "Vimal",
                LastName = "Kumar",
                Email = "Vimal@kpmg.com",
                Gender = Gender.Male,
                PhotoPath = "images/kpmg.jpg",
                DepartmentId = 1,
            });
        }
    }
}