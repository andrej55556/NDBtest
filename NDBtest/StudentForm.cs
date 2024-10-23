using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDBtest
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void выборВариантаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VariantChoose vc = new VariantChoose();
            vc.ShowDialog();
        }

        private void просмотрШаблоновToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenDir("Тестовые шаблоны");
        }

       

        private void просмотрРазборочногоВаринтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.OpenDir("Разбор тестовых вариантов");
        }

        private void просмотрТренировочныхШаблоновToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.OpenDir("Тестовые шаблоны");
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            //label_fio.Text = Global.fio;
            label_fio.Visible = false;
        }
    }
}
