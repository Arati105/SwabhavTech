using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation.Model
{
    class ArrayList1
    {
        ArrayList list = new ArrayList();

        public void Add(int aList)
        {
            list.Add(aList);
        }

        public void Read()
        {
            foreach(int i in list)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine(" ");
        }

        public void Update(int value,int index)
        {
            list.RemoveAt(index - 1);
            list.Insert(index - 1, value);
        }

        public void Delete(int index)
        {
            list.RemoveAt(index - 1);
        }
    }
}
