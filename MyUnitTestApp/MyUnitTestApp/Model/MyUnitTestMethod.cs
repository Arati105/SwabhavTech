using System;
using System.Collections.Generic;
using System.Text;

namespace MyUnitTestApp.Model
{
    [AttributeUsage(AttributeTargets.All)]
    class MyUnitTestMethod:Attribute
    {
        private string Name
        {
            get;
            set;
        }
    }
}
