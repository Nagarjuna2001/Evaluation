using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluationProgram
{
    public abstract class Employee
    {
        public Employee() { }

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LasttName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LasttName;
        }

        public abstract void AccessPermissionsToTeamsChannel();
    }
}
