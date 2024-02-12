using System;

namespace School.App {
    class Teacher : Person {
        // Fields
        public int office {get; set;}
        public double salary {get; set;}

        public string subject {get; set;}

        // Constructor
        public Teacher(int office, double salary, string subject, string name, string email, string address1,
        string address2, string state, string city, string zip){
            this.office = office;
            this.salary = salary;
            this.subject = subject;
            this.name = name;
            this.email = email;
            this.address1 = address1;
            this.address2 = address2;
            this.state = state;
            this.city = city;
            this.zip = zip;
        }

        // Methods
    }

    //Teachers - child class of person class
                    // Office #
                    // Salary
                    // Subject

}