using System;
using System.Collections.Generic;

namespace TravellingSalesman {
    public class Vertex
    {
        public Vertex()
        {
            this.neighbors = new List<Edge>();
        }
        public int index { get; set; }
        public double data { get; set; }
        public List<Edge> neighbors { get; set; }
    }
}
