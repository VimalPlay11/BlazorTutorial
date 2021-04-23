using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
   public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }

        public static explicit operator Employee(Task<HttpResponseMessage> v)
        {
            throw new NotImplementedException();
        }

        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }
    }
}
