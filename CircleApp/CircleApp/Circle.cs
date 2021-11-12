using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        public float radius;
        public String color;
        
        public double CircleArea()
        {
            double PI = 3.15;
            double area = Math.PI * radius * radius;
            
            return area;
        }
        public double CirclePerimeter()
        {
            double PI = 3.15;
            double perimeter= (float)(2 * Math.PI * radius);
            return perimeter;
        }
    }
}
