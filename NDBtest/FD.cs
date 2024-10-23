using Npgsql;
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
    public partial class FD : Form
    {
        public FD()
        {
            InitializeComponent();

            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void FD_Load(object sender, EventArgs e)
        {
            var allFd = Global.LoadFD();

            // Очищаем DataGridView перед добавлением новых данных
            dataGridView1.Rows.Clear();

            int i = 1;
            foreach (var fd in allFd)
            {
                // Проверяем наличие ключевых атрибутов и создаем строку с ними
                string keyAttributesText = fd.Key != null && fd.Key.Count > 0
                    ? string.Join(", ", fd.Key)
                    : "-";

                // Проверяем наличие неключевых атрибутов и создаем строку с ними
                string notKeyAttributesText = fd.Value != null && fd.Value.Count > 0
                    ? string.Join(", ", fd.Value)
                    : "-";

                // Добавляем строку в DataGridView
                dataGridView1.Rows.Add(i,keyAttributesText, notKeyAttributesText);
                i++;
            }

        }
    }
}
