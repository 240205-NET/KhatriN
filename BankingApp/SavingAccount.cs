namespace Banking{
    class SavingAccount : Account // the ":" means that we are inheriting or extending the account class.
    {
        //fields
        private double interestRate;
        //constructor
        //base is calling parent class
        public SavingAccount(string owner,
            double initialBalance,
            double interestRate= 0.01): base(owner, initialBalance)
        {
            this.interestRate=interestRate;
        }

        //Methods
        public override string DisplayBalance(){
            return ("From savingsd Account: " +  base.DisplayBalance());
        }
    }
}