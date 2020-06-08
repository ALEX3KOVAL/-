using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphClass;

namespace AlgorithmsOnGraphsClass
{
    public class AlgorithmsOnGraphs
    {
        private
               Graph graph;
        public AlgorithmsOnGraphs(RichTextBox box)
        {
            graph = new Graph(box);
        }

        public bool CheckingForCorrectness()
        {
            return graph.checkCorrectlyMatrix;
        }
        public class Edge
        {
            private int v1, v2, weight;
            public Edge(int v1, int v2, int weight)
            {
                this.v1 = v1;
                this.v2 = v2;
                this.weight = weight;
            }
            public int get_elem(string str)
            {
                if (str == "v1") return this.v1;
                else if (str == "v2") return this.v2;
                else return this.weight;
            }
        }
        /// <summary>
        /// Проверка на содержание петлей в графе
        /// </summary>
        /// <returns></returns>
        public bool CheckLoop()
        {
            bool check = new bool();
            for (int i = 0; i < graph.CountOfVertex(); i++)
                if (graph.ExistEdge(i, i)) check = true;
            return check;
        }
        /// <summary>
        /// Проверка графа на неориентированность рёбер
        /// </summary>
        /// <returns></returns>
        public bool CheckUndirected()
        {
            for (int i = 0; i < graph.CountOfVertex(); i++)
                for (int j = 0; j < graph.CountOfVertex(); j++)
                    if (graph.ExistEdge(i, j))
                        if (!graph.ExistEdge(j, i)) return false;
            return true;
        }

        /// <summary>
        /// Осуществляет поиск в глубину в графе
        /// </summary>
        /// <param name="v"></param>
        /// <param name="visited"></param>
        private void DFS(int v, bool[] visited)
        {
            int countVertex = graph.CountOfVertex();
            Stack<int> vertex = new Stack<int>();
            vertex.Push(v);
            visited[v] = true;

            while (vertex.Count != 0)
            {
                int currentVertex = vertex.Pop();
                for (int i = 0; i < countVertex; i++)
                {
                    if (graph.ExistEdge(currentVertex, i) && !visited[i])
                    {
                        vertex.Push(currentVertex);
                        currentVertex = i;
                        visited[i] = true;
                        i = -1;
                    }
                }
            }
        }
        /// <summary>
        /// Считает количество компонент связности
        /// </summary>
        /// <returns></returns>
        public int CountComponents()
        {
            if (CheckUndirected())
            {
                bool[] visited = new bool[graph.CountOfVertex()];
                int K = new int();
                for (int i = 0; i < graph.CountOfVertex(); i++)
                {
                    if (!visited[i])
                    {
                        K++;
                        DFS(i, visited);
                    }
                }
                return K;
            }
            else return -1;
        }
        /// <summary>
        /// Проверка на непосещённость вершины в графе
        /// </summary>
        /// <returns></returns>
        private bool vizit(bool[] visited, int N)
        {
            bool f = false;
            for (int i = 0; i < N; i++)
            {
                if (!visited[i]) f = true;
            }
            return f;
        }
        /// <summary>
        /// Строит все максимальные независимые множества графа
        /// </summary>
        /// <returns></returns>
        public void MIS(List<int> R, List<int> P, List<int> X, List<List<int>> max)
        {
            if (P.Count == 0 && X.Count == 0)
            {
                max.Add(R);
            }
            else
            {
                while (P.Count > 0)
                {
                    int v = P.First();
                    List<int> P1 = new List<int>(P);
                    List<int> X1 = new List<int>(X);
                    List<int> R1 = new List<int>(R);
                    List<int> listver = new List<int>(graph.Create_List_Of_AdjWith(v));
                    R1.Add(v);
                    for (int i = 0; i < listver.Count; i++)
                    {
                        P1.Remove(listver[i]);
                        X1.Remove(listver[i]);
                    }
                    P1.Remove(v);
                    MIS(R1, P1, X1, max);
                    P.Remove(v);
                    X.Add(v);
                }
            }
        }

        private string[] Int_Array_To_Str(int[] arr)
        {
            string[] str = Array.ConvertAll(arr, x => x.ToString());
            return str;
        }

