using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollMultithreading
{
    public class EmployeePayrollOperations
    {
        public List<EmployeeDetails> employeedetails = new List<EmployeeDetails>();
        public List<EmployeeDetails> employeedetailsNewList=new List<EmployeeDetails>();

        public List<EmployeeDetails> AddEmployeePayRoll(List<EmployeeDetails> employeedataList)
        {
            employeedataList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                employeedetailsNewList=this.AddedEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee added : " + employeeData.EmployeeName);
            });
            return employeedetailsNewList;
        }
        public List<EmployeeDetails> AddedEmployeeToPayroll(EmployeeDetails emp)
        {
            employeedetails.Add(emp);
            return employeedetails;
        }
    }
}
