using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.DesignProblems
{
    /*
    Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.

    get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
    put(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.

    The cache is initialized with a positive capacity.

    Follow up:
    Could you do both operations in O(1) time complexity?

    Example:

    LRUCache cache = new LRUCache( 2  );/ capacity /

    cache.put(1, 1);
    cache.put(2, 2);
    cache.get(1);       // returns 1
    cache.put(3, 3);    // evicts key 2
    cache.get(2);       // returns -1 (not found)
    cache.put(4, 4);    // evicts key 1
    cache.get(1);       // returns -1 (not found)
    cache.get(3);       // returns 3
    cache.get(4);       // returns 4
     * */
    public class L146_LRUCache
    {
        /*
         * use two data structure: hashtable and double linked list
         * Hashtable for fast retrieval.
         * Use linked list for fast eviction
         *  - when item is used, move the item to front of list
         *  - when item needs to be removed, remove item at the end of list
         * */
        private LinkedList<Data> dataList = new LinkedList<Data>(); // key
        private Dictionary<int, LinkedListNode<Data>> dataMap = new Dictionary<int, LinkedListNode<Data>>();

        private int _capacity;
        public L146_LRUCache(int capacity)
        {
            this._capacity = capacity;
        }

        public void Put(int key, int value)
        {
            if(dataMap.ContainsKey(key)) // table has the key, just move item to front of list
            {
                LinkedListNode<Data> dataNode = dataMap[key];
                dataList.Remove(dataNode);
                dataList.AddFirst(dataNode);
            }
            else // add item to both table and list
            {
                // remove the least used
                if(dataList.Count == this._capacity)
                {
                    dataMap.Remove(dataList.Last.Value.Key);
                    dataList.RemoveLast();
                    
                }

                Data newData = new Data();
                newData.Key = key;
                newData.Value = value;

                var newNode = dataList.AddFirst(newData);
                dataMap.Add(newData.Key, newNode);
            }
        }

        public int Get(int key)
        {
            if (dataMap.ContainsKey(key))
            {
                LinkedListNode<Data> dataNode = dataMap[key];
                dataList.Remove(dataNode);
                dataList.AddFirst(dataNode);
                return dataNode.Value.Value;
            }
            else
            {
                return -1;
            }
        }

        private class Data
        {
            public int Key;
            public int Value;
        }


    }
}
