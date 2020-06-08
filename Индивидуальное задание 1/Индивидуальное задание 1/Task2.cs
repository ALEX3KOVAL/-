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

namespace Индивидуальное_задание_1
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
            label1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button2.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlgorithmsOnGraphs g = new AlgorithmsOnGraphs(Matrix);
            if (!g.CheckingForCorrectness()) Result.Text += "Это некорректный граф";
            else { 
                if (g.CountComponents() == 0 || !g.CheckUndirected() || g.CheckLoop()) Result.Text = "ГРАФ НЕКОРРЕКТЕН!!!";
                else
                {
                    int[] c = new int[g.Count_Of_Vertexes()];
                    for (int i = 0; i < g.Count_Of_Vertexes(); i++) c[i] = -1;
                    int[] path = new int[g.Count_Of_Vertexes()];
                    c[0] = 0;
                    path[0] = 0;
                    if (g.gamilton(c, path, g.Count_Of_Vertexes(), 1) != 0)
                    {
                        for (int i = 0; i < g.Count_Of_Vertexes(); i++)
                        {
                            Result.Text += path[i].ToString() + "  ";
                        }
                        Result.Text += path[0].ToString() + "\n";
                    }
                    else Result.Text += "НЕТ ЦИКЛА!!\n";
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Answer.txt", true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Гамильтонов цикл:");
                    }
                    File.WriteAnswer(Result);
                }
            }
        }

        private void Load_inf(object sender, MouseEventArgs e)
        {
            string str = File.ReadGraph(Matrix);
            string str1 = str.Trim(new char[] { 't', 'x', 't' }) + "png";
            pictureBox1.ImageLocation = str1;
            pictureBox1.Show();
        }

        private void Clear_fields(object sender, MouseEventArgs e)
        {
            Matrix.Clear();
            Result.Clear();
            pictureBox1.Hide();
        }

        private void Back_To_Menu(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
    }
}
