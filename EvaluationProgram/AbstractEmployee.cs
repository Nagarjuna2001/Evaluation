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

        public string LastName { get; set; }

        public string OrganisationName = "NCR Corporation";

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public abstract void AccessPermissionsToTeamsChannel();
    }
}
