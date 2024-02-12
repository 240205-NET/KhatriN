using System;

namespace EmployeeMgmt {

    class Task{
        //fields
            //taskid
            //title
            //description
            //duedate
            //assigned by
            // created by
            // Assigned To // associate
            // completion status // pending // inreview // complete
            public int taskId{get; set;}
            private static int  taskSeedId = 1;
            public string title{get; set;}
            public string description{get;set;}
            public DateTime dueDate{get; set;}
            public string assignedBy{get; set;} // reference to manager class 

            public string assignedTo{get; set;} // refer to associate class
            public string status{get; set;}  // completed, pending, progress 
        // constructor

        //Methods
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
                this.assignedTo=assignedTo;
                this.status=status;

        }
    }
}