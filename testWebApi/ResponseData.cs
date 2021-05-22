using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testWebApi
{
    public class ResponseData
    {
        public List<int> barsData { get; set; }
        public List<int> lineData { get; set; }
        public List<Point> bubbleData { get; set; }

        public ResponseData()
        {
            barsData = new List<int>();
            lineData = new List<int>();
            bubbleData = new List<Point>();
        }
    }
}
