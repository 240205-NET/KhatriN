using System;

namespace EmployeeMgmt {
    abstract class Employee {
        //Fields
        public string name;
        public string email;
        public string address;
        public string city;
        public string state;
        public string zip;
        public string officeLocation;
        public string department;


        //Constructor

        //methods
         public abstract void createEmployee(); 
        

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
}