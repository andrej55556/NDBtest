using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDBtest
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (IsFileClosed(Global.file))
            {
                TestForm tf = new TestForm(Global.file);
                tf.ShowDialog();
            }
            else MessageBox.Show("Ошибка!");
        }

        static bool IsFileClosed(string filePath)
        {
            try
            {
                // Пытаемся открыть файл для чтения
                using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    return true; // Файл закрыт
                }
            }
            catch (IOException)
            {
                return false; // Файл открыт
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
