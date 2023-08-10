using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Console.Model
{
    public class DataAccessFactory
    {
        public static EmployeeDataAccessLogic GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccessLogic();
        }
    }
}
