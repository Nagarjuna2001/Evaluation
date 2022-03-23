using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluationProgram
{
    public class NormalEmployee : AbstractEmployee
    {
        public NormalEmployee() { }

        public override void AccessPermissionsToTeamsChannel()
        {
            Console.WriteLine("Contains logic which has access permission to add and delete new post in the channel");

            //Does not have permissions (logic) to add and remove members from the channel unlike AdminEmployee
        }
        
    }
}
