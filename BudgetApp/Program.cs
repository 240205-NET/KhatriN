using System;
namespace Budget{
    class Budget{
        public static void Main(string[] args){
            Console.WriteLine("Please enter Your FullName");
            string name = Console.ReadLine();

            Console.WriteLine("please enter your Budget");
            double budgetAmt = Int32.Parse(Console.ReadLine());
            Expense exp = new Expense(name, budgetAmt);
            
        }
    }
}
