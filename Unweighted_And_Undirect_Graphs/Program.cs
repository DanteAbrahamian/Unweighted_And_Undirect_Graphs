namespace Unweighted_And_Undirect_Graphs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vertex<int> vertex = new Vertex<int>(1);
            Vertex<int> edvf = new Vertex<int>(3);
            Graph<int> graph = new Graph<int>();
            graph.AddVertex(vertex);
            graph.AddVertex(edvf);
            graph.AddEdge(vertex, edvf);
            graph.RemoveEdge(vertex, edvf);
            graph.RemoveVertex(vertex);
            ;
        }
    }
}
