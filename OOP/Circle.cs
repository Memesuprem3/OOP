using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Circle
    {

        public  double _pi = 3.141f;
        public int _radius;

        public Circle (int radius)
        {
            _radius = radius;

        }



        public double getArea()
        {
            return _pi * _radius * _radius;
        }

    }
}
