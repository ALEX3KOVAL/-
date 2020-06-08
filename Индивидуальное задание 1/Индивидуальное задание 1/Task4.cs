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
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }
        private string CreateStr(List<string> cicles)
        {
            string s = "";
            for (int i = 0; i < cicles.LongCount(); i++)
                s += cicles[i];
            return s;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AlgorithmsOnGraphs g = new AlgorithmsOnGraphs(Matrix);
            if (g.CheckingForCorrectness())
            {
                if (g.CountComponents() == 0 || !g.CheckUndirected() || g.CheckLoop()) Result.Text += "ГРАФ НЕКОРРЕКТЕН!!!";
                else
                {
                    Result.Text = "{ " + CreateStr(g.Max_matching()) + " }";
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Answer.txt", true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Произвольное максимальное паросочетание:");
                    }
                    File.WriteAnswer(Result);
                }
            }
            else Result.Text += "Это некорректный граф!!";
            }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = File.ReadGraph(Matrix);
            string str1 = str.Trim(new char[] { 't', 'x', 't' }) + "png";
            pictureBox1.ImageLocation = str1;
            pictureBox1.Show();
        }

        private void Back_To_Menu(object sender, MouseEventArgs e)
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
