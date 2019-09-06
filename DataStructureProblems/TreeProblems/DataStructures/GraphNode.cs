using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataStructureProblems.TreeProblems.DataStructures
{
    public enum State { Unvisited, Visited, Visiting }

    public class GraphNode<T>
    {
        public State CurrentState
        { get;set;}
        public T Value { get; set; }
        public List<GraphNode<T>> Neighbors { get; set; }

        public GraphNode()
        {
            this.Neighbors = new List<GraphNode<T>>();
        }

        public GraphNode(T value) {
            this.Value = value;
            this.Neighbors = new List<GraphNode<T>>();
        }
        public GraphNode(T value, List<GraphNode<T>> neighbors)
        {
            this.Value = value;
            this.Neighbors = neighbors;
        }

    }
}
