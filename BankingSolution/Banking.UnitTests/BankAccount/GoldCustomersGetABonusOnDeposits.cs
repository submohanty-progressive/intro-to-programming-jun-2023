


namespace Banking.UnitTests.BankAccount;
public class GoldCustomersGetABonusOnDeposits
{
    [Fact]
    public void BonusIsApplied()
    {
        var account = new GoldAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        var expectedNewBalance = openingBalance + amountToDeposit + 10M;



        account.Deposit(amountToDeposit);



        Assert.Equal(expectedNewBalance, account.GetBalance());
    }
    public enum LoyaltyLevel { Standard, Gold }
    public class Account
    {
        private decimal _balance = 5000; // Fields class level variable
        public LoyaltyLevel AccountType { get; set; } = LoyaltyLevel.Standard;
        public void Deposit(decimal amountToDeposit)
        {

            if (AccountType == LoyaltyLevel.Gold)
            {
                _balance += amountToDeposit * 1.10M;
            }
            else
            {
                _balance += amountToDeposit;
            }

        }
    }
