using System;
using System.Text;
namespace EmployeeMgmt {

    //Singleton class to call everything in here and pass it to main
    class Company {
        //Fields
        private List<Manager> allManagers;
        private List<Associate> allAssociates;

        private List<Task> allTasks;
        private Manager manager;
        private Associate associate;
        private Task task;
        private static string managerFilePath="@.Associate.txt";
        private static string associateFilePath = "@.Manager.txt";
     
        string?name;
        string?email;
        string?address;
        string?city;
        string?state;
        string?zip;
        string?officeLocation;
        string?department;
        double salary=0.0;
        DateTime startDate;
        string? username;


        //Constructor
        public Company(){
            this.allManagers = new List<Manager>();
            this.allAssociates = new List<Associate>();
            this.allTasks = new List<Task>();
            this.manager=new Manager();
            this.associate= new Associate();
            this.task = new Task();
        }

        public void createManagers(){
            Console.WriteLine("*****---***Create Manager Profile***---*****\n");
            Console.WriteLine("Enter New Manager Namee: ");
            name = Console.ReadLine();
            Console.WriteLine("Create Username: ");
            username = Console.ReadLine();
            Console.WriteLine("Enter Manager Email : ");
            email = Console.ReadLine();
            Console.WriteLine("Enter Street Address: ");
             address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter State: ");
             state=Console.ReadLine();
            Console.WriteLine("Enter Zip Code: ");
            zip = Console.ReadLine();
            Console.WriteLine("Enter Office Location");
             officeLocation = Console.ReadLine();
            Console.WriteLine("Enter Department");
            department=Console.ReadLine();
            Console.WriteLine("Enter Monthly Salary");
            salary=Double.Parse(Console.ReadLine());
            startDate = DateTime.Now;
            Console.WriteLine("Entered details are: ");
            this.manager = new Manager(name, email, address, city,  state, zip, officeLocation,  department,  salary,  startDate, username);
            allManagers.Add(manager);
            createManagersFile();
        }

        public void createAssociate(){
            Console.WriteLine("*****---***Create Associate Profile***---*****\n");
            Console.WriteLine("Enter New Associate Namee: ");
            name = Console.ReadLine();
            Console.WriteLine("Create New Username : ");
            username = Console.ReadLine();
            Console.WriteLine("Enter Associate Email : ");
            email = Console.ReadLine();
            Console.WriteLine("Enter Street Address: ");
            address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter State: ");
            state=Console.ReadLine();
            Console.WriteLine("Enter Zip Code: ");
            zip = Console.ReadLine();
            Console.WriteLine("Enter Office Location");
            officeLocation = Console.ReadLine();
            Console.WriteLine("Enter Department");
            department=Console.ReadLine();
            Console.WriteLine("Enter Monthly Salary");
            salary=Double.Parse(Console.ReadLine());
            startDate = DateTime.Now;
            Console.WriteLine("Entered details are: ");
            Associate associate = new Associate(name, email, address, city,  state, zip, officeLocation,  department,  salary,  startDate, username);
            allAssociates.Add(associate);
            createAssociatesFile();
        }

        public void createTask(string username){
            Console.WriteLine("Enter Task Title");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Task Description");
            string description = Console.ReadLine();
            Console.WriteLine("Enter Valid Due Date (mm/dd/yyyy):");
            string date = Console.ReadLine(); 
            DateTime dueDate = DateTime.Parse(date);
            Console.WriteLine("Enter Associate Id to Assign Task");
            string assignedTo = Console.ReadLine();
            string assignedBy = username;
            Console.WriteLine("Enter Task Status");
            string status = Console.ReadLine();
            Task t = new Task( title,  description, dueDate,  assignedBy, assignedTo, status);
            allTasks.Add(t);
        }
        // returning to all the class lists starts here ie. for manager,associate and task class
        public List<Manager> getManagers(){
            return allManagers;
        }

        public List<Associate> getAssociates(){
            return allAssociates;
        }
        
        public List<Task> getTasks(){
            return allTasks;
        }
        // returnin as list ends here

        //converting all the lists to string starts here
        public string getManagerInfo(){
            var sb = new StringBuilder();
            foreach(Manager m in allManagers){
                sb.AppendLine(m.ToString());
            }
            return sb.ToString();
        }
        public string getAssociateInfo(){
            var sb = new StringBuilder();
            foreach(Associate a in allAssociates){
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }

        public string getAllTasksInfo(){
            var sb = new StringBuilder();
            foreach(Task task in allTasks){
                sb.AppendLine(task.ToString());
            }
            return sb.ToString();
        }
        //converting all the lists to string ends here

        public void createManagersFile(){
             Console.WriteLine("Employee Details");
            string[] employeeList = {
                                   this.name, this.email,
                                    this.address, this.city, this.state, this.zip, 
                                    this.officeLocation, this.department, (this.salary).ToString(), 
                                    (this.startDate).ToString(), this.username
                                    };
            if(File.Exists(managerFilePath)){
                Console.WriteLine("Already Exists");
            }else{
                File.WriteAllLines(managerFilePath,employeeList);
            }
        }

        public void createAssociatesFile(){
            Console.WriteLine("Employee Details");
            string[] associateLists = {
                                    this.name, this.email,
                                    this.address, this.city, this.state, this.zip, 
                                    this.officeLocation, this.department, (this.salary).ToString(), 
                                    (this.startDate).ToString(), this.username
                                    };
            if(File.Exists(associateFilePath)){
                Console.WriteLine("Already Exists");
            }else{
                File.WriteAllLines(associateFilePath, associateLists);
            }
                
        }

        public bool checkManagerLogin(string username){
            //bool checkLogin =  m.loginEmployee(Int32.Parse(inputLogin));
            bool checkLogin = false;
            foreach(Manager man in allManagers){
                if(username==man.username){
                    //condition check to create task
                    checkLogin = true;
                }
               
                // if(checkLogin==true){
                //         //Menu2(inputLogin); //inputLogin is the unique username
                // }
            }
             return checkLogin;
        }

        public bool checkAssociateLogin(string username){
            bool inputMatch = false;
            foreach(Associate asc in allAssociates){
                if(username==asc.username){
                    inputMatch=true;
                }
                // if(inputMatch=true){
                //     //  Menu3();//Menu to View/Edit Task
                // }
            }
            return inputMatch;
        }
    }
}