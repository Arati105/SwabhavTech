using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceConstructorApp2.Model
{
    class Parent
    {
        private int _foo;

        public Parent(int num)
        {
            _foo = num;
        }
        public int GetFoo()
        {
            return _foo;

        }
    }
}
