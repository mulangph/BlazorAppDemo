using BlazorApp1.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    public class EmployeeListBase: ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();

        }

        //public void LoadEmployees() {

        //    System.Threading.Thread.Sleep(2000);

        //    Employee E1 = new Employee
        //    {
        //        EmployeeId = 1,
        //        FirstName = "Marlon",
        //        LastName = "Ulang",
        //        Email = "marlon.ulang@gmail.com",
        //        DateOfBirth = new DateTime(1980, 2, 12),
        //        //Gender = Gender.Male.ToString(),
        //        //Department = new Department { DepartmentId = 1, DepartmentName = "IS" },
        //        PhotoPath = "images/m.ulang.png"
        //    };

        //    Employee E2 = new Employee
        //    {
        //        EmployeeId = 2,
        //        FirstName = "Juan",
        //        LastName = "Dela Cruz",
        //        Email = "j.delacruz@gmail.com",
        //        DateOfBirth = new DateTime(1981, 1, 2),
        //        //Gender = Gender.Male.ToString(),
        //        //Department = new Department { DepartmentId = 2, DepartmentName = "HR" },
        //        PhotoPath = "images/j.delacruz.png"
        //    };

        //    Employee E3 = new Employee
        //    {
        //        EmployeeId = 3,
        //        FirstName = "Jenny",
        //        LastName = "Doe",
        //        Email = "j.doe@gmail.com",
        //        DateOfBirth = new DateTime(1980, 5, 8),
        //        //Gender = Gender.Female.ToString(),
        //        //Department = new Department { DepartmentId = 3, DepartmentName = "Accounting" },
        //        PhotoPath = "images/j.doe.png"
        //    };

        //    Employees = new List<Employee> { E1, E2, E3 };

        //}

    }
}
