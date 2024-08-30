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
        string conStr = ConfigurationManager.ConnectionStrings["Users"].ToString();
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
            using (var cn = NpgsqlDataSource.Create(conStr))
            {
                await cn.OpenConnectionAsync();
                var sql = "create or replace view keys as(\r\nselect fd, a.attribute_name  from \"KeyAttributes\" ka \r\njoin \"Attributes\" a on ka.k_name = a.id_attribute and ka.variant = a.variant)";
                await cn.CreateCommand(sql).ExecuteNonQueryAsync();

                sql = "select max(fd) from fd";
                var cmd = cn.CreateCommand(sql);
                var result = await cmd.ExecuteScalarAsync();
                rows = (int)result;

                for (int i = 1; i <= rows; i++)
                {
                    string text = string.Empty;

                        sql = "select attribute_name from keys where fd = @fd";
                        cmd = cn.CreateCommand(sql);
                        cmd.Parameters.AddWithValue("@fd", i);
                        await cmd.ExecuteNonQueryAsync();

                        var dr = await cmd.ExecuteReaderAsync();
                        while (await dr.ReadAsync())
                        {
                            text += dr["attribute_name"].ToString() + ", ";
                        }
                        dr.Dispose();

                    text = text.Remove(text.Length - 2);
                    dataGridView1.Rows.Add(i, text);
                }
                cn.Dispose();
            }
        }
    }
}