using Xunit;
using BankLibrary;
using System;

namespace BankingTests;

public class UnitTest1 {
    [Fact]
    public void InitialBalanceMustBePositive() {
        // Test that the intial balances must be positive
        Assert.Throws<ArgumentOutOfRangeException>(
            () => new BankAccount("invalid", -55)
        );
    }

    [Fact]
    public void DepositMustBePositive() {
        var testAccount = new BankAccount("initial", 100000);

        // Test that deposit must be positive
        Assert.Throws<ArgumentOutOfRangeException>(
            () => testAccount.MakeDeposit(-100, DateTime.Now, "Test")
        );
    }

}
