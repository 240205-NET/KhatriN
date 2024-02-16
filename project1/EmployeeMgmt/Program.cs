using System;

namespace EmployeeMgmt {
    class ManagementSystem{
        //public static bool loop = true;
         static void Main(){
            //Menu to Load Record
            
        Manager m = new Manager();
           
           
            m.createEmployee();
           // Menu(s);
        }

        //public static void Menu(Student s){
        /*
             public static void Menu(){
            while(loop){
                Console.WriteLine("\n *********====>> Welcome To Student Management System <<====********* \n");
                Console.WriteLine("Input 1 to Create Student Information");
                Console.WriteLine("Input 2 to Read Studnet Information");
                string inputString = Console.ReadLine();
                switch(inputString){
                    case "1":
                        Console.WriteLine("You are Ready to Write Student Record");
                        Console.WriteLine("Enter Student First Name: ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("Enter Student Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Enter Student Grade: ");
                        string grade = Console.ReadLine();

                       // string[] fullname = firstName.Concat(lastName).ToArray();
                        //s.CreateStudentRecord(firstName, lastName, grade);
                        break;
                    case "2":
                        Console.WriteLine("You are Ready to  Read Student Record");
                        break;
                    default:
                        loop=false;
                        Console.WriteLine("You will be Exited from System");
                        break;
                }
            
            }
        }
        */
    }

}
