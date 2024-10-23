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
    public partial class NotKeys : Form
    {
        public NotKeys()
        {
            InitializeComponent();
        }

        private void notKeyAttributesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notKeyAttributesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.normalizationDataSet);

        }

        private void NotKeys_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "normalizationDataSet.Attributes". При необходимости она может быть перемещена или удалена.
            this.attributesTableAdapter.Fill(this.normalizationDataSet.Attributes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "normalizationDataSet.NotKeyAttributes". При необходимости она может быть перемещена или удалена.
            this.notKeyAttributesTableAdapter.Fill(this.normalizationDataSet.NotKeyAttributes);
            this.normalizationDataSet.NotKeyAttributes.variantColumn.DefaultValue = Global.variant;

            string filterExpression = $"variant = {Global.variant}";
            notKeyAttributesBindingSource.Filter = filterExpression;
            //keyAttributesBindingSource.Filter = filterExpression;
            attributesBindingSource.Filter = filterExpression;
        }

        private void notKeyAttributesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
            //MessageBox.Show(this.normalizationDataSet.NotKeyAttributes.GetErrors().ToString());
        }
    }
}
