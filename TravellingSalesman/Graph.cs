using System;
using System.Linq;

namespace TravellingSalesman
{
    public class Graph
    {
        public Vertex[] vertices { get; set; }
        public Edge[] edges { get; set; }
        public Graph(int size, int min, int max, double pheromone)
        { 
            Random rand = new Random();
            this.edges = new Edge[size];
            this.vertices = new Vertex[size];
            for (int i = 0; i < size; i++)
                this.vertices[i] = (new Vertex() { index = i});

            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    Edge edge = new Edge();
                    edge.distance = rand.Next(min, max);
                    edge.pheromone = pheromone;
                    edge.FirstVertex = this.vertices[i];
                    edge.SecondVertex = this.vertices[j];

                    this.vertices[i].neighbors.Add(edge);

                    Edge edge2 = new Edge();
                    edge2.distance = edge.distance;
                    edge2.pheromone = pheromone;
                    edge2.FirstVertex = this.vertices[j];
                    edge2.SecondVertex = this.vertices[i];

                    this.vertices[j].neighbors.Add(edge2);

                    this.edges.Append(edge);
                    this.edges.Append(edge2);
                }
            } 
        }
    }
}