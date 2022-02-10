using AccountFormatLibrary;

using System;

using Xunit;

namespace TestInterestCalculation {
    
    public class UnitTest1 {
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Tests CalculateInterestByMonths
        [Theory]
        [InlineData(36, 36, 0.12, 100)] // Test case
        
        public void TestCalcIntByMonths(decimal interestAmount, int months, decimal interestRate, decimal balance) { // Method
            Assert.Equal(interestAmount,
                FormatAccount.CalculateInterestByMonths(months, interestRate, balance));
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Tests a Negative Balance
        [Fact]
        public void TestNegativeBalance() {
            Action MakeBalanceNegative = () =>
                FormatAccount.CalculateInterestByMonths(1, 0.1m, -100m);
            Assert.Throws<ArgumentException>(MakeBalanceNegative);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
