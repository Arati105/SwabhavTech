using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp.Model
{
    class Rectangle
    {
      public int width;
      public int height;

        private int validation(int p)
        {
              if(p <= 100 && p >= 1)
            {
                p = 100;
                p = 1;
            }
            return p;
            
        }
        public void SetWidth(int p)
        {
            width = p;
        }
        public int GetWidth()
        {
            return width;
        }
        public void SetHeight(int p)
        {
            height = p;
        }
        public int GetHeight()
        {
            return height;
        }
      
       /* public void SetWidth(int pwidth)
        {
            if (pwidth > 100)
            {
                width = 100;
            }
            else if(pwidth <1)
            {
                width =1;
            }
            else
            {
                width= pwidth;
            }

        }
        public int GetWidth()
        {

            return width;
        }
       */
      /*  public void SetHeight(int pheight)
        {
            if(pheight > 40 && pheight < 40)
            {
                height = 40;
            }
            else
            {
                height = pheight;
            }
        }
        public int GetHeight()
        {
            return height;
        }*/
    }
}
