using System;

namespace EmployeeMgmt {
    class Manager : Employee {
        //Fields
        public int managerId{get; set;}
        private static int managerIdSeed = 123;       
        public double salary {get; set;}

        public DateTime startDate {get; set;}
        

        //Constructor
        public Manager(){}
        public Manager(string name, string email, string address, string city, string state, string zip, 
        string officeLocation, string department, double salary, DateTime startDate){
            this.managerId = managerIdSeed;
            managerIdSeed++;
            this.name = name;
            this.email= email;
            this.address=address;
            this.city=city;
            this.state=state;
            this.zip=zip;
            this.officeLocation=officeLocation;
            this.department=department;
            this.salary=salary;
            this.startDate=startDate;
        }

        public override void createEmployee(){
            Console.WriteLine("we are in manager ");
        }

        //

        

        // Manager - children class of Employee
        // Level 
        // Department 
        // Manager Id
        // salary
        // Join Date
        // Office Location
    }
}