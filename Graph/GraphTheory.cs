using System;
using System.Collections.Generic;
using CodeLearn;
namespace Graph
{
    public class GraphTheory
    {
        /// Given an undirected graph and some vertex index, find the size of the connected component of that vertex.
        /// https://codelearn.io/learning/thuat-toan-can-ban/3795
        public static int CountConnectedComponents(bool[,] adjacencyMatrix, int length)
        {
            List<Vertex> vertexs = new List<Vertex>();
            for (int i = 0; i < length; i++)
            {
                var adjacencyArray = new bool[length];
                for (int j = 0; j < length; j++)
                {
                    adjacencyArray[j] = adjacencyMatrix[i, j];
                }
                vertexs.Add(new Vertex(i, adjacencyArray));
            }
            int max = 0;
            for (int i = 0; i < vertexs.Count; i++)
            {
                bool[] visited = new bool[vertexs.Count];
                visited[i] = true;

                int[] numberConnectedComponents = new int[vertexs.Count];
                numberConnectedComponents[i] = 1;

                CheckNextAdjacencyPoint(i, vertexs, ref numberConnectedComponents, ref visited);

                int sum = 0;
                foreach (int number in numberConnectedComponents)
                {
                    sum += number;
                }
                if (sum > max)
                    max = sum;

            }

            return max;
        }

        public static void CheckNextAdjacencyPoint(int currentIndex, List<Vertex> adjacencyList, ref int[] counting, ref bool[] visited)
        {
            for (int i = 0; i < adjacencyList[currentIndex].AdjacencyArray.Length; i++)
            {
                if (i != currentIndex)
                {
                    visited[currentIndex] = true;
                    if (adjacencyList[currentIndex].AdjacencyArray[i] && !visited[i])
                    {
                        counting[i]++;
                        CheckNextAdjacencyPoint(i, adjacencyList, ref counting, ref visited);
                    }
                }
            }
        }
    }

}