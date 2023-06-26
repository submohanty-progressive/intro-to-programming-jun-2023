using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.BankAccount;
public class MakingWithdrawls
{
    [Fact]
    public void MakingAWithdrawlDecreasesTheBalance()
    {
        Account account = new Account();
        decimal openingBalance = account.GetBalance();
        decimal amountToWithdraw = 100M;
        account.SetBalance(openingBalance - amountToWithdraw);
        Assert.Equals(openingBalance - amountToWithdraw, account.GetBalance());
    }
}