using System;
using System.Collections.Generic;
using System.Text;

namespace AccountPolymorphsmApp.Model
{
    abstract class Account
    {
       protected  int _accno;
       protected string _accname;
       protected double _balance;

        public Account(int acc_no,string name,double bal)
        {
            this._accno = acc_no;
            this._accname= name;
            this._balance = bal;
        }
        public void Deposit(double amt)
        {
            _balance += amt;
            
        }
        public abstract void Withdraw(double amount);

        public int accno
        {
            get
            {
                return _accno;
            }
        }
        public string accname
        {
            get
            {
                return _accname;
            }
        }
        public double balance
        {
            get
            {
                return _balance;
            }
        }
    }

}
