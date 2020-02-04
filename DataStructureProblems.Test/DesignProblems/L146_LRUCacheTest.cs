using System;
using DataStructureProblems.DesignProblems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureProblems.Test.DesignProblems
{
    [TestClass]
    public class L146_LRUCacheTest
    {
        /*
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
        */
        [TestMethod]
        public void TestCacheWithEviction()
        {
            L146_LRUCache cache = new L146_LRUCache(2);

            cache.Put(1, 1);
            cache.Put(2, 2);
            Assert.AreEqual(1, cache.Get(1));       // returns 1
            cache.Put(3, 3);    // evicts key 2
            Assert.AreEqual(-1, cache.Get(2));// returns -1 (not found)
  
            cache.Put(4, 4);    // evicts key 1
            Assert.AreEqual(-1, cache.Get(1));// returns -1 (not found)
            Assert.AreEqual(3, cache.Get(3));// returns 3
            Assert.AreEqual(4, cache.Get(4));// returns 4

        }
    }
}
