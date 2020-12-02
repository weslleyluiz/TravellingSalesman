namespace TravellingSalesman
{
    public class Chromosome
    {
        public System.Collections.Generic.List<Vertex> genes { get; set; }
        public int rating { get; set; }
        public Chromosome()
        {
            genes = new System.Collections.Generic.List<Vertex>();
        }
    }
}