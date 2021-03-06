using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluationProgram
{
    public class AdminEmployee : AbstractEmployee, IAdminAccessPermissions
    {
        public AdminEmployee() { }

        public void AccessToGrantLeaves()
        {
            Console.WriteLine("Logic to grant leave for an employee");
            //This is the method particulat to the interface IAccessPermissions
        }

        public void AccessToUpdateInventory()
        {
            Console.WriteLine("Business logic where the admin can login and have access to update the inventory");
            //This is the method particulat to the interface IAccessPermissions
        }

        public override void AccessPermissionsToTeamsChannel()
        {
            Console.WriteLine("Contains access permissions to post info as well as add and remove members from a teams channel");
            //Method overridden from the Employee abstract class
        }
    }
}
