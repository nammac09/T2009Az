using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees__information.Models;

namespace Employees__information.Data
{
    public class SeedData
    {
        public static void Initialize(Employees__informationContext context)
        {
            context.Database.EnsureCreated();
            if (context.Department.Any())
            {
                return;
            }
            var departments = new Department[]
            {
                new Department { Name = "Quản Lý" , Salary = 3000},
                new Department { Name = "Nhân Viên" , Salary = 1300},
            };
            foreach (Department d in departments)
            {
                context.Department.Add(d);
            }
            context.SaveChanges();
            var employees = new Employee[]
            {
                new Employee { Name = "Nam " , DepartmentID = departments.Single(s => s.Name == "Quản Lý").ID},
                new Employee { Name = "Do mac Nam " , DepartmentID = departments.Single(s => s.Name == "Nhân Viên").ID},
                new Employee { Name = "Do mac Nam 2" , DepartmentID = departments.Single(s => s.Name == "Nhân Viên").ID},
                new Employee { Name = "Do mac Nam 3" , DepartmentID = departments.Single(s => s.Name == "Nhân Viên").ID},
            };
            foreach (Employee e in employees)
            {
                context.Employee.Add(e);
            }
            context.SaveChanges();
        }
    }
}
