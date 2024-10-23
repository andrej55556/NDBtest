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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int role = -1;

            using (var cn = NpgsqlDataSource.Create(Global.conStr))
            {
                cn.OpenConnection();
                var sql = "select \"role\", \"fio\" from users where login like @login and \"password\" like @password";

                var cmd = cn.CreateCommand(sql);
                //cmd.Parameters.AddWithValue("@login", cmbLoginList.Text);
                cmd.Parameters.AddWithValue("@login", tbLogin.Text);
                cmd.Parameters.AddWithValue("@password", tbPassword.Text);

                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    role = Int16.Parse(dr["role"].ToString());
                    Global.fio = dr["fio"].ToString();
                }
                cn.Dispose();
                dr.Dispose();
            }

            if (role == 1)
            {
                //MessageBox.Show("Admin");
                AdminForm adm = new AdminForm();
                adm.ShowDialog();
            }
            else if (role == 2)
            {
                //MessageBox.Show("Teacher");
                TeacherForm t = new TeacherForm();
                t.ShowDialog();
            }
            else if (role == 3)
            {
                //MessageBox.Show("Student");
                StudentForm student = new StudentForm();
                student.ShowDialog();
            }
            else
            {
                MessageBox.Show("В доступе отказано! Обратитесь к администратору.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbLogin.Text = string.Empty;
            tbPassword.Text = string.Empty;
        }
    }
}
