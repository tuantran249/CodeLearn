namespace Graph
{
    public class Vertex
    {
        public int Index { get; set; }

        public bool[] AdjacencyArray { get; set; }

        public Vertex(int index, bool[] adjacencyArray)
        {
            AdjacencyArray = adjacencyArray;
        }
    }
}
