using System;

namespace AccountFormatLibrary {

    public class FormatAccount {
        // Method to calculate interest
        public static decimal CalculateInterestByMonths(int months, decimal interestRate, decimal balance)
        {
            if(balance < 0) {
                throw new ArgumentException("Balance cannot be negative");
            }
            return balance * (interestRate / 12) * months;
        }
    }
}
