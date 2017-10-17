using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClusterizeTest
{
    [TestClass]
    class UnionFindTest
    {
        [TestMethod]
        public void TestUnionFind()
        {
            var unionFind = new UnionFindTest();
            unionFind.AddElement(1);
            unionFind.AddElement(2);
            unionFind.AddElement(3);
            unionFind.AddElement(4);
            Assert.AreEqual(4, unionFind.DisjointSetsCount);
            unionFind.Union(1, 2);
            Assert.AreEqual(3, unionFind.DisjointSetsCount);
            unionFind.Union(2, 3);
            Assert.AreEqual(2, unionFind.DisjointSetsCount);
        }
    }
