using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Индивидуальное_задание_1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class File
    {
        static public string ReadGraph(RichTextBox Box)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.InitialDirectory = "C:\\Users\\User\\Documents\\";
            OFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            OFD.FilterIndex = 2;
            var FilePath = string.Empty;
            OFD.RestoreDirectory = true;
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                FilePath = OFD.FileName;
                var FileStream = OFD.OpenFile();
                using (StreamReader reader = new StreamReader(FileStream))
                {
                    Box.Text = reader.ReadToEnd();
                }
            }
            MessageBox.Show("Succesful file opening", "Message", MessageBoxButtons.OK);
            return FilePath;
        }

        static public void WriteAnswer(RichTextBox Box)
        {
            using (StreamWriter sw = new StreamWriter("Answer.txt",true,System.Text.Encoding.Default))
            {
                sw.WriteLine(Box.Text);
                sw.WriteLine("\n");
            }
        }
    }
}
