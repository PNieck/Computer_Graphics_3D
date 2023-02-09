using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Graphics_3D.Models
{
    public class Scene
    {
        List<Mesh> objects;

        public Scene(IEnumerable<Mesh> objects)
        {
            this.objects = new List<Mesh>(objects);
        }
    }
}
