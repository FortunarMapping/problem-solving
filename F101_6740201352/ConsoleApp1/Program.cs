using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_Traversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vertex_list = new string[] { "A", "B", "C", "E" };
            int[,] adj_list = new int[,] { { 0, 0, 0, 1 }, { 0, 0, 1, 1 }, { 0, 1, 0, 1 }, { 1, 1, 1, 0 } };
            Console.WriteLine("\nBFS Traversal");
            BFSTraversal(vertex_list, adj_list);
        }
        static void BFSTraversal(string[] vertex_list, int[,] adj_list)
        {
            Queue Q = new Queue();
            int[] check_list = new int[vertex_list.Length];
            for (int i = 0; i < check_list.Length; ++i)
                check_list[i] = 0;
            int vertex = 0;
            string traversal = vertex_list[vertex];
            check_list[vertex] = 1;
            int k = 1;
            while (k < adj_list.GetLength(0))
            {
                for (int j = 0; j < adj_list.GetLength(1); ++j)
                {
                    if ((adj_list[vertex, j] != 0) && (check_list[j] == 0) && (!Q.Contains(j)))
                        Q.Enqueue(j);
                }
                vertex = (int)Q.Dequeue();
                traversal += " " + vertex_list[vertex];
                check_list[vertex] = 1;
                ++k;
            }
            Console.WriteLine(traversal);
        }

    }
}
