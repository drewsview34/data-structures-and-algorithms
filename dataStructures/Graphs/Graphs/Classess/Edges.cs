using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classess
{
    class Edges
    {
        public Vertex BeginA { get; set; }
        public Vertex BeginB { get; set; }
        public int Weight { get; set; }

        public Edges(Vertex a, Vertex b, int weight)
        {
            BeginA = a;
            BeginB = b;
            Weight = weight;
        }
    }
}
