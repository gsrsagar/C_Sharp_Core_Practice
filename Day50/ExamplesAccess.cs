

namespace AcessExampels {

    public class ExamplesAccess {

        public int age { get; set;}
        private int balance { get; set; }

        public int Deposit(int amount)
        {
            balance += amount; // assignment short hand
            return amount;
            
        }


        public int GetBalance()
        {
            return balance;
        }

       
    }
}