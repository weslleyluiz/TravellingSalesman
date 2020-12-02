using NUnit.Framework;

namespace TravellingSalesman.Tests
{
    public class TravellingWithNearestNeighbourUnitTest
    {
        private static Graph graph;
        private static NearestNeighbour neighbour;

        [SetUp]
        public void Setup()
        {
            System.Diagnostics.Debug.WriteLine("Setup for travelling salesman using Nearest Neighbour algorithm");
            graph = new Graph(10, 1, 1000, 0.001);
        }

        [Test]
        public void TestNearestNeighbour()
        {
            neighbour = new NearestNeighbour();
            neighbour.graph = graph;
            foreach (var v in neighbour.NearestNeighbourOptimization()) 
                System.Diagnostics.Debug.Write(v.index + " "); 
            System.Diagnostics.Debug.WriteLine($"\nDistance: { neighbour.minDistance}\n"); 
        }
    }
}