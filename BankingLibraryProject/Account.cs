using AccountFormatLibrary;

using System;

namespace BankingLibraryProject {
    
    public class Account {
        // Properties
        public int AccountNumber { get; set; } = 1;
        public string Description { get; set; } = "Interest-bearing Account";
        public decimal Balance { get; set; } = 100m; // $100
        public decimal InterestRate { get; set; } = 0.12m; // 12% interest rate
        // Method to Calculate how much Interest to be paid using FormatAccount.cs
        public decimal CalculateInterest(int months) {
            decimal interestAmount
                = FormatAccount.CalculateInterestByMonths(months,InterestRate,Balance);
            Balance += interestAmount;
            return interestAmount;
        }
    }
}
