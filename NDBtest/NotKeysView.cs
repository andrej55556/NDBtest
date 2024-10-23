using Npgsql;
using NpgsqlTypes;
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
    public partial class NotKeysView : Form
    {
        public NotKeysView()
        {
            InitializeComponent();
        }

        private void NotKeysView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private async Task LoadData()
        {
            using (var cn = NpgsqlDataSource.Create(Global.conStr))
            {
                await cn.OpenConnectionAsync();

                // Создание или замена представления
                var sql = "create or replace view not_keys as(" +
          "select fd, a.attribute_name from \"NotKeyAttributes\" nka " +
          "join \"Attributes\" a on nka.nk_name = a.id_attribute " +
          "where nka.variant = " + Global.variant + ") order by fd";


                try
                {
                    using (var command = cn.CreateCommand())
                    {
                        command.CommandText = sql;
                        // Добавляем параметр для variant
                        //command.Parameters.AddWithValue("@variant", Global.variant); 

                        await command.ExecuteNonQueryAsync();
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Ошибка: " + ex.Message);
                }

                // Извлекаем все строки из представления keys
                sql = "select fd, attribute_name from not_keys";
                var cmd = cn.CreateCommand(sql);

                var dr = await cmd.ExecuteReaderAsync();

                // Используем словарь для хранения атрибутов по fd
                var attributesByFd = new Dictionary<int, List<string>>();

                while (await dr.ReadAsync())
                {
                    int fd = (int)dr["fd"];
                    string attributeName = dr["attribute_name"].ToString();

                    // Если fd уже существует в словаре, добавляем атрибут
                    if (!attributesByFd.ContainsKey(fd))
                    {
                        attributesByFd[fd] = new List<string>();
                    }
                    attributesByFd[fd].Add(attributeName);
                }
                dr.Dispose();

                // Сохраняем текущее состояние сортировки
                var sortColumn = dataGridView1.SortedColumn;
                var sortDirection = dataGridView1.SortOrder;

                // Очищаем DataGridView перед добавлением новых данных
                dataGridView1.Rows.Clear();

                // Теперь добавляем строки в DataGridView
                foreach (var kvp in attributesByFd)
                {
                    int fd = kvp.Key;
                    string attributesText = string.Join(", ", kvp.Value);
                    dataGridView1.Rows.Add(fd, attributesText);
                }

                // Восстанавливаем состояние сортировки
                if (sortColumn != null)
                {
                    dataGridView1.Sort(sortColumn, sortDirection == SortOrder.Descending ? System.ComponentModel.ListSortDirection.Descending : System.ComponentModel.ListSortDirection.Ascending);
                }

                cn.Dispose();
            }
        }
    }
}
