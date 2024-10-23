using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDBtest
{
    public partial class Keys : Form
    {
        int rows = 0;

        public Keys()
        {
            InitializeComponent();
        }

        private async void Keys_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            using (var cn = NpgsqlDataSource.Create(Global.conStr))
            {
                await cn.OpenConnectionAsync();

                // Создание или замена представления
                /*var sql = "create or replace view keys as(" +
                          "select fd, a.attribute_name from \"KeyAttributes\" ka " +
                          "join \"Attributes\" a on ka.k_name = a.id_attribute and ka.variant = a.variant) order by fd";*/
                var sql = "create or replace view keys as(" +
          "select fd, a.attribute_name from \"KeyAttributes\" ka " +
          "join \"Attributes\" a on ka.k_name = a.id_attribute and ka.variant = a.variant " +
          "where ka.variant = " + Global.variant + ") order by fd";
                await cn.CreateCommand(sql).ExecuteNonQueryAsync();

                // Извлекаем все строки из представления keys
                sql = "select fd, attribute_name from keys";
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




        private async void button_Del_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRow = dataGridView1.SelectedRows[0].Index;
                int fd = (int)dataGridView1.Rows[selectedRow].Cells[0].Value;

                using (var cn = NpgsqlDataSource.Create(Global.conStr))
                {
                    await cn.OpenConnectionAsync();
                    var sql = "delete from \"KeyAttributes\" where fd = @fd";
                    var cmd = cn.CreateCommand(sql);
                    cmd.Parameters.AddWithValue("@fd", fd);
                    await cmd.ExecuteNonQueryAsync();
                    cn.Dispose();
                }

                // Remove row from DataGridView
                dataGridView1.Rows.RemoveAt(selectedRow);
            }
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            /*// Проверка на наличие введенных данных
            if (string.IsNullOrWhiteSpace(txtFd.Text) || string.IsNullOrWhiteSpace(txtAttributeName.Text))
            {
                MessageBox.Show("Пожалуйста, введите все обязательные данные.");
                return;
            }

            using (var cn = NpgsqlDataSource.Create(conStr))
            {
                await cn.OpenConnectionAsync();

                // Запрос на добавление новой записи
                string sql = "INSERT INTO \"KeyAttributes\" (k_name, variant) VALUES (@fd, @attributeName)";
                var cmd = cn.CreateCommand(sql);
                cmd.Parameters.AddWithValue("@fd", Convert.ToInt32(txtFd.Text)); // Преобразование к int
                cmd.Parameters.AddWithValue("@attributeName", txtAttributeName.Text);

                try
                {
                    // Выполнение команды
                    await cmd.ExecuteNonQueryAsync();
                    MessageBox.Show("Запись добавлена успешно.");

                    // Перезагрузка данных в DataGridView
                    await LoadData(); // Вызов метода LoadData для обновления отображаемых данных
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}");
                }
                finally
                {
                    cn.Dispose();
                }
            }*/
            KeyAtr ka = new KeyAtr();
            ka.ShowDialog();
            LoadData();
        }
    }
}