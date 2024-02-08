namespace Banking{
    abstract class Account{
        //Access Modifier
            /**
                public
                private - * default access modifier
                protected
                internal
             */
             private string owner;
            
             private List<Transaction> transactions = new List<Transaction>();
            

            //similar to getter and setter but a new approach of C# to define it
            public int accountNumber {get; set; }

           
            protected double balance;

            private static int accountNumberSeed = 123;

            public Account(string ownersName, double initialBalance){
                this.accountNumber = accountNumberSeed;
                accountNumberSeed++;
                this.owner = ownersName;
                MakeDeposit(initialBalance);
            }

             public Account(string ownerName)
        { 
            //create account num
            this.accountNumber = accountNumberSeed;
            accountNumberSeed++;

            this.owner = ownerName;
            MakeDeposit(0);
        }
            //virtual is for inheritance so that derived class can use it this method 
            public virtual void MakeDeposit(double amount, string note = ""){
                if(amount <= 0){
                    Console.WriteLine("deposit may not be less than 0.");

                }else{
                    balance += amount;
                    Transaction deposit = new Transaction(amount, DateTime.Now, note);
                    transactions.Add(deposit);
                }
            }

            //withdrawl
            public virtual void MakeWithDrawl(double amount, string note = ""){
                if(amount <= 0){
                    Console.WriteLine("Withdrawl may not be less than 0.");
                }else if((this.balance-amount) < 0){
                    Console.WriteLine("Insufficient funds");
                }else{
                    balance -= amount;
                    Transaction withdrawl = new Transaction(amount, DateTime.Now, note);
                    transactions.Add(withdrawl);
                }
            }
            
            //abstract method Must be Overridden by a derived class
            //virtual methods CAN be overridden by a derived class, but don't have to.
            public virtual string DisplayBalance(){
                string balanceString = "Account # " + this.accountNumber + " has a balance of " + this.balance;
                return balanceString;
            }

            //Display Transaction History
            public virtual string DisplayTransactionHistory(){
               var history = new System.Text.StringBuilder();
               history.AppendLine("Date\t\tAmount\t\tNote");
                foreach(Transaction item in transactions){
                    history.AppendLine($"{item.date.ToShortDateString()}\t{item.amount}\t{item.note}");
                }
                return history.ToString();
            }

            
    }
}