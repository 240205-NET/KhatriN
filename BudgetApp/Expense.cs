namespace Budget{
    class Expense{
        List<string> expenses = new List<string>();
        private int expensesId;
        private string fullName;
        private double totalAmount;
        private string description;
        private int expensesIdSeed = 1;
        public Expense(string name, double totalAmt){  
            this.fullName = name;
            this.totalAmount=totalAmt;
            Menu(this.totalAmount);
        }

        public void setDescription(string desc){
            this.description = desc; 
        }

        public void Menu(int amt){
            Console.WriteLine("You have total amount of " + amt + " to spent." );
            Console.WriteLine("Enter 1 to Add Expenses");
            Console.WriteLine("Enter 2 to Delete Expenses");
            Console.WriteLine("Enter 3 to list all Expenses");
            Console.WriteLine("Enter 4 to Exit Program");
            int number = Int32.Parse(Console.ReadLine());
            ExpenseOperation(number);
        }

        public void ExpenseOperation(int num){
            while(num >0){
                switch(num){
                case 1: 
                    AddExpenses();
                    break;
                case 2:
                    DeleteExpense();
                    break;
                case 3:
                    listAllExpenses();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            }
        }

        public void AddExpenses(){
            Console.WriteLine("Please Enter Your Expense Description");
            string desc = Console.ReadLine();
            Console.WriteLine("Please Enter Your Spent Amount");
            double amt = Double.Parse(Console.ReadLine());
            this.totalAmount -= amt;
            string statement = "Your Message is: " + desc + " \n" +
            " Your Expenses is " + amt;
            expenses.Add(statement);
        }
        public List<string> listAllExpenses(){
            return expenses;
        }
        public  void DeleteExpense(){
            Console.WriteLine("");
        }
    }
}