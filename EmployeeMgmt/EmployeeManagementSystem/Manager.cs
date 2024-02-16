using System;
using System.Xml.Serialization;

namespace EmployeeMgmt 
{
    // Childclass
    public class Manager : Employee {
        //Field
        public string managerId{get; set;}

        public string username{get; set;}
        private static int managerSeedId = 123;
        public double salary {get; set;}
        public DateTime startDate {get; set;}
        string path = @"/ManagerData.txt";
        // private XmlSerializer Serializer = new XmlSerializer(typeof(Manager));
        //constructor
         public Manager(){}
        public Manager(string name, string email, string address, string city, string state, string zip, 
        string officeLocation, string department, double salary, DateTime startDate, string username){
            this.managerId = "MGR"+managerSeedId.ToString();
            managerSeedId++;
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
            this.username=username;
        }
        //Methods

        public override string ToString(){
            return $"{this.managerId}\n{this.name}\n{this.email}\n{this.address}\n{this.city}\n{this.state}\n{this.zip}\n{this.officeLocation}\n{this.department}\n{this.salary}\n{this.startDate}\n{this.username}";
        }

    }
}
