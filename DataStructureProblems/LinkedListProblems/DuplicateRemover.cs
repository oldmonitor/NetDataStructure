using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.LinkedListProblems
{
    public class DuplicateRemover
    {
        private void DeleteDups(LinkedList<NodeDataElement> list)
        {
            LinkedListNode<NodeDataElement> node = list.First;
            var table = new Dictionary<int, bool>();

            while (node != null)
            {
                if (table.ContainsKey(node.Value.Key))
                {
                    list.Remove(node);
                }
                else
                {
                    table.Add(node.Value.Key, true);
                }

                node = node.Next;
            }
        }


    }
}
