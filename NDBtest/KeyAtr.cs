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
    public partial class KeyAtr : Form
    {
        public KeyAtr()
        {
            InitializeComponent();
        }

        private void keyAttributesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.keyAttributesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.normalizationDataSet);
        }

        private void KeyAtr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "normalizationDataSet.Attributes". При необходимости она может быть перемещена или удалена.
            this.attributesTableAdapter.Fill(this.normalizationDataSet.Attributes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "normalizationDataSet.KeyAttributes". При необходимости она может быть перемещена или удалена.
            this.keyAttributesTableAdapter.Fill(this.normalizationDataSet.KeyAttributes);

            this.normalizationDataSet.KeyAttributes.variantColumn.DefaultValue = Global.variant;

            /*DataView view = new DataView(this.normalizationDataSet.KeyAttributes);
            //view.RowFilter = $"variant = {Global.variant}";
            view.RowFilter = $"variant = {2}";
            //keyAttributesDataGridView.DataSource = view;

            keyAttributesBindingSource.DataSource = view;*/

            string filterExpression = $"variant = {Global.variant}";
            //notKeyAttributesBindingSource.Filter = filterExpression;
            keyAttributesBindingSource.Filter = filterExpression;
            attributesBindingSource.Filter = filterExpression;
        }

        private void KeyAtr_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
