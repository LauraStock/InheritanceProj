using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProj
{
    // BASE CLASS
    class Shape
    {
        public int width;
        public int height;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }
    // DERIVED CLASS
    class Rectangle : Shape {
        public int getArea()
        {
            return (width * height);
        }
    }

    sealed class Triangle : Shape
    {
        public int getArea()
        {
            return (width * height) / 2;
        }

    }
}
