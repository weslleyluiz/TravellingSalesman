using System;
using System.Collections.Generic;

namespace TravellingSalesman
{
    public class Hamilton
    {
        public Hamilton()
        {
            verticesStack = new Stack<Vertex>();
            usedVertices = new Stack<Vertex>();
            shortestPath = new List<Vertex>();
            minDistance = 0;
        }

        public Graph graph { get; set; }        
        public double minDistance { get; private set; }

        Vertex startVertex;
        List<Vertex> shortestPath;        
        Stack<Vertex> verticesStack;
        Stack<Vertex> usedVertices;

        public List<Vertex> ShortestHamiltonCycle()
        {
            startVertex = graph.vertices[0];
            HamiltonCycleRecurring(startVertex);
            return shortestPath;
        }

        int counter = 0;
        double distance = 0;

        void HamiltonCycleRecurring(Vertex vertex)
        {
            counter++;         
            usedVertices.Push(vertex);            
            verticesStack.Push(vertex);

            foreach (Edge edge in vertex.neighbors)
            {
                if (edge.SecondVertex == startVertex)
                {
                    if (counter == graph.vertices.Length)
                    {
                        verticesStack.Push(edge.SecondVertex);
                        distance += edge.distance;

                        if (minDistance == 0 || distance < minDistance)
                        {
                            shortestPath.Clear();
                            shortestPath.AddRange(verticesStack);
                            minDistance = distance;
                        }

                        distance -= edge.distance;
                        verticesStack.Pop();
                    }
                }

                if (!usedVertices.Contains(edge.SecondVertex))
                {
                    distance += edge.distance;
                    HamiltonCycleRecurring(edge.SecondVertex);
                    distance -= edge.distance;
                }
            }

            verticesStack.Pop();
            usedVertices.Pop();
            counter--;
        }
    }
}
