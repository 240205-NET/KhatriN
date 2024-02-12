using System;

namespace EmployeeMgmt{

    class Associate : Employee // this is derived class of  Employee
    {
    //fields

        public string associateId{get; set;}
        private static int associateSeedId = 123;
        public double salary {get; set;}
        public DateTime startDate {get; set;}
        string path = "@.Associate.txt";

    // constructor
     public Associate(){}
        public Associate(string name, string email, string address, string city, string state, string zip, 
        string officeLocation, string department, double salary, DateTime startDate, string username){
            this.associateId = "ASSOC"+associateId.ToString();
            associateSeedId++;
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
    public override void createEmployeeFile(){
            //check what kind of employee account is being created ex:- Manager or Associate
            // Also here i need to check if such employee exists or not if exists do not create account 
                //only let them to change the other values except their ID

         Console.WriteLine("Employee Details");
        string[] associateLists = {
                                this.name, this.email,
                                this.address, this.city, this.state, this.zip, 
                                this.officeLocation, this.department, (this.salary).ToString(), 
                                (this.startDate).ToString(), this.username
                                };
        if(File.Exists(path)){
            Console.WriteLine("Already Exists");
        }else{
            File.WriteAllLines(path,associateLists);
        }
                
    }

        public override bool loginEmployee(int associateId){
            //here check associate exists or not
            return true;
        }

        public string viewAssignTask(){
            return "";
        }

        

    // we need separate location to save associate data and manager data
    // assoicate can accept tasks
    // complete task
    }
}