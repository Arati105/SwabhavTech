using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapSolutionApp.Model
{
    class RectangleApp
    {
        public int weight;
        public int height;

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
