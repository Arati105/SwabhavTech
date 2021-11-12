using System;
using System.Collections.Generic;
using System.Text;

namespace MyUnitTestApp.Model
{
    [MyUnitTestClass]
    class Foo
    {
        [MyUnitTestMethod]
        public bool F1()
        {
            return true;
        }
        public bool F2()
        {
            return true;
        }
        [MyUnitTestMethod]
        public bool F3()
        {
            return true;
        }
        public bool F4()
        {
            return true;
        }
    }
}
