using System;

namespace School.App
{
    class Program
    {
        
        static void Main(){
        // To Do Monday:
        // - review the changes (person, student, teacher, course, class, program)
        // - separate concerns (.App/.Logic)
        // - XML commenting
        // - retrieve specific person
        
        //using SqlConnection connection = new SqlConnection(connectionString);
        string path = "./../../ConnectionString";
        string connectionString = File.ReadAllText(path);
        Console.WriteLine(connectionString);
        
            try
            {
                Console.WriteLine("School Starting...");
                Console.WriteLine("Starting Database Connection....");
                //connection.Open();
                School MySchool = new School();
                // Student tmp = MySchool.GetStudent();
                // Console.WriteLine(tmp.name);
                // MySchool.AddStudent();
                Console.WriteLine(MySchool.GetStudentsInfo());
                Console.WriteLine(MySchool.GetTeachersInfo());
                Console.WriteLine("Student Found:");
                Console.WriteLine(MySchool.GetStudent(1).ToString());

                Console.WriteLine("Schoold Ending...");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}