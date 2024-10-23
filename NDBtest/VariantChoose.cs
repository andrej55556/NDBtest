using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NDBtest
{
    public partial class VariantChoose : Form
    {
        public VariantChoose()
        {
            InitializeComponent();
        }

        private void VariantChoose_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "normalizationDataSet.Variants". При необходимости она может быть перемещена или удалена.
            this.variantsTableAdapter.Fill(this.normalizationDataSet.Variants);

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (variantsDataGridView.SelectedRows.Count > 0)
            {
                // Получаем первую выбранную строку
                DataGridViewRow selectedRow = variantsDataGridView.SelectedRows[0];

                // Например, получаем значение из первого столбца
                var selectedValue = selectedRow.Cells[0].Value;
                var selectedVariant = selectedRow.Cells[1].Value;

                Global.variant = Int16.Parse(selectedValue.ToString());

                StudentFile(selectedVariant.ToString() + ".xlsx");
            }
        }

        private void variantsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void StudentFile(string fileName)
        {
            // Путь к папке с тестовыми шаблонами
            string testTemplatesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Тестовые шаблоны");

            // Полный путь к файлу, который нужно скопировать
            string sourceFile = Path.Combine(testTemplatesPath, fileName);

            // Путь к папке, куда нужно скопировать файл
            string studentSolutionsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Решения студентов");

            // Проверяем, существует ли папка с решениями студентов, если нет — создаём
            if (!Directory.Exists(studentSolutionsPath))
            {
                Directory.CreateDirectory(studentSolutionsPath);
            }

            // Получаем имя файла и его расширение
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
            string fileExtension = Path.GetExtension(fileName);

            // Полный путь, куда будет скопирован файл
            string destinationFile = Path.Combine(studentSolutionsPath, Global.fio + '_' + fileName);

            int copyNumber = 1;

            // Проверяем, существует ли файл, и если да, добавляем суффикс с числом
            while (File.Exists(destinationFile))
            {
                string newFileName = Global.fio + '_' + $"{fileNameWithoutExtension} (Попытка № {copyNumber}){fileExtension}";
                destinationFile = Path.Combine(studentSolutionsPath, newFileName);
                copyNumber++;
            }

            // Копируем файл
            try
            {
                File.Copy(sourceFile, destinationFile, overwrite: true);
                //MessageBox.Show($"Файл '{fileName}' успешно скопирован в папку 'Решения студентов'.");
                
                Global.OpenExcelFile(destinationFile);

                Global.file = destinationFile;
                Check c = new Check();
                c.ShowDialog();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"Файл '{fileName}' не найден в папке 'Тестовые шаблоны'.");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ошибка при копировании файла: {ex.Message}");
            }
        }
    }
}
