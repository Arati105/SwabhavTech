using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Model
{
    class Account
    {
        private  int _accountNo;
        private  String _name;
        private double _balance;
        private const double _defaultbalance = 500;

        public int GetAccNo()
        {
            return _accountNo;
        }
        public String GetName()
        {
            return _name;
        }
        public double GetBalance()
        {
            return _balance;
        }
        public Account(int ano, string n, double bal)
        {
            this._accountNo = ano;
            this._name = n;
            this._balance = bal;
        }
        public Account(int accno, String na)
        {
            this._accountNo = accno;
            this._name = na;
        }
        public double Deposit(double amount)
        {
            _balance += amount;
            return _balance;
        }
        public void Withdrow(double amount)
        {
            const double min_amount = 500.00;
            if(_balance-amount<min_amount)
            {
                throw new InsufficientFundsException(this, amount);
            }
            _balance = _balance - amount;
           /*if(_balance-amount < 500)
            { 
                throw new Exception("No found to withdraw.");
            }
            _balance= _balance - amount;
           */

        }
    }
}
