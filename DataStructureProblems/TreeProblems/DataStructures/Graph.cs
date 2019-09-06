using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.TreeProblems.DataStructures
{
    public class Graph<T>
    {
        public List<GraphNode<T>> NodeSet { get; set; }
        public Graph()
        {
            this.NodeSet = new List<GraphNode<T>>();
        }

        public void AddNode(GraphNode<T> node)
        {
            this.NodeSet.Add(node);
        }

        public void AddEdge(GraphNode<T> from, GraphNode<T> to)
        {
            from.Neighbors.Add(to);
        }

    }
}
