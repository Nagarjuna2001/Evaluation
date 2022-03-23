using System;
using System.Collections.Generic;

namespace Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee { ID = "100", Name = "Smith" ,salary = 5000};
            Employee secondEmployee = new Employee { ID = "101", Name = "Mark", salary = 4000 };
            Employee thirdEmployee = new Employee { ID = "101", Name = "Alice", salary = 6000 };

            Dictionary<string, Employee> fetchEmployeeDetails = new Dictionary<string, Employee>();
            fetchEmployeeDetails.Add(firstEmployee.ID, firstEmployee);
            fetchEmployeeDetails.Add(secondEmployee.ID, secondEmployee);

            

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(firstEmployee);
            employeeList.Add(secondEmployee);
            employeeList.Add(thirdEmployee);

            List<Employee> employeesWithSalaryAboveFiveThousand = employeeList.FindAll(employee => employee.salary >= 5000);

            foreach(Employee employee in employeesWithSalaryAboveFiveThousand)
            {
                Console.WriteLine(employee.Name);
            }

        }
    }
}
