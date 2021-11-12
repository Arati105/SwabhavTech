using System;
using System.Collections.Generic;
using System.Text;

namespace AccountPolymorphsmApp.Model
{
    class SavingAccount:Account
    { 
         public SavingAccount(int accno,string name,double bal):base(accno,name,bal)
        {
           
        }
        public override void Withdraw(double amount)
        {
            int min_balance = 500;
            if((balance-amount)>min_balance)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("limit reached");
            }
        }
    }
}
