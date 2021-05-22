using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testWebApi
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public int r { get; set; }

        public Point(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

    }
}
