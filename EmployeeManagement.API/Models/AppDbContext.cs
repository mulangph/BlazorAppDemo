using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { 
        
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 1, DepartmentName = "IT" });
        //    modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 2, DepartmentName = "HT" });
        //    modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 3, DepartmentName = "Payroll" });
        //    modelBuilder.Entity<Department>().HasData(new Department { DepartmentId = 4, DepartmentName = "Admin" });

        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee
        //        {
        //            EmployeeId = 1,
        //            FirstName = "John",
        //            LastName = "Doe",
        //            Email = "john.doe@gmail.com",
        //            DateOfBirth = new DateTime(1990, 2, 23),
        //            Gender = Gender.Male.ToString(),
        //            DepartmentId = 1,
        //            PhotoPath = "images/john.doe.jpg"
        //        });

        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee
        //        {
        //            EmployeeId = 2,
        //            FirstName = "Sam",
        //            LastName = "Callaway",
        //            Email = "Sam.callaway@gmail.com",
        //            DateOfBirth = new DateTime(2001, 1, 10),
        //            Gender = Gender.Female.ToString(),
        //            DepartmentId = 2,
        //            PhotoPath = "images/sam.c.jpg"
        //        });

        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee
        //        {
        //            EmployeeId = 3,
        //            FirstName = "Alex",
        //            LastName = "Pan",
        //            Email = "Alex.pan@gmail.com",
        //            DateOfBirth = new DateTime(1980, 3, 11),
        //            Gender = Gender.Male.ToString(),
        //            DepartmentId = 3,
        //            PhotoPath = "images/alex.pan.jpg"
        //        });

        //    modelBuilder.Entity<Employee>().HasData(
        //        new Employee
        //        {
        //            EmployeeId = 4,
        //            FirstName = "Peter",
        //            LastName = "Sy",
        //            Email = "Petery.sy@gmail.com",
        //            DateOfBirth = new DateTime(1986, 2, 18),
        //            Gender = Gender.Male.ToString(),
        //            DepartmentId = 4,
        //            PhotoPath = "images/psy.jpg"
        //        });

        //}
    }
}
