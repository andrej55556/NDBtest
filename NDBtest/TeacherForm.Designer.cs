﻿namespace NDBtest
{
    partial class TeacherForm
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
            this.label_fio = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ответыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеВариантаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаСтудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_fio
            // 
            this.label_fio.AutoSize = true;
            this.label_fio.Location = new System.Drawing.Point(730, 9);
            this.label_fio.Name = "label_fio";
            this.label_fio.Size = new System.Drawing.Size(58, 16);
            this.label_fio.TabIndex = 1;
            this.label_fio.Text = "label_fio";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.данныеВариантаToolStripMenuItem,
            this.проверкаСтудентовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ответыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // ответыToolStripMenuItem
            // 
            this.ответыToolStripMenuItem.Name = "ответыToolStripMenuItem";
            this.ответыToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.ответыToolStripMenuItem.Text = "Варианты";
            this.ответыToolStripMenuItem.Click += new System.EventHandler(this.ответыToolStripMenuItem_Click);
            // 
            // данныеВариантаToolStripMenuItem
            // 
            this.данныеВариантаToolStripMenuItem.Name = "данныеВариантаToolStripMenuItem";
            this.данныеВариантаToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.данныеВариантаToolStripMenuItem.Text = "Данные варианта";
            // 
            // проверкаСтудентовToolStripMenuItem
            // 
            this.проверкаСтудентовToolStripMenuItem.Name = "проверкаСтудентовToolStripMenuItem";
            this.проверкаСтудентовToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.проверкаСтудентовToolStripMenuItem.Text = "Проверка студентов";
            this.проверкаСтудентовToolStripMenuItem.Click += new System.EventHandler(this.проверкаСтудентовToolStripMenuItem_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_fio);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherForm";
            this.Text = "Преподаватель";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_fio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ответыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem данныеВариантаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проверкаСтудентовToolStripMenuItem;
    }
}