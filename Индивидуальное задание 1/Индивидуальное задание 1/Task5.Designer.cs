namespace Индивидуальное_задание_1
{
    partial class Task5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Matrix_edges = new System.Windows.Forms.RichTextBox();
            this.list_of_adj_edges = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.list_of_adj_vertexes = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Matrix_vertex = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Matrix_edges
            // 
            this.Matrix_edges.BackColor = System.Drawing.Color.LavenderBlush;
            this.Matrix_edges.Location = new System.Drawing.Point(14, 174);
            this.Matrix_edges.Name = "Matrix_edges";
            this.Matrix_edges.Size = new System.Drawing.Size(330, 227);
            this.Matrix_edges.TabIndex = 0;
            this.Matrix_edges.Text = "";
            // 
            // list_of_adj_edges
            // 
            this.list_of_adj_edges.BackColor = System.Drawing.Color.LavenderBlush;
            this.list_of_adj_edges.Location = new System.Drawing.Point(422, 174);
            this.list_of_adj_edges.Name = "list_of_adj_edges";
            this.list_of_adj_edges.Size = new System.Drawing.Size(355, 227);
            this.list_of_adj_edges.TabIndex = 1;
            this.list_of_adj_edges.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(924, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ЗАДАНИЕ: Для неориентированного графа дана матрица смежности рёбер, построить спи" +
    "ски смежности графа.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(470, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Список смежности рёбер графа";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(57, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Матрица смежности рёбер графа";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(845, 106);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 62);
            this.button3.TabIndex = 6;
            this.button3.Text = "Список смежности вершин графа";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.List_adj_vertex_MouseClick);
            // 
            // list_of_adj_vertexes
            // 
            this.list_of_adj_vertexes.BackColor = System.Drawing.Color.LavenderBlush;
            this.list_of_adj_vertexes.Location = new System.Drawing.Point(801, 172);
            this.list_of_adj_vertexes.Margin = new System.Windows.Forms.Padding(2);
            this.list_of_adj_vertexes.Name = "list_of_adj_vertexes";
            this.list_of_adj_vertexes.Size = new System.Drawing.Size(347, 227);
            this.list_of_adj_vertexes.TabIndex = 7;
            this.list_of_adj_vertexes.Text = "";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(470, 454);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(269, 53);
            this.button4.TabIndex = 8;
            this.button4.Text = "Загрузить граф";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Matrix_vertex_MouseClick);
            // 
            // Matrix_vertex
            // 
            this.Matrix_vertex.BackColor = System.Drawing.Color.LavenderBlush;
            this.Matrix_vertex.Location = new System.Drawing.Point(422, 511);
            this.Matrix_vertex.Margin = new System.Windows.Forms.Padding(2);
            this.Matrix_vertex.Name = "Matrix_vertex";
            this.Matrix_vertex.Size = new System.Drawing.Size(355, 238);
            this.Matrix_vertex.TabIndex = 9;
            this.Matrix_vertex.Text = "";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(36, 486);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(219, 44);
            this.button5.TabIndex = 10;
            this.button5.Text = "Вернуться в меню";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Back_To_Menu);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(36, 557);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(219, 46);
            this.button6.TabIndex = 11;
            this.button6.Text = "Очистить поля";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clear_fields);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1226, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(693, 449);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1924, 792);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Matrix_vertex);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.list_of_adj_vertexes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_of_adj_edges);
            this.Controls.Add(this.Matrix_edges);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Task5";
            this.Text = "Задание 5";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Matrix_edges;
        private System.Windows.Forms.RichTextBox list_of_adj_edges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox list_of_adj_vertexes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox Matrix_vertex;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}