using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Unweighted_And_Undirect_Graphs
{
    public class Graph<T>
    {
        Vertex<T> vertex = new Vertex<T>(default);
        List<Vertex<T>> list = new List<Vertex<T>>();
        int count;
        public bool AddVertex(Vertex<T> vertex)
        {
            if (vertex != null)
            {
                list.Add(vertex);
                count++;
                return true;
            }
            else
            {
                return false;
            }
        }
        // - Returns true if the addition succeeded, false otherwise
        //
        // - It should only succeed if the vertex is not null and it
        //   hasn't already been added to the graph.

        public bool RemoveVertex(Vertex<T> vertex)
        {
            if (vertex != null)
            {
                list.Remove(vertex);
                return true;
            }
            else
            {
                return false;
            }
        }
        // - Returns true if the removal succeeded, false otherwise
        //
        // - It should only succeed if the vertex exists in your graph
        //   and you remove all edges/connections to it.

        public bool AddEdge(Vertex<T> a, Vertex<T> b)
        {
            if (a != null && b != null)
            {
                a.Neighbors.Add(b);
                b.Neighbors.Add(a);
                return true;
            }
            else
            {
                return false;
            }
        }
        // - Returns true if the addition succeeded, false otherwise
        //
        // - It should only succeed if both vertices are not null and
        //   exist in the graph. Remember to make the connection mutual.

        public bool RemoveEdge(Vertex<T> a, Vertex<T> b)
        {
            if (a != null & b is not null)
            {
                a.Neighbors.Remove(b);
                b.Neighbors.Remove(a);
                return true;
            }
            else
            {
                return false;
            }
        }
        // - Returns true if the removal succeeded, false otherwise
        //
        // - It should only succeed if both vertices are not null, exist
        //   in the list, and are each other's neighbor.

        Vertex<T> Search(T value)
        {
            for (int index = 0; index < count; index++)
            {
                if (list[index].Value.Equals(value))
                {
                    return list[index];
                }
            }
            return null;
        }
        // - Returns the vertex with the given value, or null if the
        //   vertex doesn't exist in the graph.
    }
}