        public List<Edge> Dijkstra_Prim()
        {
            List<Edge> MST = new List<Edge>();
            List<Edge> edges_list = new List<Edge>();
            List<int> used_vertexes_list = new List<int>();
            List<int> unused_vertexes_list = new List<int>();
            for (int i = 0; i < graph.CountOfVertex(); i++)
            {
                unused_vertexes_list.Add(i);
                string[] str = Int_Array_To_Str(graph.Get_Line(i));
                for (int j = 0; j < graph.CountOfVertex(); j++)
                {
                    if (str[j] != "0")
                    {
                        edges_list.Add(new Edge(i, j, Int32.Parse(str[j])));
                    }
                }
            }
            used_vertexes_list.Add(0);
            unused_vertexes_list.RemoveAt(0);
            for (; unused_vertexes_list.Count > 0;)
            {
                int min_edge_number = -1;
                for (int j = 0; j < edges_list.Count; j++)
                {
                    if ((used_vertexes_list.IndexOf(edges_list[j].get_elem("v1")) != -1) && (unused_vertexes_list.IndexOf(edges_list[j].get_elem("v2")) != -1) ||
                        (used_vertexes_list.IndexOf(edges_list[j].get_elem("v2")) != -1) && (unused_vertexes_list.IndexOf(edges_list[j].get_elem("v1")) != -1))
                    {
                        if (min_edge_number != -1)
                        {
                            if (edges_list[j].get_elem("w") < edges_list[min_edge_number].get_elem("w"))
                            {
                                min_edge_number = j;
                            }
                        }
                        else
                        {
                            min_edge_number = j;
                        }
                    }
                }
                if (used_vertexes_list.IndexOf(edges_list[min_edge_number].get_elem("v1")) != -1)
                {
                    used_vertexes_list.Add(edges_list[min_edge_number].get_elem("v2"));
                    unused_vertexes_list.Remove(edges_list[min_edge_number].get_elem("v2"));
                }
                else
                {
                    used_vertexes_list.Add(edges_list[min_edge_number].get_elem("v1"));
                    unused_vertexes_list.Remove(edges_list[min_edge_number].get_elem("v1"));
                }
                MST.Add(edges_list[min_edge_number]);
                edges_list.RemoveAt(min_edge_number);
            }
            return MST;
        }

        public int gamilton(int[] c, int[] path, int n, int k)
        {
            int q1 = 0;
            for (int v = 0; ((v < n) && q1 == 0); v++)
            {
                if (graph.ExistEdge(v, path[k - 1]) || graph.ExistEdge(path[k - 1], v))
                {
                    if (k == n && v == 0)
                    {
                        q1 = 1;
                    }
                    else if (c[v] == -1)
                    {
                        c[v] = k;
                        path[k] = v;
                        q1 = gamilton(c, path, n, k + 1);
                        if (q1 == 0)
                        {
                            c[v] = -1;
                        }
                    }
                    else continue;
                }
            }
            return q1;
        }

        public List<string> Max_matching()
        {
            List<string> ParoSochet = new List<string>();
            bool[] visited = new bool[graph.CountOfVertex()];
            for (int ind = 0; ind < graph.CountOfVertex(); ind++)
            {
                visited[ind] = false;
            }
            while (vizit(visited, graph.CountOfVertex()))
            {
                int i = graph.Min_Degree_Index(visited);
                for (int j = 0; j < graph.CountOfVertex(); j++)
                {
                    if (graph.ExistEdge(i, j) == true)
                    {
                        if (visited[i] == false && visited[j] == false)
                        {
                            visited[i] = true;
                            visited[j] = true;
                            string s = "( " + i.ToString() + " ," + j.ToString() + ") ";
                            ParoSochet.Add(s);
                        }
                    }
                }
                visited[i] = true;
            }
            return ParoSochet;
        }
        public List<int> Create_List_Of_Vertexes()
        {
            List<int> list_of_vertexes = new List<int>();
            for (int i = 0; i < graph.CountOfVertex(); i++)
                list_of_vertexes.Add(i);
            return list_of_vertexes;
        }
        public int Count_Of_Vertexes()
        {
            return graph.CountOfVertex();
        }
    }
    
}