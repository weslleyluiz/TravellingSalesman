using NUnit.Framework;

namespace TravellingSalesman.Tests
{
    public class TravellingWithGeneticUnitTest
    {
        private static Graph graph;
        private static Genetic genetic;
        [SetUp]
        public void Setup()
        {
            System.Diagnostics.Debug.WriteLine("Setup for travelling salesman using genetics algorithm"); 
            graph = new Graph(10, 1, 1000, 0.001);
        }

        [Test]
        public void TestGenetic()
        {
            genetic = new Genetic();
            genetic.graph = graph;

            genetic.GenerateChromosomes(100);

            genetic.mutationRate = (int)0.047 * genetic.chromosomes.Count;
            genetic.crossingRate = genetic.chromosomes.Count;
             
            foreach (var v in genetic.GeneticOptimization(100)) 
                System.Diagnostics.Debug.Write(v.index + " "); 

            System.Diagnostics.Debug.WriteLine($"{genetic.chromosomes[0].genes[0].index}\n Distance: {genetic.chromosomes[0].rating}"); 
        }
    }
}