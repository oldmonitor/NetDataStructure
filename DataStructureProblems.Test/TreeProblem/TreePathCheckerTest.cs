using DataStructureProblems.TreeProblems;
using DataStructureProblems.TreeProblems.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.Test.TreeProblem
{
    [TestClass]
    public class TreePathCheckerTest
    {
        [TestMethod]
        public void TestThereIsValidPath()
        {
            GraphNode<int> node1 = new GraphNode<int>() { Value = 1 };
            GraphNode<int> node2 = new GraphNode<int>() { Value = 2 };
            GraphNode<int> node3 = new GraphNode<int>() { Value = 3 };

            Graph<int> graph = new Graph<int>();
            graph.AddNode(node1);
            graph.AddNode(node2);
            graph.AddNode(node3);

            graph.AddEdge(node1, node2);
            graph.AddEdge(node2, node3);

            bool boolResult = PathChecker.Search(graph, node1, node3);

            Assert.AreEqual(true, boolResult);
        }

        [TestMethod]
        public void TestThereIsInvalidPath()
        {
            GraphNode<int> node1 = new GraphNode<int>() { Value = 1 };
            GraphNode<int> node2 = new GraphNode<int>() { Value = 2 };
            GraphNode<int> node3 = new GraphNode<int>() { Value = 3 };
            GraphNode<int> node4 = new GraphNode<int>() { Value = 4 };

            Graph<int> graph = new Graph<int>();
            graph.AddNode(node1);
            graph.AddNode(node2);
            graph.AddNode(node3);
            graph.AddNode(node4);

            graph.AddEdge(node1, node2);
            graph.AddEdge(node2, node3);
            graph.AddEdge(node1, node4);

            bool boolResult = PathChecker.Search(graph, node2, node4);

            Assert.AreEqual(false, boolResult);
        }


    }
}
