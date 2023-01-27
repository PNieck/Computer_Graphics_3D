using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Graphics_3D.Models
{
    internal class Point
    {
        Vector4 _vector;
        
        public Vector4 vector { get { return _vector; } set { _vector = value; } }

        public float x
        {
            get { return _vector.X; }
            set { _vector.X = value; }
        }

        public float y
        {
            get { return _vector.Y; }
            set { _vector.Y = value; }
        }

        public float z
        {
            get { return _vector.Z; }
            set { _vector.Z = value; }
        }

        public float w
        {
            get { return _vector.W; }
            set { _vector.W = value; }
        }

        Point(float x, float y, float z)
        {
            _vector = new Vector4(x, y, z, 1);
        }

        void normalise()
        {
            x /= w;
            y /= w;
            z /= w;
            w = 1;
        }
    }
}
