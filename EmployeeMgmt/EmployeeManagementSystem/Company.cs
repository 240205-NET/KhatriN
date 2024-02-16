using System;
using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace EmployeeMgmt 
{
    
    //Singleton class to call everything in here and pass it to main
    public class Company 
    {
        //Fields
        private List<Manager> allManagers;
        private List<Associate> allAssociates;
        private List<Task> allTasks;
         Associate _associate;
         Manager manager;
         Task task;
        private  string managerFilePath=@".Manager.txt";
        private string associateFilePath = @".Associate.txt";
        private string serializeTaskFilePath = @".TaskSerial.txt";
        private string serializeAssociateFilePath = @".AssociateSerial.txt";
        private string serializeManagerFilePath = @".ManagerSerial.txt";
        // private XmlSerializer Serializer = new XmlSerializer(typeof(Associate));
        private XmlSerializer AssociateSerializer, ManagerSerializer, TaskSerializer;
        bool checkIfExists=false;

        //Constructor
        public Company(){
            this.allManagers = new List<Manager>();
            this.allAssociates = new List<Associate>();
            this.allTasks = new List<Task>();
            this._associate = new Associate();
            this.manager = new Manager();
            this.task = new Task();
            this.AssociateSerializer = new XmlSerializer(this._associate.GetType());
            this.ManagerSerializer = new XmlSerializer(this.manager.GetType());
            this.TaskSerializer = new XmlSerializer(this.task.GetType());
        }

        //Methods
        // All Manager Class associate Methods Below This
        public void createManagers(Manager m)
        {

            this.manager = m;
            this.allManagers.Add(this.manager);
            createManagersFile(this.manager);
            WriteSerializeXmlToFile(this.manager);
        }

        public List<Manager> getManagers(){
            return allManagers;
        }

        //list all Associate With unique user 
        public string filterAssociateByUsername(string username){
            int? counter;
            List<string> filterList = new List<string>();
            if(this.allAssociates.Count > 0){
                foreach(Associate filter in this.allAssociates){
                    if(filter.username==username){
                        filterList.Add(filter.username);
                    }else{
                        Console.WriteLine("Nothing to show");
                    }
                }
            }
            return filterList.ToString();

        }

        public string getManagerInfo(){
            var sb = new StringBuilder();
            foreach(Manager m in allManagers){
                sb.AppendLine(m.ToString());
            }
            return sb.ToString();
        }
        //Serialization of Manager File
        public void createManagersFile(Manager m){
             Console.WriteLine("Employee Details");
            string[] employeeList = {
                                   m.name, m.email,
                                    m.address, m.city, m.state, m.zip, 
                                    m.officeLocation, m.department, (m.salary).ToString(), 
                                    (m.startDate).ToString(), m.username
                                    };
            if(File.Exists(managerFilePath)){
                Console.WriteLine("Appending New Line to Existing File");
                File.AppendAllLines(managerFilePath, employeeList);
            }else{
                Console.WriteLine("CREATING NEW FILE...");
                File.WriteAllLines(managerFilePath,employeeList);
            }
        }

        //method to check if associate exists by username 
        public bool checkManagerExistsByUsername(string username)
        {
            checkIfExists = false;
            foreach(Manager man in allManagers){
                checkIfExists =false;
                if(man.username==username){
                    checkIfExists=true;
                }
                else{
                    checkIfExists=false;
                }
            }
            return checkIfExists;
        }

        public bool checkManagerLogin(string username){
            //bool checkLogin =  m.loginEmployee(Int32.Parse(inputLogin));
            bool checkLogin = false;
            foreach(Manager man in allManagers){
                if(username==man.username){
                    //condition check to create task
                    checkLogin = true;
                }
            }
             return checkLogin;
        }

        // All Associate Class associated Methods Below This
        public void createAssociates(Associate a){
            this._associate=a;
            this.allAssociates.Add(this._associate);
            createAssociatesFile(this._associate);
            WriteSerializeXmlToFile(this._associate);
        }
        public List<Associate> getAssociates(){
            return this.allAssociates;
        }
        public void createAssociatesFile(Associate a){
            Console.WriteLine("Assoicate Details");
            string[] associateLists = {
                                    a.name, a.email,
                                    a.address, a.city, a.state, a.zip, 
                                    a.officeLocation, a.department, (a.salary).ToString(), 
                                    (a.startDate).ToString(), a.username
                                    };
            if(File.Exists(associateFilePath)){
                Console.WriteLine("Already Exists");
                File.AppendAllLines(associateFilePath, associateLists);
            }else{
                File.WriteAllLines(associateFilePath, associateLists);
            }
                
        }
        
        //converting all the lists to string starts here
        public string getAssociateInfo(){
            var sb = new StringBuilder();
            foreach(Associate a in this.allAssociates){
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }

        public string getUsernameOfAssociateInfo(){
            var sb = new StringBuilder();
            foreach(Associate i in this.allAssociates){
                    sb.AppendLine(i.username.ToString());
            }
            return sb.ToString();
        }
        public bool checkAssociateLogin(string username){
            bool inputMatch = false;
            foreach(Associate asc in allAssociates){
                if(username==asc.username){
                    inputMatch=true;
                }
            }
            return inputMatch;
        }

        //method to check if managers exists by username
        public bool checkAssociateExistsByUsername(string username){
            checkIfExists=false;
            foreach(Associate ass in allAssociates){
                if(ass.username==username){
                    checkIfExists=true;
                }
            }
            return checkIfExists;

        }

        // All Task Class associate Methods Below This
        public void createTask(Task t, string username){
            this.task=t;
            this.allTasks.Add(this.task);
            WriteSerializeXmlToFile(this.task);
        }
        // returning to all the class lists starts here ie. for manager,associate and task class
        public List<Task> getTasks(){
            return allTasks;
        }
        
        //list all pending tasks by username ie associatedTo in Task
        public string listTaskByUsername(string username){
            var sb = new StringBuilder();
            // List<Task> listByUsername = new List<Task>();
            foreach(Task task in this.allTasks){
                if((task.assignedTo==username)&& (task.status).Trim()=="pending"){
                    sb.AppendLine(task.ToString());
                }
            }
            return sb.ToString();
        }

        // public string listTaskByUsernameByDate(DateTime dueDate){
        //     var 
        // }
        public string getAllTasksInfo(){
            var sb = new StringBuilder();
            foreach(Task task in this.allTasks){
                sb.AppendLine(task.ToString());
            }
            return sb.ToString();
        }

        //Modify the task from index O
        public void ModifyTaskByAssociate(string associate_username){
            Console.WriteLine("Modify the Description and status of top");
            Console.WriteLine("Change description");
            string description = Console.ReadLine();
            Console.WriteLine("Select Status");
            Console.WriteLine("Select 1 to Complete");
            Console.WriteLine("Select 2 to Reject");
            int i = 0;
            string status="";
            try{
               i=Int32.Parse(Console.ReadLine());
               if(i==1){
                 status = "Completed";
               }else if(i==2){
                status="Rejected";
               }else{
                status="Pending";
                Console.WriteLine("Enter Number from Menu");
               }
            }catch(Exception e){
                Console.WriteLine("Enter Number only" + e.Message);
            }
            // Task to = new Task();
            List<Task> to = new List<Task>();
            //get only task at the top by username
            foreach(Task ta in this.allTasks){
                if(ta.assignedTo==associate_username){
                    to.Add(ta);
                    // Console.WriteLine($"Old Description {to[0].description}");
                    // Console.WriteLine($"New Description {description}");
                    foreach(Task tt in to){
                        if(tt.description==to[0].description){
                            tt.description=description;
                            tt.status=status;
                            break;
                        }
                    }

                    // this.task = new Task(to.title, description, to.dueDate, to.assignedBy, to.assignedTo, status);
                    Console.WriteLine("Task updated");
                }
            }
        }        
       
        //Serialization of the Task
         public string SerializeXML(object o){
            var stringWriter = new StringWriter();
            try{
                if(o.GetType()==typeof(Manager)){
                    this.ManagerSerializer.Serialize(stringWriter, this.manager);
                }
                else if(o.GetType()==typeof(Associate))
                {
                    this.AssociateSerializer.Serialize(stringWriter, this._associate);
                }
                else if(o.GetType()==typeof(Task))
                {
                    this.TaskSerializer.Serialize(stringWriter, this.task);
                }
                else
                {
                    Console.WriteLine("Serialization to xml failed...");
                }
         
            }catch(Exception e){
                Console.WriteLine($"Serialization Error:{e.Message}");
            }
            
            stringWriter.Close();
            return stringWriter.ToString();
        }
        public void WriteSerializeXmlToFile(object t){
            // Console.WriteLine($"check istrueORNot {t.GetType()==typeof(Manager)} ");
            string[] serializeText = {SerializeXML(t)};
            if(t.GetType()==typeof(Associate)){

                if(!File.Exists(serializeAssociateFilePath)){
                    Console.WriteLine("Serialize Successfully.....");
                    File.WriteAllLines(serializeAssociateFilePath, serializeText);
                }else{
                    Console.WriteLine("Serialize File Exists For Associate.....");
                    File.AppendAllLines(serializeAssociateFilePath, serializeText);
                }
            }
            if(t.GetType()==typeof(Manager)){
                if(!File.Exists(serializeManagerFilePath)){
                    Console.WriteLine("Serialize Successfully.....");
                    File.WriteAllLines(serializeManagerFilePath, serializeText);
                }else{
                    Console.WriteLine("Serialize File Exists For Manager.....");
                    File.AppendAllLines(serializeManagerFilePath, serializeText);
                }
            }
            if(t.GetType()==typeof(Task)){
                if(!File.Exists(serializeTaskFilePath)){
                    Console.WriteLine("Serialize Successfully.....");
                    File.WriteAllLines(serializeTaskFilePath, serializeText);
                }else{
                    Console.WriteLine("Serialize File Exists For Task.....");
                    File.AppendAllLines(serializeTaskFilePath, serializeText);
                }
            }
            
        }
    }
}