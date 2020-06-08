namespace Индивидуальное_задание_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.task1 = new System.Windows.Forms.LinkLabel();
            this.task2 = new System.Windows.Forms.LinkLabel();
            this.task4 = new System.Windows.Forms.LinkLabel();
            this.task5 = new System.Windows.Forms.LinkLabel();
            this.Menu = new System.Windows.Forms.Label();
            this.task3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // task1
            // 
            this.task1.ActiveLinkColor = System.Drawing.Color.SkyBlue;
            this.task1.AutoSize = true;
            this.task1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.task1.LinkColor = System.Drawing.Color.Black;
            this.task1.Location = new System.Drawing.Point(36, 183);
            this.task1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(1042, 46);
            this.task1.TabIndex = 0;
            this.task1.TabStop = true;
            this.task1.Text = "1. Дан взвешенный неориентированный связный граф. Построить остов наименьшего вес" +
    "а с помощью алгоритма \r\nДейкстры-Прима.";
            this.task1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.task1_LinkClicked);
            // 
            // task2
            // 
            this.task2.ActiveLinkColor = System.Drawing.Color.SkyBlue;
            this.task2.AutoSize = true;
            this.task2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.task2.LinkColor = System.Drawing.Color.Black;
            this.task2.Location = new System.Drawing.Point(36, 275);
            this.task2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(630, 23);
            this.task2.TabIndex = 1;
            this.task2.TabStop = true;
            this.task2.Text = "2. Дан неориентированный связный граф. Найти Гамильтонов цикл.";
            this.task2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.task2_LinkClicked);
            // 
            // task4
            // 
            this.task4.ActiveLinkColor = System.Drawing.Color.SkyBlue;
            this.task4.AutoSize = true;
            this.task4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task4.LinkColor = System.Drawing.Color.Black;
            this.task4.Location = new System.Drawing.Point(36, 438);
            this.task4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.task4.Name = "task4";
            this.task4.Size = new System.Drawing.Size(817, 23);
            this.task4.TabIndex = 3;
            this.task4.TabStop = true;
            this.task4.Text = "4. Дан неориентированный граф. Построить произвольное максимальное паросочетание." +
    "";
            this.task4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.task4_LinkClicked);
            // 
            // task5
            // 
            this.task5.ActiveLinkColor = System.Drawing.Color.SkyBlue;
            this.task5.AutoSize = true;
            this.task5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task5.LinkColor = System.Drawing.Color.Black;
            this.task5.Location = new System.Drawing.Point(36, 510);
            this.task5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.task5.Name = "task5";
            this.task5.Size = new System.Drawing.Size(911, 23);
            this.task5.TabIndex = 4;
            this.task5.TabStop = true;
            this.task5.Text = "5. Для неориентированного графа дана матрица смежности рёбер. Построить списки см" +
    "ежности.";
            this.task5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.task5_LinkClicked);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Times New Roman", 34.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.ForeColor = System.Drawing.Color.SkyBlue;
            this.Menu.Location = new System.Drawing.Point(31, 102);
            this.Menu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(179, 65);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "Меню";
            // 
            // task3
            // 
            this.task3.ActiveLinkColor = System.Drawing.Color.SkyBlue;
            this.task3.AutoSize = true;
            this.task3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task3.LinkColor = System.Drawing.Color.Black;
            this.task3.Location = new System.Drawing.Point(36, 357);
            this.task3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(877, 23);
            this.task3.TabIndex = 6;
            this.task3.TabStop = true;
            this.task3.Text = "3.\t Дан неориентированный граф. Построить все максимальные независимые множества " +
    "графа.\r\n";
            this.task3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.task3_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(36, 577);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 23);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "6. Выход";
            this.linkLabel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exit_program);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1310, 796);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.task5);
            this.Controls.Add(this.task4);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Индивидуальное задание 1. Графы.";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel task1;
        private System.Windows.Forms.LinkLabel task2;
        private System.Windows.Forms.LinkLabel task4;
        private System.Windows.Forms.LinkLabel task5;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.LinkLabel task3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

