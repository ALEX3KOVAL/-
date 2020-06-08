using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using AlgorithmsOnGraphsClass;

namespace Индивидуальное_задание_1
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            label1.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button2.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            button1.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            AlgorithmsOnGraphs g = new AlgorithmsOnGraphs(Matrix);
            if (g.CheckingForCorrectness() == false)
            {
                Matrix.Clear();
            }
            else
            {
                if (g.CountComponents() != 0 || g.CheckUndirected() || !g.CheckLoop())
                {
                    List<AlgorithmsOnGraphs.Edge> MST = new List<AlgorithmsOnGraphs.Edge>(g.Dijkstra_Prim());
                    for (int i = 0; i < MST.Count; i++)
                    {
                        Result.Text += MST[i].get_elem("v1").ToString() + "  -  " + MST[i].get_elem("v2").ToString() + "\n";
                    }
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Answer.txt", true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Остов минимального веса:\n");
                    }
                    File.WriteAnswer(Result);
                }
                else
                {
                    MessageBox.Show("Матрица введена неверно", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Matrix.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = File.ReadGraph(Matrix);
            string str1 = str.Trim(new char[] { 't', 'x', 't' }) + "png";
            pictureBox1.ImageLocation = str1;
            pictureBox1.Show();
        }

        private void Menu_Button_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void Clear_fields(object sender, MouseEventArgs e)
        {
            Matrix.Clear();
            Result.Clear();
            pictureBox1.Hide();
        }
    }
}
