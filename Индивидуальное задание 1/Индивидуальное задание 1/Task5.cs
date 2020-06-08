using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgorithmsOnGraphsClass;
using GraphClass;

namespace Индивидуальное_задание_1
{
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
            label1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button2.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(Matrix_vertex);
            List<List<int>> edges_list = new List<List<int>>(graph.List_of_edges());
            int[,] graph_adj_edges_matrix = graph.Create_Matrix_Of_Adj_Edges(edges_list);
            SortedDictionary<string, List<List<int>>> graph_adj_edges_dict = new SortedDictionary<string, List<List<int>>>(graph.Create_Dict_Of_Adj_Edges(graph_adj_edges_matrix, edges_list));
            list_of_adj_edges.Text += "Список смежных рёбер имеет следующий вид:\n";
            for (int i = 0; i < graph_adj_edges_dict.Count; i++)
            {
                list_of_adj_edges.Text += graph_adj_edges_dict.Keys.ElementAt(i) + "---->";
                for (int j = 0; j < graph_adj_edges_dict.Values.ElementAt(i).Count; j++)
                {
                    for (int k = 0; k < graph_adj_edges_dict.Values.ElementAt(i)[j].Count; k++)
                    {
                        list_of_adj_edges.Text += graph_adj_edges_dict.Values.ElementAt(i)[j][k].ToString();
                    }
                    list_of_adj_edges.Text += "   ";
                }
                list_of_adj_edges.Text += "\n";
            }
            File.WriteAnswer(list_of_adj_edges);
        }
            private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            AlgorithmsOnGraphs g = new AlgorithmsOnGraphs(Matrix_vertex);
            if (g.CheckingForCorrectness())
            {
                if (g.CountComponents() == 0) list_of_adj_edges.Text = "Это не подходящий граф";
                else
                {
                    Matrix_edges.Text += "Матрица рёбер имеет следующий вид:\n";
                    Graph graph = new Graph(Matrix_vertex);
                    List<List<int>> edges_list = new List<List<int>>(graph.List_of_edges());
                    int[,] graph_adj_edges_matrix = graph.Create_Matrix_Of_Adj_Edges(edges_list);
                    for (int i = 0; i < graph_adj_edges_matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < graph_adj_edges_matrix.GetLength(1); j++)
                        {
                            Matrix_edges.Text += graph_adj_edges_matrix[i, j] + "  ";
                        }
                        Matrix_edges.Text += "\n";
                    }
                }
            }
        }
        private void Matrix_vertex_MouseClick(object sender, MouseEventArgs e)
        {
            string str = File.ReadGraph(Matrix_vertex);
            string str1 = str.Trim(new char[] { 't', 'x', 't' }) + "png";
            pictureBox1.ImageLocation = str1;
            pictureBox1.Show();
        }

        private void List_adj_vertex_MouseClick(object sender, MouseEventArgs e)
        {
            list_of_adj_vertexes.Text = "Список смежных вершин имеет следующий вид:\n";
            Graph graph = new Graph(Matrix_vertex);
            List<List<int>> edges_list = new List<List<int>>(graph.List_of_edges());
            int[,] graph_adj_edges_matrix = graph.Create_Matrix_Of_Adj_Edges(edges_list);
            SortedDictionary<string, List<List<int>>> graph_adj_edges_dict = new SortedDictionary<string, List<List<int>>>(graph.Create_Dict_Of_Adj_Edges(graph_adj_edges_matrix, edges_list));
            SortedDictionary<int, List<int>> graph_adj_vertex_dict = new SortedDictionary<int, List<int>>(graph.Create_Dict_Of_Adj_Vertexes(graph_adj_edges_dict));
            for (int i = 0; i < graph_adj_vertex_dict.Count; i++)
            {
                list_of_adj_vertexes.Text += graph_adj_vertex_dict.Keys.ElementAt(i).ToString() + "---->  ";
                for (int j = 0; j < graph_adj_vertex_dict.Values.ElementAt(i).Count; j++)
                    list_of_adj_vertexes.Text += graph_adj_vertex_dict.Values.ElementAt(i)[j].ToString() + "  ";
                list_of_adj_vertexes.Text += "\n";
            }
            File.WriteAnswer(list_of_adj_vertexes);
        }

        private void Back_To_Menu(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void Clear_fields(object sender, MouseEventArgs e)
        {
            Matrix_vertex.Clear();
            Matrix_edges.Clear();
            list_of_adj_edges.Clear();
            list_of_adj_vertexes.Clear();
        }
    }
}