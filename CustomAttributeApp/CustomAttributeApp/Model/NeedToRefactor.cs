using System;
using System.Collections.Generic;
using System.Text;

namespace CustomAttributeApp.Model
{
   public class NeedToRefactor:Attribute
    {
       public string Name
        {
            get;
            set;
        }

       
    }
}
