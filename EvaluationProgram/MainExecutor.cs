using System;

namespace EvaluationProgram
{
    public class MainExecutor
    {
        static void Main(string[] args)
        {
            AdminEmployee adminEmployee = new AdminEmployee();
            adminEmployee.ID = 15;
            adminEmployee.FirstName = "Steve";
            adminEmployee.LastName = "Smith";

            Console.WriteLine("Organistaion Name : {0}", adminEmployee.OrganisationName);
            Console.WriteLine("Employee's Name : " + adminEmployee.GetFullName());
            adminEmployee.AccessToGrantLeaves();
            adminEmployee.AccessToUpdateInventory();
            adminEmployee.AccessPermissionsToTeamsChannel();

            Console.WriteLine("\n");

            NormalEmployee normalEmployee = new NormalEmployee();
            normalEmployee.ID = 20;
            normalEmployee.FirstName = "Michael";
            normalEmployee.LastName = "Jordan";

            Console.WriteLine("Organistaion Name : {0}", adminEmployee.OrganisationName);
            Console.WriteLine("Employee's Name : " + normalEmployee.GetFullName());
            normalEmployee.AccessPermissionsToTeamsChannel();
        }
    }
}
