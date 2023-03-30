using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollMultithreading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee payroll multithreading problem");
            List<EmployeeDetails> employeedetails = new List<EmployeeDetails>();
            employeedetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "Ayushi", phoneNumber: "9658745632", address: "asdfgh", department: "IT", gender: 'F', basicPay: 769658, taxablePay: 662, tax: 6626, netPay: 562, city: "Ayodhya", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 2, employeeName: "Swati", phoneNumber: "9856478856", address: "asdfgh", department: "Development", gender: 'F', basicPay: 769658, taxablePay: 662, tax: 6626, netPay: 562, city: "Ayodhya", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 3, employeeName: "Anjuli", phoneNumber: "8965746635", address: "asdfgh", department: "HR", gender: 'F', basicPay: 769658, taxablePay: 662, tax: 6626, netPay: 562, city: "Ayodhya", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 4, employeeName: "Raju", phoneNumber: "7854695236", address: "asdfgh", department: "Legal", gender: 'M', basicPay: 769658, taxablePay: 662, tax: 6626, netPay: 562, city: "Ayodhya", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 5, employeeName: "Vasu", phoneNumber: "8745695325", address: "asdfgh", department: "Finance", gender: 'M', basicPay: 769658, taxablePay: 662, tax: 6626, netPay: 562, city: "Ayodhya", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 6, employeeName: "Anjali", phoneNumber: "7456985632", address: "asdfgh", department: "Marketing", gender: 'F', basicPay: 769658, taxablePay: 662, tax: 6626, netPay: 562, city: "Ayodhya", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 7, employeeName: "Priyanshi", phoneNumber: "5698541236", address: "asdfgh", department: "Testing", gender: 'F', basicPay: 769658, taxablePay: 662, tax: 6626, netPay: 562, city: "Ayodhya", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 8, employeeName: "Archi", phoneNumber: "6985478563", address: "asdfgh", department: "Maintainence", gender: 'F', basicPay: 234343, taxablePay: 662, tax: 6626, netPay: 562, city: "Ayodhya", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 9, employeeName: "Sakshi", phoneNumber: "8965745632", address: "asdfgh", department: "Advisory", gender: 'F', basicPay: 234343, taxablePay: 662, tax: 6626, netPay: 562, city: "Delhi", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 10, employeeName: "Aryan", phoneNumber: "4569856332", address: "asdfgh", department: "HR", gender: 'M', basicPay: 234343, taxablePay: 662, tax: 6626, netPay: 562, city: "Delhie", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 11, employeeName: "Arpit", phoneNumber: "58896445632", address: "asdfgh", department: "HR", gender: 'M', basicPay: 234343, taxablePay: 662, tax: 6626, netPay: 562, city: "Delhi", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 12, employeeName: "Krishna", phoneNumber: "8796541236", address: "asdfgh", department: "IT", gender: 'M', basicPay: 234343, taxablePay: 662, tax: 6626, netPay: 562, city: "Delhi", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 13, employeeName: "Neha", phoneNumber: "9632587412", address: "asdfgh", department: "Testing", gender: 'F', basicPay: 234343, taxablePay: 662, tax: 6626, netPay: 562, city: "Delhi", country: "India"));
            employeedetails.Add(new EmployeeDetails(employeeID: 14, employeeName: "Nidhi", phoneNumber: "7412589635", address: "asdfgh", department: "Maintainence", gender: 'F', basicPay: 234343, taxablePay: 662, tax: 6626, netPay: 562, city: "Delhi", country: "India"));
            EmployeePayrollOperations employeePayRollOperation = new EmployeePayrollOperations();
            DateTime startdateTime = DateTime.Now;
            employeePayRollOperation.AddEmployeePayRoll(employeedetails);
            DateTime stopdateTime = DateTime.Now;
            Console.WriteLine("Duation without thread" + (stopdateTime - startdateTime));
            Console.ReadLine();
        }
    }
}
