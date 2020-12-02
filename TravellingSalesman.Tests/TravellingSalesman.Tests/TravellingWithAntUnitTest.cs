using NUnit.Framework;

namespace TravellingSalesman.Tests
{
    public class TravellingWithAntUnitTest
    {
        private static Graph graph;
        private static AntUtil ant;

        [SetUp]
        public void Setup()
        {
            System.Diagnostics.Debug.WriteLine("Setup for travelling salesman using ant algorithm");
            graph = new Graph(10, 1, 1000, 0.001);
        }

        [Test]
        public void Test1()
        {
            ant = new AntUtil();
            ant.graph = graph;
            ant.alpha = 1;
            ant.beta = 5;
            ant.ro = 0.5;

            System.Diagnostics.Debug.WriteLine("Ant");
            foreach (var v in ant.AntColonyOptimization(100, 100))
                System.Diagnostics.Debug.Write(v.index + " ");
            System.Diagnostics.Debug.WriteLine("Distance: " + ant.minDistance);
        }
    }
}