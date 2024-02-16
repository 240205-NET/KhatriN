using System;

namespace EmployeeMgmt 
{
    //Base Class
    public abstract class Employee 
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
         public abstract string ToString();
    }
}

