using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classess
{
    class Vertex
    {
        public int Value { get; set; }
        public List<Vertex> Neighbors { get; set; }
    }
}
