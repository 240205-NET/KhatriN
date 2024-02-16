using System;
using System.Data.SqlClient;
using System.Text;
using School.Logic;
using System.Linq;

namespace School.App
{
    class School
    {
        // Fields
        private List<Student> _students;
        private List<Teacher> _teachers;
        private List<Course> _courses;
        private List<Class> _classes;
        Student student;
        
        
        //using SqlConnection connection;
        // Constructor
        public School()
        {
            this._students = new List<Student>();
            this._teachers = new List<Teacher>();
            this._courses = new List<Course>();
            this._classes = new List<Class>();
            this.student = new Student();
            //this.connection = new SqlConnection(connectionString);
        
            // _students.Add(new Student( "New Guy", "guy@no.com", "1500 Pen. Ave", "", "Washington", "DC", "12345"));
            // _teachers.Add(new Teacher(14, 75000, "Science", "Someone New", "new.teach@no.com", "Somewhere", "", "NYC", "NY", "12345"));
        }

        // Methods

        public void AddStudent(){
        string connectionString = "./../../ConnectionString";
        using SqlConnection connection = new SqlConnection(connectionString);
            try{
                connection.Open();
                this.student =  new Student("New Guy", "guy@no.com", "1500 Pen. Ave", "apt 1", "Washington", "DC", 12345,4.4);
                string query1 = "INSERT INTO [School].[Students] (name, email, address1, address2, city, state, zip, GPA) VALUES(@id, @name,@email,@address1, @address2,@city,@state, @zip, @GPA)";
                using SqlCommand cmd1 = new SqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("@id",this.student.studentId);
                cmd1.Parameters.AddWithValue("@name",this.student.name);
                cmd1.Parameters.AddWithValue("@email",this.student.email);
                cmd1.Parameters.AddWithValue("@address1",this.student.address1);
                cmd1.Parameters.AddWithValue("@address2",this.student.address2);
                cmd1.Parameters.AddWithValue("@city",this.student.city);
                cmd1.Parameters.AddWithValue("@state",this.student.state);
                cmd1.Parameters.AddWithValue("@zip",this.student.zip);
                cmd1.Parameters.AddWithValue("@GPA",this.student.gpa);
                cmd1.ExecuteNonQuery();
                connection.Close();
            }catch(Exception e){
                Console.WriteLine("Error on Database "+ e.Message);
                connection.Close();
            }
        }
        public void getAllStudentFromDb(){
            // try{
            //     connection.Open();
            //     string query2 = "SELECT * FROM [School].[Students]";
            //     SqlCommand cmd = new SqlCommand(query2, connection);
            //     SqlDataReader reader = cmd.ExecuteReader();
            //     List<student> resultStudent = new List<Student>();
            // }catch(Exception e){
            //     Console.WriteLine(e.Message);
            // }
        }
        public Student GetStudent(int studentId)
        {
            /* a list is indexed
                a dictionary is not indexed, but is pairs (entries and keys)
                you can look up an entry by the key. the Key MUST be unique within the dictionary
            */
            
            var result = from stu in _students 
                                        where stu.studentId==studentId
                                        select stu;
           
            return result.FirstOrDefault();
            // Only returns the FIRST instance that matches
            // foreach( Student s in _students)
            // {
            //     if (s.studentId == studentId)
            //     {
            //         return s;
            //     }
            // }

            // return new Student();

            /*
            // returns ALL possible instances that match
            List<Student> result = new List<Student>();
            foreach( Student s in _students)
            {
                if (s.studentId == studentId)
                {
                    result.Add(s);
                }
            }
            return result;
            */

            // List.IndexOf() - searches the list and returns the index of the entry that matches the object sent as a parameter.
            // this method would require a not-insignificant rewrite of our Student class.

            // LINQ (Lin-Que) is all about sorting and filtering
        }

        public List<Student> GetStudents()
        {
            return _students;
        }

        public List<Teacher> GetTeachers()
        {
            return _teachers;
        }

        public string GetStudentsInfo()
        {
            var sb = new StringBuilder();
            foreach(Student s in _students)
            {
                sb.AppendLine(s.ToString());
            }
            return sb.ToString();
        }

        public string GetTeachersInfo()
        {
            var sb = new StringBuilder();
            foreach(Teacher t in _teachers)
            {
                sb.AppendLine(t.ToString());
            }
            return sb.ToString();
        }
    }
}