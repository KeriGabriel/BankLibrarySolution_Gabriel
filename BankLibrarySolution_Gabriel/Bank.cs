namespace BankLibrarySolution_Gabriel
{
    public class Bank
    {
        private readonly string _customer;
        private double _balance;

        private Bank() { }

        public Bank(string customer, double balance)
        {
            if (balance > 10000 || balance <= 0)
                throw new ArgumentOutOfRangeException("amount");
            _customer = customer;
            _balance = balance;
        }
        public string Customer
        {
            get { return _customer; }
        }
        public double Balance
        {
            get { return _balance; }
        }
        public double Withdraw(double amount)
        {
            if (amount > 500)
                amount = 500;
            // changed to == instead of <=
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount > _balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            // not needed 
            //if (amount < 0)
            //{
            //    throw new ArgumentOutOfRangeException("amount");
            //}

            //changed += to -= because this is withdraw meathod not deposit
            _balance -= amount;
            return _balance;
        }

        public double Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            _balance += amount;
            return _balance;
        }
    }
}