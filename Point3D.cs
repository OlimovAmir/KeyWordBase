using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWordBase
{
    internal class Point3D:Point2D
    {
        public Point3D()
        {
            Console.WriteLine("Called Constructor Point 2D");
        }
        public int Z { get; set; }
    }
}
