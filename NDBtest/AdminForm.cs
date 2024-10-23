using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDBtest
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void списокПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users ul = new Users();
            ul.MdiParent = this;
            ul.Show();
        }

        private void вариантыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variants v = new Variants();
            v.MdiParent = this;
            v.Show();
        }

        private void режимУчителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm teacher = new TeacherForm();
            teacher.ShowDialog();
        }

        private void разборТестовыхВариантовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.OpenDir("Разбор тестовых вариантов");
        }

        private void тестовыеШаблоныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.OpenDir("Тестовые шаблоны");
        }

        private void эталонныеВариантыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.OpenDir("Эталонные варианты");
        }

        private void решенияСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.OpenDir("Решения Студентов");
        }
    }
}
