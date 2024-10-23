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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            //label_fio.Text = Global.fio;
            label_fio.Visible = false;

            данныеВариантаToolStripMenuItem.DropDownItems.Clear();
            Dictionary<int,string> var = new Dictionary<int,string>();

            using (var cn = NpgsqlDataSource.Create(Global.conStr))
            {
                cn.OpenConnection();
                var sql = "select * from \"Variants\"";

                var cmd = cn.CreateCommand(sql);

                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var.Add(Int16.Parse(dr["id"].ToString()), dr["name"].ToString());
                }
                cn.Dispose();
                dr.Dispose();
            }

            foreach (var v in var) // где varDict – это ваш словарь или коллекция с ключами и значениями
            {
                // Создаем новый элемент меню
                ToolStripMenuItem item = new ToolStripMenuItem(v.Key.ToString() + ". " + v.Value);

                // Сохраняем ключ в свойстве Tag
                item.Tag = v.Key;

                // Привязываем событие Click
                item.Click += new EventHandler(Item_Click);

                // Добавляем элемент в меню
                данныеВариантаToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void ответыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Variants v = new Variants();
            v.ShowDialog();
        }

        private void всяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attributes f = new Attributes(/*Global.variant*/);
            f.ShowDialog();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            // Приведение sender к ToolStripMenuItem
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;

            if (clickedItem != null)
            {
                // Извлечение ключа из свойства Tag
                var key = clickedItem.Tag;
                Global.variant = (int)key;

                /*Form2 f = new Form2(Global.vartiant);
                /*new Keys()
                    NotKeys()
                    new NotKeysView()*/
                //FD f = new FD();
                //Keys f = new Keys();
                //KeyAtr f = new KeyAtr();
                //NotKeysView f = new NotKeysView();
                //NotKeys f = new NotKeys();
                AttributesForm af = new AttributesForm();
                af.ShowDialog();
            }
        }

        private void проверкаСтудентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.OpenDir("Решения студентов");
        }
    }
}
