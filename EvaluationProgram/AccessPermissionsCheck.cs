using System;

namespace EvaluationProgram
{
    public class AccessPermissionsCheck
    {
        static void Main(string[] args)
        {
            AdminEmployee adminEmployee = new AdminEmployee();
            adminEmployee.ID = 15;
            adminEmployee.FirstName = "Steve";
            adminEmployee.LasttName = "Smith";

            Console.WriteLine(adminEmployee.GetFullName());
            adminEmployee.AccessToGrantLeaves();
            adminEmployee.AccessToUpdateInventory();
            adminEmployee.AccessPermissionsToTeamsChannel();


            NormalEmployee normalEmployee = new NormalEmployee();
            normalEmployee.ID = 20;
            normalEmployee.FirstName = "Michael";
            normalEmployee.LasttName = "Jordan";

            Console.WriteLine(normalEmployee.GetFullName());
            normalEmployee.AccessPermissionsToTeamsChannel();
        }
    }
}
