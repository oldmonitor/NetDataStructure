using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructureProblems.TreeProblems.DataStructures;

namespace DataStructureProblems.TreeProblems
{
    
    public class PathChecker
    {
        /// <summary>
        /// Given a directed graph, design an algorithm to find out whether there is a
        /// route between two nodes.
        /// BFS to find path
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static bool Search(Graph<int> graph, GraphNode<int> start, GraphNode<int> end)
        {
            if (start.Value == end.Value) return true;

            //node to be visited
            Queue<GraphNode<int>> queue = new Queue<GraphNode<int>>();

            //set all node unvisited
            foreach(var node in graph.NodeSet)
            {
                node.CurrentState = State.Unvisited;
            }

            start.CurrentState = State.Visiting;
            queue.Enqueue(start);

            GraphNode<int> currentNode;

            //continue checking child nodes until queue is empty
            while (queue.Any())
            {
                currentNode = queue.Dequeue();
                if(currentNode != null)
                {
                    foreach(GraphNode<int> child in currentNode.Neighbors)
                    {
                        if(child.CurrentState == State.Unvisited)
                        {
                            if(child.Value == end.Value)
                            {
                                return true;
                            }
                            else
                            {
                                child.CurrentState = State.Visiting;
                                queue.Enqueue(child);
                            }
                        }
                    }
                    currentNode.CurrentState = State.Visited;
                }
            }

            return false;

        }

    }


}
