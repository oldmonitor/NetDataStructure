using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.LinkedListProblems
{
    public class LinkedListExample
    {
        public void CreateLinkedList()
        {
            // Creating a linkedlist 
            // Using LinkedList class 
            LinkedList<NodeDataElement> mylist = new LinkedList<NodeDataElement>();

            // Adding elements in the LinkedList 
            // Using AddLast() method 
            mylist.AddLast(new NodeDataElement { Key = 1, Value="test"});
            
            var resultNode =
            mylist.FirstOrDefault(x => x.Key == 1);
            mylist.Remove(resultNode);

            Console.WriteLine("Best students of XYZ university:");
            

            // Accessing the elements of  
            // LinkedList Using foreach loop 
            foreach (NodeDataElement str in mylist)
            {
                Console.WriteLine(str);
            }
        }
       
    }

    
}
