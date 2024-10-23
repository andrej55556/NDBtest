namespace NDBtest
{
    partial class StudentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборВариантаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрШаблоновToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрРазборочногоВаринтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрТренировочныхШаблоновToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_fio = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тестToolStripMenuItem,
            this.просмотрШаблоновToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборВариантаToolStripMenuItem});
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.тестToolStripMenuItem.Text = "Проверочная";
            // 
            // выборВариантаToolStripMenuItem
            // 
            this.выборВариантаToolStripMenuItem.Name = "выборВариантаToolStripMenuItem";
            this.выборВариантаToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.выборВариантаToolStripMenuItem.Text = "Выбор варианта";
            this.выборВариантаToolStripMenuItem.Click += new System.EventHandler(this.выборВариантаToolStripMenuItem_Click);
            // 
            // просмотрШаблоновToolStripMenuItem
            // 
            this.просмотрШаблоновToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрРазборочногоВаринтаToolStripMenuItem,
            this.просмотрТренировочныхШаблоновToolStripMenuItem});
            this.просмотрШаблоновToolStripMenuItem.Name = "просмотрШаблоновToolStripMenuItem";
            this.просмотрШаблоновToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.просмотрШаблоновToolStripMenuItem.Text = "Тренировка";
            this.просмотрШаблоновToolStripMenuItem.Click += new System.EventHandler(this.просмотрШаблоновToolStripMenuItem_Click);
            // 
            // просмотрРазборочногоВаринтаToolStripMenuItem
            // 
            this.просмотрРазборочногоВаринтаToolStripMenuItem.Name = "просмотрРазборочногоВаринтаToolStripMenuItem";
            this.просмотрРазборочногоВаринтаToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.просмотрРазборочногоВаринтаToolStripMenuItem.Text = "Просмотр разборочного варинта";
            this.просмотрРазборочногоВаринтаToolStripMenuItem.Click += new System.EventHandler(this.просмотрРазборочногоВаринтаToolStripMenuItem_Click);
            // 
            // просмотрТренировочныхШаблоновToolStripMenuItem
            // 
            this.просмотрТренировочныхШаблоновToolStripMenuItem.Name = "просмотрТренировочныхШаблоновToolStripMenuItem";
            this.просмотрТренировочныхШаблоновToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.просмотрТренировочныхШаблоновToolStripMenuItem.Text = "Просмотр тренировочных шаблонов";
            this.просмотрТренировочныхШаблоновToolStripMenuItem.Click += new System.EventHandler(this.просмотрТренировочныхШаблоновToolStripMenuItem_Click);
            // 
            // label_fio
            // 
            this.label_fio.AutoSize = true;
            this.label_fio.Location = new System.Drawing.Point(730, 9);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(58, 16);
            this.label_fio.TabIndex = 3;
            this.label_fio.Text = "label_fio";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_fio);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentForm";
            this.Text = "Студент";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборВариантаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрШаблоновToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрРазборочногоВаринтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрТренировочныхШаблоновToolStripMenuItem;
        private System.Windows.Forms.Label label_fio;
    }
}