using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using is290_project_1.Models;

namespace is290_project_1.Custom
{
    public class CustomClass
    {
        public void GetNumberOfEmps()
        {
            Employee employeeModel = new Employee();

            int count = 0;

            foreach (var employee in Convert.ToString(employeeModel))
            {
                count++;
            }

            Console.Write(count.ToString());
        }
    }
}