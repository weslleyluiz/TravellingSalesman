namespace TravellingSalesman
{
    public class Edge
    {
        public Edge()
        {
            this.FirstVertex = new Vertex();
            this.SecondVertex = new Vertex();
        }
        public int distance { get; set; }
        public double pheromone { get; set; }
        public Vertex FirstVertex { get; set; }
        public Vertex SecondVertex { get; set; }
    }
}