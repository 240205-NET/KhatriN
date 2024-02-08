using System;
namespace Banking{
    class Banking {
        public static void Main(string[] args){

            //account
                //pin
                // account_number
                // type (checking/savings)
                //account balance
                // withdrawls
                // deposits
                //balance
                // associate with another account
                // transfer to other accounts
                // closing account (remove account Info)
            Account firstAccount = new SavingAccount("James", 1000);
            Account secondAccount = new SavingAccount("Randall", 1000);
            Account thirdAccount = new SavingAccount("Meryem", 1000);

            Console.WriteLine(firstAccount.DisplayBalance());
            Console.WriteLine(secondAccount.DisplayBalance());
            Console.WriteLine(thirdAccount.DisplayBalance());

            secondAccount.MakeDeposit(500);

            Console.WriteLine(secondAccount.DisplayBalance());

            Console.WriteLine(secondAccount.DisplayTransactionHistory());
        }
     }
        
 }
    
