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
    public partial class TestForm : Form
    {
        public string file;
        Dictionary<List<string>, List<string>> Student;
        public TestForm(string file)
        {
            InitializeComponent();
            this.file = file;

            int i = 1;
            foreach (KeyValuePair<List<string>, List<string>> pair in Global.LoadFD())
            {
                string keys = string.Empty;
                foreach (string key in pair.Key) { keys += key + " "; }
                string notkeys = string.Empty;
                foreach (string value in pair.Value) { notkeys += value + " "; }

                dataGridView2.Rows.Add(i, keys, notkeys);
                i++;
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            ExcelFile ex = new ExcelFile();
            ex.OpenFile(file);
            //ex.OpenFile("C:\\Users\\Таня\\source\\repos\\Excel\\Excel\\bin\\Debug\\net6.0\\Разбор тестовых вариантов\\Коттеджи.xlsx");
            FD_From_File task4 = new FD_From_File();
            task4.FZ();
            Student = FD_From_File.Functionaldependency;
            //ex.CloseFile();

            int i = 1;
            foreach (KeyValuePair<List<string>, List<string>> pair in Student)
            {
                string keys = string.Empty;
                foreach (string key in pair.Key) { keys += key + " "; }
                string notkeys = string.Empty;
                foreach (string value in pair.Value) { notkeys += value + " "; }

                dataGridView1.Rows.Add(i,keys,notkeys);
                i++;
            }

            ex.Mark(Rating());
            ex.CloseFile();
        }

        public string Rating()
        {
            Dictionary<List<string>, List<string>> Answers = Lower(Global.LoadFD());
            Dictionary<List<string>, List<string>> student = Lower(Student);

            int total = Answers.Count;
            int matches = 0;
            string fd_errors = string.Empty;
            string attributes_number = string.Empty;
            string fd_number = string.Empty;

            int fd_error = student.Keys.Count - Answers.Keys.Count;
            if (fd_error < 0) { fd_number = $"Количество фз меньше чем должно быть на {Math.Abs(fd_error)}!"; }
            else if (fd_error > 0) { fd_number = $"Количество фз больше чем должно быть на {Math.Abs(fd_error)}!"; }
            else { fd_number = $"Количество фз совпадает."; }

            int attribute_error = student.Values.Count - Answers.Values.Count;
            if (attribute_error < 0) { attributes_number = $"Количество атрибутов меньше чем должно быть на {Math.Abs(attribute_error)}!"; }
            else if (attribute_error > 0) { attributes_number = $"Количество атрибутов больше чем должно быть на {Math.Abs(attribute_error)}!"; }
            else { attributes_number = $"Количество атрибутов совпадает."; }


            foreach (var answer in Answers)
            {
                var matchingKey = student.Keys.FirstOrDefault(k => k.SequenceEqual(answer.Key));
                
                if (matchingKey != null)
                {
                    /*foreach (var key in matchingKey) { Console.Write(key + " "); }
                    Console.WriteLine();*/
                    /*foreach(var k in new HashSet<string>(student[matchingKey]))
                        Console.WriteLine(k);
                    Console.WriteLine();
                    foreach (var k in new HashSet<string>(answer.Value))
                        Console.WriteLine(k);
                    Console.WriteLine();
                    Console.WriteLine();*/
                    // Преобразуем списки в множества и проверяем на совпадение без учета порядка
                    if (new HashSet<string>(student[matchingKey]).SetEquals(new HashSet<string>(answer.Value)))
                    {
                        matches++;
                    }
                    else
                    {
                        fd_errors += "Ошибка в атрибутах фз:" + '\n';
                        foreach (string k in matchingKey)
                            fd_errors += k + ' ';
                        fd_errors += '\n';
                    }
                }
                else
                {
                    //fd_errors += matchingKey. + '\n';
                    fd_errors += "Ошибка в ФЗ:" + '\n';
                    foreach (string st in answer.Key)
                        fd_errors += st + ' ';
                    fd_errors += '\n';
                }
            }

            // Рассчитать процент
            double percent = (double)matches / total * 100;

            string mark = matches == total ? "++" :
                percent >= 50 ? "+-" :
                percent >= 25 ? "-+" :
                "--";

            MessageBox.Show($"Процент совпадения: {percent:F2}. Оценка: {mark}");
            return fd_number + '\n' + attributes_number + '\n' + fd_errors + '\n' + "Оценка: " + mark;
            }

        public Dictionary<List<string>, List<string>> Lower(Dictionary<List<string>, List<string>> dict)
        {
            // Приведение всех букв к нижнему регистру
            var lowerCaseDict = dict.ToDictionary(
                kvp => kvp.Key.Select(k => k.ToLower()).ToList(), // Приводим ключи к нижнему регистру
                kvp => kvp.Value.Select(v => v.ToLower()).ToList() // Приводим значения к нижнему регистру
            );
            return lowerCaseDict;
        }
    }
}
