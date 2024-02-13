using System;

namespace School.Logic
{
    /*Acces Modifiers
        private //is default in C#
        -public
        -protected
        -internal
    */
    class Class
    {
        // Fields
        int Id;
        DateTime startDate;
        List<Student> students;
        Teacher instructor;
        Course course;
        int capacity;
        int roomNum;
        private static int idSeed = 1;


        // Constructors
        public Class(DateTime startDate, Teacher instructor, Course course, int capacity, int roomNum)
        {
            this.Id = idSeed;
            idSeed++;
            this.startDate= startDate;
            this.students = new List<Student>();
            this.instructor = instructor;
            this.course = course;
            this.capacity = capacity;
            this.roomNum = roomNum;
        }

        // Methods
    }
}