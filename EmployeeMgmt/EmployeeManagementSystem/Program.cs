using System;

namespace EmployeeMgmt
{
    class ManagementApp {
        static void Main(){
            Console.WriteLine("Employee Management System is Started");
            // Manager m = new Manager();
            // m.createEmployee();
            Menu();
        }

        static void Menu(){
            Manager m = new Manager();
            Associate assoc = new Associate();
            bool loop = true;
            List<Manager> allManager = new List<Manager>();
            List<Associate> allAssociate = new List<Associate>();
            
            string inputLogin="";
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
            string?welcomeLine;
            string? username;

            while(loop){
                welcomeLine = "Employee Management System";
                Console.WriteLine("===>----" + welcomeLine.ToUpper() + "<====----");
                Console.WriteLine("Enter 1 to Create Manager Account");
                Console.WriteLine("Enter 2 to Create Associate Account");
                Console.WriteLine("Enter 3 to Login As Manager");
                Console.WriteLine("Enter 4 to Login As Associate");
                Console.WriteLine("Enter 0 to Exit");
                string? input = Console.ReadLine();
                switch(input){
                    case "1":
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
                        Manager manager = new Manager(name, email, address, city,  state, zip, officeLocation,  department,  salary,  startDate, username);
                        allManager.Add(manager);
                        manager.createEmployeeFile();
                        break;
                        
                    case "2":
                        Console.WriteLine("*****---***Create Associate Profile***---*****\n");
                        Console.WriteLine("Enter New Associate Namee: ");
                        name = Console.ReadLine();
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
                        Associate associate = new Associate(name, email, address, city,  state, zip, officeLocation,  department,  salary,  startDate);
                        allAssociate.Add(associate);
                        assoc.createEmployeeFile();
                        break;
                        //string associateId = "ASSOC"+associateId.ToString();
                        // Console.WriteLine(name + " " + salary + " " + startDate);
                        //associateSeedId++;
                    case "3":
                        Console.WriteLine("Enter Manager Username to Login:");
                        inputLogin = Console.ReadLine();
                        //bool checkLogin =  m.loginEmployee(Int32.Parse(inputLogin));
                        bool checkLogin = false;
                        foreach(Manager man in allManager){
                            if(inputLogin==man.username){
                                //condition check to create task
                               checkLogin = true;
                            }
                            if(checkLogin==true){
                                 Menu2(inputLogin); //inputLogin is the unique username
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter Associate Username to Login:");
                        inputLogin = Console.ReadLine();
                        bool inputMatch = false;
                        foreach(Associate assoc in allAssociate){
                            if(inputLogin==assoc.username){
                                inputMatch=true;
                            }
                            if(inputMatch=true){
                                Menu3()//Menu to View/Edit Task
                            }
                        }
                        break;
                    case "0":
                        loop=false;
                        break;
                    default:
                        loop = false;
                        break;
                }
            }
        }

        static void Menu2(string username){
            bool loop2=true;
            Manager m = new Manager();
           while(loop2){
            Console.WriteLine("Enter 1 to Create Task");
            Console.WriteLine("Enter 2 to Assign Task");
            Console.WriteLine("Enter 3 to Verify the Task");
            Console.WriteLine("Enter 4 to List all Tasks");
            Console.WriteLine("Enter 0 to exit");
            string inputNum = Console.ReadLine();
            switch(inputNum){
                case "1":
                    //list employee to assign task
                    // entertask
                    Console.WriteLine("Enter Task Title");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter Task Description");
                    string description = Console.ReadLine();
                    Console.WriteLine("Enter Valid Due Date (mm/dd/yyyy):");
                    string date = Console.ReadLine(); 
                    DateTime dueDate = DateTime.Parse(date);
                    Console.WriteLine("Enter Associate Id to Assign Task");
                    string assignedTo = Console.ReadLine();
                    string assignedBy = managerId;
                    Console.WriteLine("Enter Task Status");
                    string status = Console.ReadLine();
                    Task t = new Task( title,  description, dueDate,  assignedBy, assignedTo, status);
                    m.createTask(t);
                    break;
                case "2":
                    Console.WriteLine("Input 2");
                    break;
                case "3":
                    Console.WriteLine("Input 3");
                    break;
                case "4":
                    m.getAllTask();
                    break;
                default:
                    loop2=false;
                    break;
            }

           }
        }
    }
}
