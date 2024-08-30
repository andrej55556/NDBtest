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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "normalizationDataSet.roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.normalizationDataSet.roles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "normalizationDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.normalizationDataSet.users);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //rolesTableAdapter.Fill(this.normalizationDataSet.roles);
            usersBindingSource.EndEdit();
            usersTableAdapter.Update(this.normalizationDataSet.users);
        }
    }
}
