namespace Индивидуальное_задание_1
{
    partial class Task2
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
            this.button2 = new System.Windows.Forms.Button();
            this.Matrix = new System.Windows.Forms.RichTextBox();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Menu_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.2F);
            this.label1.Location = new System.Drawing.Point(229, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(638, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЗАДАНИЕ: Дан неориентированный связный граф. Найти Гамильтонов цикл.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(767, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Гамильтонов цикл";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Matrix
            // 
            this.Matrix.BackColor = System.Drawing.Color.LavenderBlush;
            this.Matrix.Location = new System.Drawing.Point(24, 171);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(368, 288);
            this.Matrix.TabIndex = 3;
            this.Matrix.Text = "";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.LavenderBlush;
            this.Result.Location = new System.Drawing.Point(737, 171);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(352, 288);
            this.Result.TabIndex = 4;
            this.Result.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(68, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Загрузить граф";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Load_inf);
            // 
            // Menu_Button
            // 
            this.Menu_Button.BackColor = System.Drawing.Color.SkyBlue;
            this.Menu_Button.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu_Button.Location = new System.Drawing.Point(456, 183);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(233, 41);
            this.Menu_Button.TabIndex = 6;
            this.Menu_Button.Text = "Вернуться в меню";
            this.Menu_Button.UseVisualStyleBackColor = false;
            this.Menu_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Back_To_Menu);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1193, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 555);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SkyBlue;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(456, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 41);
            this.button3.TabIndex = 8;
            this.button3.Text = "Очистить поля";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clear_fields);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1791, 844);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Menu_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "Task2";
            this.Text = "Задание 2";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox Matrix;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Menu_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}