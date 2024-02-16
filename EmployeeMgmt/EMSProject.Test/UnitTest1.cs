using System;
using EmployeeMgmt;

namespace EMSProject.Test{
    
    public class UnitTest1
    {
        [Fact]
        public void TestCreateManager()
        {   
            Manager data = new Manager("Nabin","sub@g.com","add1","city","ny","27560","Raleigh", "IT", 1200.0, DateTime.Now,"nabin123");
            string actualName = "Nabin";
            Assert.Equal(data.name, actualName);
        }

        [Fact]
        public void TestManagerCreationThrowsErrorOrNot(){
            Company c = new Company();
            Manager data = new Manager("Nabin","sub@g.com","add1","city","ny","27560","Raleigh", "IT", 1200.0, DateTime.Now,"nabin123");
            try{
                c.createManagers(data);
                Assert.True(true);
            }catch(Exception e){
                Assert.False(true);
            }
        }

        [Fact]
        public void TestCreatingManagerUniqueUsername(){
            //check if usernameof manager exists
            Company c = new Company();
            Manager data = new Manager("Nabin","sub@g.com","add1","city","ny","27560","Raleigh", "IT", 1200.0, DateTime.Now,"nabin123");
            string newUsername = "nabin123";
            bool actual = c.checkManagerExistsByUsername(newUsername);
            Assert.False(actual);  
            
        }

        [Fact]
        public void TestCreateAssociate(){
            Associate expectedData = new Associate("user1","sub@g.com","add1","city","ny","27560","Raleigh", "IT", 1200.0, DateTime.Now,"user11");
            string actualName = "user1";
            Assert.Equal(expectedData.name, actualName);
        }

        [Fact]
        public void TestAssociateUniqueUsername(){
            //check if usernameof manager exists
            Company c = new Company();
            Associate data = new Associate("user1","sub@g.com","add1","city","ny","27560","Raleigh", "IT", 1200.0, DateTime.Now,"nabin123");
            string newUsername = "user11";
            bool actual = c.checkAssociateExistsByUsername(newUsername);
            Assert.False(actual);  
        }
        [Fact]
        public void checkManagerUsernameMethodType(){
            Company c = new Company();
            Manager data = new Manager("Nabin","sub@g.com","add1","city","ny","27560","Raleigh", "IT", 1200.0, DateTime.Now,"nabin123");
            string inputUsername = "nabin123";
            var actual = c.checkAssociateExistsByUsername(inputUsername);
            Assert.IsType<bool>(actual);
        }

        [Fact]
        public void checkAssociateUsernameMethodType(){
            Company c = new Company();
            Associate data = new Associate("user1","sub@g.com","add1","city","ny","27560","Raleigh", "IT", 1200.0, DateTime.Now,"nabin123");
            string inputUsername = "user11";
            var actual = c.checkAssociateExistsByUsername(inputUsername);
            Assert.IsType<bool>(actual);
        }

        [Fact]
        public void TestSerializeManagerDataToxml(){
            Company c = new Company();
            Manager data = new Manager("Nabin","sub@g.com","add1","city","ny","27560","Raleigh", "IT", 1200.0, DateTime.Now,"nabin123");
            try{
                c.WriteSerializeXmlToFile(data);
                Assert.True(true);
            }catch(Exception e){
                Assert.False(true);
            }
        
        }
        [Fact]
        public void TestSerializeAssociateDataToxml(){
            Company c = new Company();
            Associate data = new Associate("user1","sub@g.com","add1","city","ny","27560","Raleigh", "IT", 100.0, DateTime.Now,"user11");
            try{
                c.WriteSerializeXmlToFile(data);
                Assert.True(true);
            }catch(Exception e){
                Assert.False(true);
            }
        
        }

        [Fact]
        public  void TestCreateTask(){
             string dateInput = "Mar 4, 2024";
            EmployeeMgmt.Task task = new EmployeeMgmt.Task("task 1","task description", DateTime.Parse(dateInput), "nabin123", "user11","pending");
            string expectedTaskname = "task 1";
            Assert.Equal(expectedTaskname, task.title); 
        }
        [Fact]
        public  void TestCreateTaskByType(){
            string dateInput = "Mar 4, 2024";
            //solution for ambigiouty due to namespace
            EmployeeMgmt.Task task = new EmployeeMgmt.Task("task 1","task description", DateTime.Parse(dateInput), "nabin123", "user11","pending");
            Company c = new Company();
            try{
                c.createTask(task, task.assignedTo);
                Assert.True(true);
            }catch(Exception e){
                Assert.False(true);
            }
        }
        [Fact]
        public void TestSerializeTaskDataToxml(){
            Company c = new Company();
            string dateInput = "Mar 4, 2024";
            EmployeeMgmt.Task task = new EmployeeMgmt.Task("task 1","task description", DateTime.Parse(dateInput), "nabin123", "user11","pending");
            try{
                c.WriteSerializeXmlToFile(task);
                Assert.True(true);
            }catch(Exception e){
                Assert.False(true);
            }
        }
    }   
}

