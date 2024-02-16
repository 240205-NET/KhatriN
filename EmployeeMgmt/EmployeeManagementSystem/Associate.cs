using System;


namespace EmployeeMgmt{

    //Child class of Employee
    public class Associate : Employee {
        
        //fields
        public string associateId{get; set;}
        public string username {get; set;}
        private static int associateSeedId = 123;
        public double salary {get; set;}
        public DateTime startDate {get; set;}
        string path = @"/Associate.txt";
        

    // constructor
        public Associate(){
        }
        public Associate(string name, string email, string address, string city, string state, string zip, 
        string officeLocation, string department, double salary, DateTime startDate, string username)
        {
            this.associateId = $"ASSOC {associateSeedId.ToString()}";
            associateSeedId++;
            Console.WriteLine("i am here in value construct");
            Console.WriteLine($"name:{name}");
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

        // methods
        // public override void createEmployee(object e){
        public override string ToString(){
            return $"{this.associateId}\n{this.name}\n{this.email}\n{this.address}\n{this.city}\n{this.state}\n{this.zip}\n{this.officeLocation}\n{this.department}\n{this.salary}\n{this.startDate}\n{this.username}";
        }
    }
}