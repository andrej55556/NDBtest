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
    public partial class Variants : Form
    {
        public Variants()
        {
            InitializeComponent();
        }

        private void variantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.variantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.normalizationDataSet);

        }

        private void Variants_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "normalizationDataSet.Variants". При необходимости она может быть перемещена или удалена.
            this.variantsTableAdapter.Fill(this.normalizationDataSet.Variants);

        }

        private void btn_Choose_Click(object sender, EventArgs e)
        {
            /*if (variantsDataGridView.SelectedRows.Count > 0)
            {
                // Получаем первую выбранную строку
                DataGridViewRow selectedRow = variantsDataGridView.SelectedRows[0];

                // Например, получаем значение из первого столбца
                var selectedValue = selectedRow.Cells[0].Value;

                Global.vartiant = Int16.Parse(selectedValue.ToString());
            }*/

            if (ValidateFirstColumn())
            {
                // Если данные валидны, выполняем обновление
                this.variantsTableAdapter.Update(this.normalizationDataSet.Variants);
            }
            else
            {
                // Показываем сообщение об ошибке
                MessageBox.Show("Ошибка: В первый столбец должны быть внесены только целые положительные числа.");
            }
        }

        private void variantsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Номер варианта должен быть уникальным!");
        }

        private bool ValidateFirstColumn()
        {
            // Получаем таблицу данных
            DataTable variantsTable = this.normalizationDataSet.Variants;

            // Перебираем строки таблицы
            foreach (DataRow row in variantsTable.Rows)
            {
                // Получаем значение первого столбца
                object firstColumnValue = row[0];

                // Проверяем, является ли значение целым числом и положительным
                if (!(firstColumnValue is int) || (int)firstColumnValue <= 0)
                {
                    // Если проверка не пройдена, возвращаем false
                    return false;
                }
            }

            // Все данные валидны
            return true;
        }

        private void variantsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
