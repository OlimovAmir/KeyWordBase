﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyWordBase
{
    internal class Point2D
    {
        public Point2D(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Console.WriteLine("Called Constructor Point 2D");
        }
        public int X { get; set; }
        public int Y { get; set; }


        public void Print2D()
        {
            Console.WriteLine($"X:\t {X}");
            Console.WriteLine($"Y:\t {Y}");
        }
    }
}
