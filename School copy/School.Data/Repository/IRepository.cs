using School.Logic;

namespace School.Data{
    interface IRepositor{
        //we only list the Method signature, no behaviors of fileds

        public List<Student> GetAllStudent();
        public string MichelsGetTeachersInfo();
        public Student GetStudentById(int id);
        public void NabinsAddStudent();
    }
}