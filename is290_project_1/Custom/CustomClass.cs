using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using is290_project_1.Models;

namespace is290_project_1.Custom
{
    public class CustomClass
    {
        //initialize db context and use items from it

        public void GetEmployeeID()
        {
            is290dbEntities1 dbModel = new is290dbEntities1();
            int count = dbModel.Employees.Count();

        }

        public bool ShowHiddenLinks { get; set; }
    }
}