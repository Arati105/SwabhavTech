using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorArrayApp.Model
{
    class Rectangle
    {
        public int weight;
        public int height;

        public Rectangle(int w, int h)
        {
            this.weight = w;
            this.height = h;
        }

        public void SetWeight(int pweight)
        {
            weight = pweight;
        }
        public int GetWeight()
        {
            return weight;
        }
        public void SetHeight(int pheight)
        {
            height = pheight;
        }
        public int GetHeight()
        {
            return height;
        }
        public int CalculateArea()
        {
            int area = weight * height;
            return area;
        }
        
          
        
    }
}

    

