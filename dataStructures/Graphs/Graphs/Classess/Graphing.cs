using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs.Classess
{
    class Graphing
    {

        public Dictionary<Vertex, List<Vertex>> AdjacencyList { get; set; }
        public Vertex vertex { get; set; }
        public List<Edges> Edges { get; set; }

        public Graphing()
        {
            AdjacencyList = new Dictionary<Vertex, List<Vertex>>();
            Edges = new List<Edges>();
        }
        public int CountSize()
        {
            return AdjacencyList.Count;
        }

        public object AddNode(Vertex vertex)
        {
            AdjacencyList.Add(vertex, new List<Vertex>());
            return AdjacencyList[vertex];
        }

        public Vertex AddEdge(Vertex p1, Vertex p2, int weight)
        {
            Edges.Add(new Edges(p1, p2, weight));
            AdjacencyList[p1].Add(p2);
            return p1;
        }

        public object RetrieveNodes()
        {
            return AdjacencyList.Keys;

        }

        public object RetrieveNeighbors(Vertex vertex)
        {
            return AdjacencyList[vertex];
        }
    }
}
