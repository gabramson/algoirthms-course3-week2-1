using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClusterizeTest
{
    [TestClass]
    public class ClusterizeTest
    {
        [TestMethod]
        public void TestClusterizer()
        {
            var clusterizer = new Clusterizer(3);
            clusterizer.AddEdge(1, 2, 4);
            clusterizer.AddEdge(1, 3, 6);
            clusterizer.AddEdge(1, 4, 20);
            clusterizer.AddEdge(1, 5, 22);
            clusterizer.AddEdge(1, 6, 30);
            clusterizer.AddEdge(1, 7, 32);
            clusterizer.AddEdge(1, 8, 34);
            clusterizer.AddEdge(2, 3, 5);
            clusterizer.AddEdge(2, 4, 21);
            clusterizer.AddEdge(2, 5, 23);
            clusterizer.AddEdge(2, 6, 31);
            clusterizer.AddEdge(2, 7, 33);
            clusterizer.AddEdge(2, 8, 35);
            clusterizer.AddEdge(3, 4, 22);
            clusterizer.AddEdge(3, 5, 24);
            clusterizer.AddEdge(3, 6, 32);
            clusterizer.AddEdge(3, 7, 34);
            clusterizer.AddEdge(3, 8, 36);
            clusterizer.AddEdge(4, 5, 2);
            clusterizer.AddEdge(4, 6, 15);
            clusterizer.AddEdge(4, 7, 17);
            clusterizer.AddEdge(4, 8, 19);
            clusterizer.AddEdge(5, 6, 16);
            clusterizer.AddEdge(5, 7, 18);
            clusterizer.AddEdge(5, 8, 19);
            clusterizer.AddEdge(6, 7, 2);
            clusterizer.AddEdge(6, 8, 1);
            clusterizer.AddEdge(7, 8, 3);
            clusterizer.Execute();
            Assert.AreEqual(15, clusterizer.Spacing);
        }
    }
}
