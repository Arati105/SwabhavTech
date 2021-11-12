using System;
using System.Collections.Generic;
using System.Text;

namespace CurdableApp.Model
{
    class PremiumCustomerDB:Customer
    {
        public override void Update()
        {
            Console.WriteLine("Premium Customer Updated..");
        }
        public override void Delete()
        {
            Console.WriteLine("Premium Customer Delete..");
        }
    }
}
