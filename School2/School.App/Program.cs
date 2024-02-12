using System;

namespace School.App {
    class Program {
        static void Main(){
           
           Console.WriteLine("School Starting....");

           try{
             School mySchool = new School();
             Console.WriteLine(mySchool.GetStudentsInfo());
             Console.WriteLine(mySchool.GetTeachersInfo());
             Console.WriteLine("Student Info:");
             Console.WriteLine(mySchool.GetStudent());

           }catch(Exception e){
                Console.WriteLine(e.Message);
           }


           Console.WriteLine("Schools Ending.....");
            

        }
    }
}

// Persons - base/parent class(Abstract Class)
                // Name
                // Email
                // Address
                
                //Students - child(derived) class of person
                    // Schedule
                    // GPA
                    //Grades
                
                //Teachers - child class of person class
                    // Office #
                    // Salary
                    // Subject

        // Courses : Parent Class
            // courseId
            // Name
            // Department
            // Requirements
            // Credit Hours


        // Classes : child of courses
                // Location
                // Schedule
                // Instructor
                // Roster
                // Capacity      
                // Section      
