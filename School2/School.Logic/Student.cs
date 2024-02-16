using System;
namespace School.Logic{
     public class Student : Person {
         //Students - child(derived) class of person
                    // Schedule
                    // GPA
                    //Grades
        // fields
        public double gpa {get; set;} = 0.0;
        public int studentId (get;) //since no need to update id no need of setter here
        private static int idSeed=1;
        // constructor
        public Student(string name, string email, string address1,
        string address2, string state, string city, string zip){
            this.name = name;
            this.email = email;
            this.address1= address1;
            this.address2=address2;
            this.state=state;
            this.city=city;
            this.zip=zip;
            this.studentId=idSeed;
            idSeed++;
            
        }
        
    }
    public override string ToString()
        {
            return $"Student\nName: {this.name}\nGPA: {this.gpa}\nEmail: {this.email}\nAddress:\n{this.address1}\n{this.address2}\n{this.city} {this.state}, {this.zip}\n";
        }
}