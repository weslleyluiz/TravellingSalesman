using NUnit.Framework;

namespace TravellingSalesman.Tests
{
    public class TravellingWithHamiltonUnitTest
    {
        private static Graph graph;
        private static Hamilton hamilton;
        [SetUp]
        public void Setup()
        {
            System.Diagnostics.Debug.WriteLine("Setup for travelling salesman using hamilton (bruteforce) algorithm");
            graph = new Graph(10, 1, 1000, 0.001);
        }

        [Test]
        public void TestHamilton()
        {
            hamilton = new Hamilton();
            hamilton.graph = graph;
            foreach (var v in hamilton.ShortestHamiltonCycle())
                System.Diagnostics.Debug.Write(v.index + " ");
            System.Diagnostics.Debug.WriteLine($"Distance: {hamilton.minDistance}");
        }
    }
}