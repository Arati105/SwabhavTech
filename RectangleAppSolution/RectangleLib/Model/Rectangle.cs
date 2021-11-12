using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp.Model
{
   public  class Rectangle
    {
        private int _weight;
        private int _height;
        private static int _count = 0;

        public Rectangle(int w, int h)
        {
            this._weight = w;
            this._height = h;
            _count += 1;
        }
        public int GetWeight()
        {
            return _weight;
        }
        public int GetHeight()
        {
            return _height;
        }
        public int GetCount()
        {
            return _count;
        }
        public int CalculateArea()
        {
            int area = _weight * _height;
            return area;
        }
    }
}
