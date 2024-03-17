using System;

namespace EmployeeMgmt
{
    class ManagementApp {
        static void Main(){
            Company company = new Company();
            Console.WriteLine("\n\nEmployee Management System is Started\n");
            // Manager m = new Manager();
            // m.createEmployee();
            Menu(company);
        }
        static void Menu(Company company){

        string name;
        string email;
        string address;
        string city;
        string state;
        string zip;
        string officeLocation;
        string department;
        double salary=0.0;
        DateTime startDate;
        string username;
        bool checkIfExists=false;
            bool loop = true;
            string?welcomeLine;
             string? inputLogin;
             bool? login;
            while(loop){
                welcomeLine = "Employee Management System";
                Console.WriteLine("\n===>----" + welcomeLine.ToUpper() + "<====----\n");
                Console.WriteLine("Enter 1 to Create Manager Account");
                Console.WriteLine("Enter 2 to Create Associate Account");
                Console.WriteLine("Enter 3 to Login As Manager");
                Console.WriteLine("Enter 4 to Login As Associate");
                Console.WriteLine("Enter 5 to Retreive all Associate List");
                Console.WriteLine("Enter 0 to Exit");
                string? input = Console.ReadLine();
                switch(input){
                    case "1":
                        Console.WriteLine("\n*****---***Create Manager Profile***---*****\n");
                        Console.WriteLine("Enter New Manager Namee: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Create Username: ");
                        username = Console.ReadLine();
                        while(company.checkManagerExistsByUsername(username)){
                            Console.WriteLine("username already taken!!");
                            Console.WriteLine("Enter Unique Username");
                            username = Console.ReadLine();
                        }
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
                        while(false){
                            
                        }
                        try{
                            salary=Double.Parse(Console.ReadLine());
                        }catch(Exception e){
                            Console.WriteLine($"Salary Should be in Numbers {e.Message}");
                            Console.WriteLine("Start Again..... :( ");
                            return;
                        }
                        startDate = DateTime.Now;
                        Manager m = new Manager(name, email, address, city, state, zip, officeLocation,  department,  salary,  startDate, username);
                        company.createManagers(m);
                        break;
                        
                    case "2":
                        Console.WriteLine("*****---***Create Associate Profile***---*****\n");
                        Console.WriteLine("Enter New Associate Namee: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Create New Username : ");
                        username = Console.ReadLine();
                        while(company.checkAssociateExistsByUsername(username)){
                            Console.WriteLine("Associate Exists..Choose New Username");
                            username = Console.ReadLine();
                        }
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
                        try{
                            salary=Double.Parse(Console.ReadLine());
                        }catch(Exception e){
                            Console.WriteLine($"Salary Should be in Numbers {e.Message}");
                            Console.WriteLine("Start Again..... :( ");
                            return;
                        }
                        Console.WriteLine($"{salary} salary");
                        startDate = DateTime.Now;
                        Associate a = new Associate();
                        try{
                             a = new Associate(name, email, address, city, state, zip, officeLocation, department,  salary,  startDate, username);
                        }catch(Exception e){
                            Console.WriteLine($"Error occurs:  {e.Message}");
                        }
                        company.createAssociates(a);
                        break;
                    case "3":
                        Console.WriteLine("Enter Manager Username to Login:");
                        inputLogin = Console.ReadLine();
                         login = company.checkManagerLogin(inputLogin);
                        if(login==true){
                            Menu2(inputLogin, company);
                        }else{
                            Console.WriteLine("Login Invalid");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter Associate Username to Login:");
                        inputLogin = Console.ReadLine();
                         login = company.checkAssociateLogin(inputLogin);
                       if(login == true){
                        Console.WriteLine("Associate Login successful");
                        Menu3(inputLogin, company);
                       }else{
                        Console.WriteLine("Login Invalid");
                       }
                        break;
                    case "5":
                        Console.WriteLine("Associate Listed: \n");
                        Console.WriteLine($"{company.getAssociateInfo()}\n");
                        // Console.WriteLine("Associate by Username onluy");
                        // Console.WriteLine(company.getUsernameOfAssociateInfo());
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

        static void Menu2(string username, Company c){
            bool loop2=true;
            
           while(loop2){
            Console.WriteLine("Enter 1 to Create Task");
            // Console.WriteLine("Enter 2 to Assign Task");
            // Console.WriteLine("Enter 3 to Verify the Task");
            Console.WriteLine("Enter 2 to List all Tasks");
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
                    // DateTime dueDate = DateTime.Parse(date);
                    DateTime dueDate;
                    if(DateTime.TryParse(date, out dueDate)){
                       dueDate;
                    }else{
                        Console.WriteLine("Invalid Date Input");
                        return;
                    }
                    Console.WriteLine("Enter Associate Username From List:");
                    //List all associate username only
                    Console.WriteLine($"{c.getUsernameOfAssociateInfo().ToString()}\n");
                    while(c.getUsernameOfAssociateInfo().Length<=0){
                        Console.WriteLine("Associate List is Empty");
                        Console.WriteLine("Create Few Associate First");
                        return;
                    }
                    string assignedTo = Console.ReadLine();
                    string assignedBy = username;
                    Console.WriteLine("Select Task Status");
                    Console.WriteLine("Select 1 to Assign");
                    Console.WriteLine("Select 2 to Complete");
                    int i = 0;
                    string status="";
                    try{
                    i=Int32.Parse(Console.ReadLine());
                    if(i==1){
                        status = "pending";
                    }else if(i==2){
                        status="complete";
                    }else{
                        status="reject";
                        Console.WriteLine("Enter Number from Menu");
                    }
                    }catch(Exception e){
                        Console.WriteLine("Enter Number only" + e.Message);
                    }
                    Task t = new Task( title, description, dueDate,  assignedBy, assignedTo, status);
                    c.createTask(t, username);
                    break;
                case "2":
                    Console.WriteLine("Task Details: \n");
                    Console.WriteLine(c.getAllTasksInfo());
                    break;
                default:
                    loop2=false;
                    break;
            }

           }
        }

        //Menu After Associate login successful
        static void Menu3(string username, Company c){
            bool loop3=true;
            while(loop3){
            Console.WriteLine("Enter 1 to List all Tasks");
            Console.WriteLine("Enter 2 to Accept Task");//change the task status to processing and add description
            Console.WriteLine("Enter 0 to exit");
            string inputNum = Console.ReadLine();
            switch(inputNum){
                case "1":
                    //list employee to assign task
                    // entertask
                    Console.WriteLine(c.listTaskByUsername(username));
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Input 2");
                    c.ModifyTaskByAssociate(username);
                    break;

                default:
                    loop3=false;
                    break;
            }

           }
        }
    }
}
