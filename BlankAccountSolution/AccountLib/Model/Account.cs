using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
   public class Account
    {
        private readonly int _accountNo;
        private readonly String _name;
        private double _balance;
        private const double _defaultbalance = 500;
        private static int _count = 0;

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
        public int GetCount()
        {
            return _count;
        }
        public Account(int ano,string n,double bal)
        {
            this._accountNo = ano;
            this._name = n;
            this._balance = bal;
            _count += 1;
        }
        public Account(int accno, String na)
        {
            this._accountNo = accno;
            this._name = na;
            _count += 1;
        }
        public double Deposit(double amount)
        {
            _balance += amount;
             return  _balance;
        }
        public void Withdrow(double amount)
        { 
            if (amount <= _balance && (_balance-amount) >= _defaultbalance)
            {
                _balance -= amount;
                Console.WriteLine("Transaction Successfully."+amount);
            }
            else
            {
                Console.WriteLine("Transaction failes.");
            }
     

        }
    }
}
