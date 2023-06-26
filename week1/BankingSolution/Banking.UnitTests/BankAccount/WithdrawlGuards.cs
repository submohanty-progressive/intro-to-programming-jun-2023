using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.BankAccount;

public class Account
{
    public void Deposit(decimal amountToDeposit)
    {
        _balance += amountToDeposit;
    }
    public decimal GetBalance()
    {
        return _balance;
    }
    public void OverdraftNotAllowed()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        try
        {
            account.Withdraw(openingBalance + .01M);
        }
        catch (OverflowException)
        {

        }
        Assert.Equals(openingBalance, account.GetBalance());
    }
    [Fact]
    public void OverdraftThrowsException()
    {
        var account = new Account();
        var openingBalance = account.GetBalance();
        
    }
}
