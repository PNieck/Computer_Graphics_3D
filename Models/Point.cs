using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Graphics_3D.Models
{
    public class Point
    {
        private Vector3 _vector;
        
        public Vector3 vector { get { return _vector; } set { _vector = value; } }

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

        Point(float x, float y, float z)
        {
            _vector = new Vector3(x, y, z);
        }

    }
}
