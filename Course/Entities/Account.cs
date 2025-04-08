namespace Course.Entities
{
    class Account
    {
        int TAXA = 5;
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(Double amount)
        {
            Balance -= amount + TAXA;
        }

        public void Deposit(Double amount)
        {
            Balance += amount;
        }
    }
}
