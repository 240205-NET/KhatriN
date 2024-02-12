using System;
using System.IO;
using System.Xml.Serialization;

namespace EmployeeMgmt 
 
{
     class Student{
        //fields
        /*
        student Id
        student firstname
        lastname
        grade
        address
        */
        public int studentId { get; set;}
        public string fName {get; set;}
        public string lName {get; set;}
        public string grade {get; set;}
        public string address {get; set;}

        private static int studentIdSeed = 123;

        public Student(){}

        public static string path = @"./StudentRecord.txt";

        public Student(string fName, string lName, string grade, string address){
            this.studentId = studentIdSeed;
            studentIdSeed++;
            this.fName=fName;
            this.lName=lName;
            this.grade=grade;
            this.address=address;
        }

        public virtual void CreateStudentRecord(string fName, string lName, string grade){
            string[] studentInfo = {fName, lName, grade};
             // string[] arr = arr1.Concat(arr2).ToArray(); // this line will concat two array
            if(File.Exists(path)){
                Console.WriteLine("File Exists");
                string[] readText = File.ReadAllLines(path);
                //Here we can check if the student with that student id exists or not by reading from file
                //only Unique student should be recorded
                Console.WriteLine("\n\n Student Info is: "\n);
                Console.WriteLine("First Name")
                foreach(string s in readText ){
                    Console.WriteLine(s);
                }
            }else{
                File.WriteAllLines(path, studentInfo);
            }
            

            
        }
    }
}