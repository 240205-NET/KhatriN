using System;

namespace EmployeeMgmt
{
    class ManagementApp {
        static void Main(){
            Company company = new Company();
            Console.WriteLine("Employee Management System is Started");
            // Manager m = new Manager();
            // m.createEmployee();
            Menu(company);
        }

        static void Menu(Company company){
            bool loop = true;
            string?welcomeLine;
             string? inputLogin;
             bool? login;
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
                        company.createManagers();
                        break;
                        
                    case "2":
                        company.createAssociate();
                        break;
                    case "3":
                        Console.WriteLine("Enter Manager Username to Login:");
                        inputLogin = Console.ReadLine();
                         login = company.checkManagerLogin(inputLogin);
                        if(login==true){
                            Menu2(inputLogin);
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
                       }else{
                        Console.WriteLine("Login Invalid");
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
            Company c = new Company();
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
                    
                    c.createTask(username);
                    break;
                case "2":
                    Console.WriteLine("Input 2");
                    break;
                case "3":
                    Console.WriteLine("Input 3");
                    break;
                case "4":
                    Console.WriteLine("Task Details: \n");
                    Console.WriteLine(c.getAllTasksInfo());
                    break;
                default:
                    loop2=false;
                    break;
            }

           }
        }
    }
}
