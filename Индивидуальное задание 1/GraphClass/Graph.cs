using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphClass
{
    public class Graph
    {
        private int[,] Matrix;
        public bool checkCorrectlyMatrix; 
        public Graph(RichTextBox box)
        {
            checkCorrectlyMatrix = true;
            string[] text = box.Text.Split('\n');
            Matrix = new int[box.Lines.Length, box.Lines[0].Length];
            CreateMatrix(text);
        }
        /// <summary>
        /// Возвращает количество вершин в графе
        /// </summary>
        /// <returns></returns>
        public int CountOfVertex()
        {
            return Matrix.GetLength(0);
        }
        /// <summary>
        /// Возвращает количество ребер
        /// </summary>
        /// <returns></returns>
        public int CountOfEdge()
        {
            int count = new int();
            for (int i = 0; i < CountOfVertex(); i++)
                for (int j = 0; j < CountOfVertex(); j++)
                    if (Matrix[i,j] >= 1)
                    {
                        if (!(Matrix[j,i] >= 1) || j == i) count++;
                        else if (i < j) count++;
                    }
            return count;
        }
        /// <summary>
        /// Проверяет, существует ли ребро между двумя вершинами
        /// </summary>
        /// <param name="v"></param>
        /// <param name="u"></param>
        /// <returns></returns>
        public bool ExistEdge(int v, int u)
        {
            if (Matrix[v,u] != 0) return true;
            else return false;
        }
        private void CreateMatrix(string[] text)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                string[] elements = text[i].Split(' ');

                if (elements.Length != text.Length || !checkCorrectlyMatrix)
                {
                    checkCorrectlyMatrix = false;
                    MessageBox.Show("Матрица введена неверно", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    for (int j = 0; j < Matrix.GetLength(0) && checkCorrectlyMatrix; j++)
                    {
                        if ( elements[j] !="" && int.Parse(elements[j]) >= 0)
                            Matrix[i,j] = int.Parse(elements[j]);
                        else
                        {
                            checkCorrectlyMatrix = false;
                            MessageBox.Show("Матрица введена неверно", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Создает список смежности вершин по матрице смежности вершин
        /// </summary>
        /// <returns></returns>
        public List<List<int>> CreateListAdj()
        {
            List<List<int>> ListAdj = new List<List<int>>();
            for (int i = 0; i < Matrix.Length; i++)
            {
                var Adj = new List<int>();
                for (int j = 0; j < Matrix.GetLength(0); j++)
                {
                    if (Matrix[i,j] >= 1) Adj.Add(j);
                }
                ListAdj.Add(Adj);
            }
            return ListAdj;
        }
        /// <summary>
        /// Создает список вершин, смежных с данной вершиной
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public List<int> Create_List_Of_AdjWith(int v)
        {
            List<int> listver = new List<int>();
            for (int i = 0; i < Matrix.GetLength(1); i++)
                if (Matrix[v,i] >= 1) listver.Add(i);
            return listver;
        }
        /// <summary>
        /// Получает степень вершины по матрице смежности вершин
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public int DegreeOfVertex(int v)
        {
            int degree = 0;
            for (int i = 0; i < Matrix.GetLength(1); i++)
                if (Matrix[v, i] >= 1) degree++;
            return degree;
        }
        /// <summary>
        /// Создаёт список рёбер графа
        /// </summary>
        /// <returns></returns>
        public List<List<int>> List_of_edges()
        {
            int h = 0;
            List<List<int>> vertexes = new List<List<int>>();
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = h; j < Matrix.GetLength(1); j++)
                {
                    List<int> elem = new List<int>();
                    if (Matrix[i,j] >= 1)
                    {
                        elem.Add(i);
                        elem.Add(j);
                        vertexes.Add(elem);
                    }
                }
                h++;
            }
            return vertexes;
        }
        /// <summary>
        /// Создаёт матрицу смежности рёбер по списку рёбер
        /// </summary>
        /// /// <param name="vertexes"></param>
        /// <returns></returns>
        public int[,] Create_Matrix_Of_Adj_Edges(List<List<int>> vertexes)
        {
            int[,] adj_edges_matrix = new int[vertexes.Count, vertexes.Count];
            for (int i = 0; i < vertexes.Count; i++)
                for (int j = 0; j < vertexes.Count; j++) adj_edges_matrix[i, j] = 0;
            List<List<int>> adj = new List<List<int>>(vertexes);
            for (int x = 0; x < adj.Count; x++)
            {
                if (vertexes.Any())
                {
                    for (int i = 0; i < vertexes.Count; i++)
                    {
                        if (vertexes[i][0] == adj[x][1] && adj[x][0] != vertexes[i][1])
                        {
                            adj_edges_matrix[x, i] = 1;
                        }
                        if (vertexes[i][1] == adj[x][1] && vertexes[i][0] != adj[x][0]) adj_edges_matrix[x, i] = 1;
                        if (vertexes[i][0] == adj[x][0] && vertexes[i][1] != adj[x][1]) adj_edges_matrix[x, i] = 1;
                        if (vertexes[i][1] == adj[x][0] && vertexes[i][0] != adj[x][1]) adj_edges_matrix[x, i] = 1; 
                    }
                }
            }
            int h = 1;
            for (int i = 1; i < adj_edges_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < h; j++)
                    adj_edges_matrix[i, j] = adj_edges_matrix[j, i];
                h++;
            }
            return adj_edges_matrix;
        }
        /// <summary>
        /// Создаёт словарь смежности рёбер графа по матрице смежности рёбер графа
        /// </summary>
        /// <returns></returns>
        public SortedDictionary<string, List<List<int>>> Create_Dict_Of_Adj_Edges(int[,] adj_edges_matrix, List<List<int>> vertexes)
        {
            SortedDictionary<string, List<List<int>>> adj_edges_list = new SortedDictionary<string, List<List<int>>>();
            for (int i = 0; i < adj_edges_matrix.GetLength(0); i++)
            {
                List<List<int>> elem = new List<List<int>>();
                for (int j = 0; j < adj_edges_matrix.GetLength(1); j++)
                {
                    if (adj_edges_matrix[i, j] >= 1) elem.Add(vertexes[j]);
                }
                adj_edges_list.Add((vertexes[i][0].ToString() + vertexes[i][1].ToString()), elem);
            }
            return adj_edges_list;
        }
        /// <summary>
        /// Создаёт словарь смежности вершин графа по словарю смежности рёбер графа
        /// </summary>
        /// <param name="adj_edges_list"></param>
        /// <returns></returns>
        public SortedDictionary<int, List<int>> Create_Dict_Of_Adj_Vertexes(SortedDictionary<string, List<List<int>>> adj_edges_list)
        {
            SortedDictionary<int, List<int>> adj_vertexes_list = new SortedDictionary<int, List<int>>();
            for (int i = 0; i < adj_edges_list.Count; i++)
            {
                int key = int.Parse(adj_edges_list.Keys.ElementAt(i)[0].ToString());
                int key1 = int.Parse(adj_edges_list.Keys.ElementAt(i)[1].ToString());
                if (adj_vertexes_list.ContainsKey(key) && adj_vertexes_list[key].Contains(int.Parse(adj_edges_list.Keys.ElementAt(i)[1].ToString())) == false)
                {
                    adj_vertexes_list[key].Add(int.Parse(adj_edges_list.Keys.ElementAt(i)[1].ToString()));
                }
                else if (!(adj_vertexes_list.ContainsKey(key)))
                {
                    List<int> tmp = new List<int>();
                    tmp.Add(int.Parse(adj_edges_list.Keys.ElementAt(i)[1].ToString()));
                    adj_vertexes_list.Add(key, tmp);
                }
                if (adj_vertexes_list.ContainsKey(key1) && adj_vertexes_list[key1].Contains(int.Parse(adj_edges_list.Keys.ElementAt(i)[0].ToString())) == false)
                {
                    adj_vertexes_list[key1].Add(int.Parse(adj_edges_list.Keys.ElementAt(i)[0].ToString()));
                }
                else if (!(adj_vertexes_list.ContainsKey(key1)))
                {
                    List<int> tmp = new List<int>();
                    tmp.Add(int.Parse(adj_edges_list.Keys.ElementAt(i)[0].ToString()));
                    adj_vertexes_list.Add(key1, tmp);
                }
            }
            return adj_vertexes_list;
        }
        /// <summary>
        /// Возвращает индекс вершины с минимальной степенью
        /// </summary>
        /// <param name="visited"></param>
        /// <returns></returns>
        public int Min_Degree_Index(bool[] visited)
        {
            int Degree = Matrix.GetLength(1);
            int Index = Matrix.GetLength(1);
            int graph_degree = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                graph_degree = 0;
                for (int j = 0; j < Matrix.GetLength(1); j++)
                    if (Matrix[i, j] >= 1) graph_degree++;
                if (visited[i] == false)
                    if (graph_degree < Degree)
                    {
                        Index = i;
                        Degree = graph_degree;
                    }
            }
            return Index;
        }
        public int[] Get_Line(int v)
        {
            int[] arr = new int[Matrix.GetLength(1)];
            for (int i = 0; i < Matrix.GetLength(1); i++)
                arr[i] = Matrix[v, i];
            return arr;
        }
    }
}
