
namespace School.Logic {

    class Course {
        //Fields
        public string id;
        public string name;
        public string department;
        public int creditHours;
        public List<string> requirements;
        private static int idSeed =1;

        //constructor
        /// <summary>
        /// Constructor method for the Course object type.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="department"></param>
        /// <param name="creditHours"></param>
        public Course(string name, string department, int creditHours){
            this.name=name;
            this.department=department;
            this.creditHours=creditHours;
            this.id=department.Substring(0,3) + idSeed.ToString(); //substring first arg is beginning index and second arg is the number of character from the first given arg
            idSeed++;
        }

        //Methods


    }
}