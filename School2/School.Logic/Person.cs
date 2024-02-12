using System;

namespace School.Logic 
{
    abstract class Person {
        //Fields
        public string name;
        public string email;
        public string address1;
        public string address2;
        public string city;
        public string  state;
        public string  zip;
        // No need of a constructer!!
        //  Its abstract, You can't buld one, so we don't need to define how to build one!


        //Methods
        public abstract string ToString();

    }
}
 // Persons - base/parent class(Abstract Class)
                // Name
                // Email
                // Address