using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using LearnMVC7Days.DataAccessLayer;

namespace LearnMVC7Days.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }
    }
}