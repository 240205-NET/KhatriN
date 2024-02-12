using System;

namespace EmployeeMgmt 
{
    //Base Class
    abstract class Employee 
    {
        public string name;
        public string email;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string officeLocation;
        public string department;
        public int employeeId;

        //Constructor

        //methods
        //  public abstract void createEmployee(object e); 
         public abstract void createEmployeeFile(); 
        
         public abstract bool loginEmployee(int employeeId);


    }
}

 //Abstract Class Employee - base class
        // name
        // email
        // address
        // city
        //  state
        // zip
    
    // Manager - children class of Employee
        // Level 
        // Department Code
        // Task 
        // Manager Id
        // salary
        // Join Date
        // Office Location

    // Associate - child of Employee
        // level
        // Department Code
        // salary
        // Join Date
        // Office
        // Associate Id
 
    // Task
        // title
        // Description
        // startdate
        // duedate
        // Assigned To - employee by id
        // Assigned By - manager by id