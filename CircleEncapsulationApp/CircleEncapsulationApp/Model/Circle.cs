using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleEncapsulationApp.Model
{
    class Circle
    {
       
        private int radius;
        private String color;
       
       public void SetRadius(int cradius)
        {
            if(cradius < 1 && cradius > 10)
            {
                cradius = 1;
            }
            else
            {
                cradius = 10;
            }
            radius = cradius;
           
         }
        public int GetRadius()
        {
            return radius;
        }
        public void SetColor(String scolor)
        {
            if(scolor == "red"  ||  scolor == "blue" || scolor == "green" )
            {
                color = scolor;
            }
            else
            {
                scolor = "blue";
            }
        }
        public string GetColor()
        {
            return color;
        }

    }
}
