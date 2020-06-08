namespace Индивидуальное_задание_1
{
    partial class Task1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Matrix = new System.Windows.Forms.RichTextBox();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Menu_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(227, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(729, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЗАДАНИЕ: Дан взвешенный неориентированный связный граф. \r\n                   Пост" +
    "роить остов наименьшего веса с помощью алгоритма Дейкстры-Прима.";
            // 
            // Matrix
            // 
            this.Matrix.BackColor = System.Drawing.Color.LavenderBlush;
            this.Matrix.Location = new System.Drawing.Point(27, 181);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(359, 298);
            this.Matrix.TabIndex = 1;
            this.Matrix.Text = "";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.LavenderBlush;
            this.Result.Location = new System.Drawing.Point(770, 181);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(359, 298);
            this.Result.TabIndex = 3;
            this.Result.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(794, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Остов наименьшего веса";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(59, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Загрузить граф";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu_Button
            // 
            this.Menu_Button.BackColor = System.Drawing.Color.SkyBlue;
            this.Menu_Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu_Button.Location = new System.Drawing.Point(471, 196);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(227, 42);
            this.Menu_Button.TabIndex = 6;
            this.Menu_Button.Text = "Вернуться в меню";
            this.Menu_Button.UseVisualStyleBackColor = false;
            this.Menu_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Menu_Button_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1156, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 551);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(471, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "Очистить поля";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clear_fields);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1842, 921);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Menu_Button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.label1);
            this.Name = "Task1";
            this.Text = "Задание 1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Matrix;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Menu_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}