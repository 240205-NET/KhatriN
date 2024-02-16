using System;

namespace EmployeeMgmt {

    public class Task{
        //fields
            public int taskId{get; set;}
            private static int  taskSeedId = 1;
            public string title{get; set;}
            public string description{get;set;}
            public DateTime dueDate{get; set;}
            public string assignedBy{get; set;} // reference to manager class 
            public string assignedTo{get; set;} // refer to associate class
            public string status{get; set;}  // completed, pending, progress 
        
        // constructor

        public Task(){
            
        }

        public Task(string title, string description, 
            DateTime dueDate, string assignedBy, string assignedTo, string status){
                this.taskId = taskSeedId;
                taskSeedId++;
                this.title=title;
                this.description=description;
                this.dueDate=dueDate;
                this.assignedBy=assignedBy;
                this.assignedTo=assignedTo; // assigned to is username i.e unique in Associate Class
                this.status=status;
                }

    //Methods
        public string ToString(){
            return $"Tasks\nTitle: {this.title}\nDescription: {this.description}\nDue Date: {this.dueDate}\nAssigned By: {this.assignedBy}\nAssigned To: {this.assignedTo}\nStatus:{this.status}";
        }
    }
}