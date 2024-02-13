using System;

namespace EmployeeMgmt 
{
    // Childclass
    class Manager : Employee {
        //Field
        public string managerId{get; set;}

        public string username{get; set;}
        private static int managerSeedId = 123;
        public double salary {get; set;}
        public DateTime startDate {get; set;}

        private List<Task> listAllTask = new List<Task>();
        private List<string> listManagers = new List<string>();
        string path = @"\.ManagerData.txt";
        List<object> listAllManager = new List<object>();


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
            return "";
        }
        // public override void createEmployee(object M){
        public void createEmployeeFile(){
        //    string[] obj = {this.name, this.email,
        //                         this.address, this.city, this.state, this.zip, 
        //                             this.officeLocation, this.department, (this.salary).ToString(), 
        //                             (this.startDate).ToString(), this.username};
        //     listAllManager.Add(obj);
            Console.WriteLine("Employee Details");
            string[] employeeList = {
                                   this.name, this.email,
                                    this.address, this.city, this.state, this.zip, 
                                    this.officeLocation, this.department, (this.salary).ToString(), 
                                    (this.startDate).ToString(), this.username
                                    };
            if(File.Exists(path)){
                Console.WriteLine("Already Exists");
            }else{
                File.WriteAllLines(path,employeeList);
            }
            
            //check what kind of employee account is being created ex:- Manager or Associate

             // Also here i need to check if such employee exists or not if exists do not create account 
                //only let them to change the other values except their ID
                
                // listManagers.Add();
                //managerSeedId++;
        }

        public override bool loginEmployee(int inputLogin){
            bool checkLogin = false;

            // foreach(object man in listAllManager){
            //     if(inputLogin==man.username){
            //         //condition check to create task
            //         checkLogin = true;
            //     }
            //     if(checkLogin==true){
            //             //Menu2(inputLogin);
            //     }
            // }
            // Console.WriteLine("Login ");
            return true;
        }

        public void createTask(Task t){
           listAllTask.Add(t);
        }

        public void getAllTask(){
            foreach(Task s in listAllTask){
                Console.WriteLine(s.title);
            }
        }

        

        //Methods
        //  Managers should be able to create new tasks
        // Assigns to associate

        // Accept/review tasks
    }

    
}

 // Manager - children class of Employee
        // Level 
        // Department Code
        // Task 
        // Manager Id
        // salary
        // Join Date
        // Office Location