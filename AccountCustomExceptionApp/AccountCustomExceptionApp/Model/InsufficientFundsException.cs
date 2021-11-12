using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Model
{
    class InsufficientFundsException:Exception
    {
        private string _message;
        public InsufficientFundsException(Account acc,double withdrawamount)
        {
            _message = "\nTransaction account number:" + Convert.ToString(acc.GetAccNo()) +
                "to maintain minimum balance:" + acc.GetName() + ":" + acc.GetBalance() +
                "\n withdraw amount:" + Convert.ToString(withdrawamount);
        }
        public override string Message
        {
            get
            {
                return _message;
            }
        }

    }
}
