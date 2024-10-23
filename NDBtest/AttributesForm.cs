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
    public partial class AttributesForm : Form
    {
        public AttributesForm()
        {
            InitializeComponent();
        }

        /*private void просмотрToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Attributes f = new Attributes(*//*Global.variant*//*);
            f.ShowDialog();
        }*/

        private void просмотрToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Keys keys = new Keys();
            keys.ShowDialog();
        }

        private void редактироватьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            KeyAtr keyAtr = new KeyAtr();
            keyAtr.ShowDialog();
        }

        private void просмотрToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NotKeysView notKeysView = new NotKeysView();
            notKeysView.ShowDialog();
        }

        private void редактироватьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NotKeys nkeys = new NotKeys();
            nkeys.ShowDialog();
        }

        /*private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FD fD = new FD();
            fD.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }*/

        private void всеАтрибутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attributes f = new Attributes();
            f.ShowDialog();
        }

        private void функциональныеЗависимостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FD fD = new FD();
            fD.ShowDialog();
        }
    }
}
