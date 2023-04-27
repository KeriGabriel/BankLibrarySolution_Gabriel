using BankLibrarySolution_Gabriel;
namespace BankLibraryTests

{
    [TestClass]
    public class UnitTest1
    {      
        
        //[TestMethod]
        //[ArgumentOutOfRangeException("amount")]
        //Bank(string customer, double balance)
        [TestMethod]
        public void PassParameters()
        {
            string customer = "Test";
            double balance = 10;
            Bank bank = new Bank( customer,  balance);
            Assert.AreEqual(bank.Balance, balance);
            Assert.AreEqual(bank.Customer, customer);
        }

        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AmountException()
        {
            string customer = "Test";
            double balance = 20000;
            Bank bank = new Bank(customer, balance);
            Assert.AreEqual(bank.Balance, balance);
            Assert.AreEqual(bank.Customer, customer);
        }
        //  public double Withdraw(double amount)
        [TestMethod]
        public void withdraw_five_hundred()
        {
            int amount = 500;
            int ballance = 501;
            string customer = "Test";
            Bank bank = new Bank(customer, ballance);
            Assert.AreEqual(ballance-amount, bank.Withdraw(amount));
        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void withdraw_under_zero()
        {
            int amount = 0;
            int ballance = 501;
            string customer = "Test";
            Bank bank = new Bank(customer, ballance);
            Assert.AreEqual(ballance - amount, bank.Withdraw(amount));
        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Withdraw_amount_over_ballence()
        {
            int amount = 402;
            int ballance = 400;
            string customer = "Test";
            Bank bank = new Bank(customer, ballance);
            Assert.AreEqual(ballance - amount, bank.Withdraw(amount));
        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Withdraw_zero()
        {
            int amount = 0;
            int ballance = 400;
            string customer = "Test";
            Bank bank = new Bank(customer, ballance);
            Assert.AreEqual(ballance - amount, bank.Withdraw(amount));
        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Withdraw_less_than_zero()
        {
            int amount = -50;
            int ballance = 400;
            string customer = "Test";
            Bank bank = new Bank(customer, ballance);
            Assert.AreEqual(ballance - amount, bank.Withdraw(amount));
        }
        // public double Deposit(double amount)
        [TestMethod]
        public void DepositPass()
        {
            int amount = 200;
            int ballance = 400;
            string customer = "Test";
            Bank bank = new Bank(customer, ballance);
            Assert.AreEqual(ballance + amount, bank.Deposit(amount));
        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Deposit_zero()
        {
            int amount = 0;
            int ballance = 400;
            string customer = "Test";
            Bank bank = new Bank(customer, ballance);
            Assert.AreEqual(ballance + amount, bank.Deposit(amount));
        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Deposit_less_than_zero()
        {
            int amount = -100;
            int ballance = 400;
            string customer = "Test";
            Bank bank = new Bank(customer, ballance);
            Assert.AreEqual(ballance + amount, bank.Deposit(amount));
        }
    }
}