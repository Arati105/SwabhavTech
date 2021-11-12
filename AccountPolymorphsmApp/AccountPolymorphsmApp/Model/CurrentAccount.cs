using System;
using System.Collections.Generic;
using System.Text;

namespace AccountPolymorphsmApp.Model
{
    class CurrentAccount:Account
    {
        

        public CurrentAccount(int acc_no, string name, double bal) : base(acc_no, name, bal)
        {
           
        }
        public override void Withdraw(double amount)
        {
            if(DoOverDraftCheck())
            {
                _balance = balance- amount;
            }
        }

        private bool DoOverDraftCheck()
        {
            return true;
        }
    }
}
