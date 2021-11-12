using System;
using System.Collections.Generic;
using System.Text;

namespace MyUnitTestApp.Model
{ 
    [AttributeUsage(AttributeTargets.All)]
    class MyUnitTestClass:Attribute
    {
        private string Name
        {
            get;
            set;
        }
    }
}
