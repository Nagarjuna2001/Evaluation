using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluationProgram
{
    public abstract class AbstractEmployee
    {
        public AbstractEmployee() { }

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LasttName { get; set; }

        public string organisationName = "NCR Corporation";

        public string GetFullName()
        {
            return this.FirstName + " " + this.LasttName;
        }

        public abstract void AccessPermissionsToTeamsChannel();
    }
}
