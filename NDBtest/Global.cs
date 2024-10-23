using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace NDBtest
{
    public class Global
    {
        public static string conStr = ConfigurationManager.ConnectionStrings["Users"].ToString();
        public static int variant = 1;
        public static string fio = "-";
        public static string file = "-";  
        public static void OpenExcelFile(string filePath)
        {
            // Создаем объект Excel
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = null;

            try
            {
                // Открываем выбранный Excel файл
                workbook = excelApp.Workbooks.Open(filePath);

                // Отображаем Excel файл (видимым)
                excelApp.Visible = true;
                // Устанавливаем Excel окно в полноэкранный режим
                excelApp.WindowState = Excel.XlWindowState.xlMaximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла Excel: {ex.Message}");
            }
            /*finally
            {
                *//*// Можно закрыть Excel приложение, если оно не нужно оставлять открытым
                if (workbook != null)
                {
                    workbook.Close(false);
                    excelApp.Quit();
                }*//*
            }*/
        }

        public static Dictionary<List<string>, List<string>> LoadFD()
        {
            /*using (var cn = NpgsqlDataSource.Create(Global.conStr))
            {
                cn.OpenConnection();

                // Извлекаем все строки из представлений keys и not_keys
                var sqlKeys = "select fd, attribute_name from keys";
                var sqlNotKeys = "select fd, attribute_name from not_keys";

                var cmdKeys = cn.CreateCommand(sqlKeys);
                var cmdNotKeys = cn.CreateCommand(sqlNotKeys);

                var drKeys = cmdKeys.ExecuteReader();
                var drNotKeys = cmdNotKeys.ExecuteReader();

                // Используем два словаря для хранения атрибутов по fd
                var keyAttributesByFd = new Dictionary<int, List<string>>();
                var notKeyAttributesByFd = new Dictionary<int, List<string>>();

                // Заполняем словарь для ключевых атрибутов
                while (drKeys.Read())
                {
                    int fd = (int)drKeys["fd"];
                    string keyAttribute = drKeys["attribute_name"].ToString();

                    if (!keyAttributesByFd.ContainsKey(fd))
                    {
                        keyAttributesByFd[fd] = new List<string>();
                    }
                    keyAttributesByFd[fd].Add(keyAttribute);
                }
                drKeys.Dispose();

                // Заполняем словарь для неключевых атрибутов
                while (drNotKeys.Read())
                {
                    int fd = (int)drNotKeys["fd"];
                    string notKeyAttribute = drNotKeys["attribute_name"].ToString();

                    if (!notKeyAttributesByFd.ContainsKey(fd))
                    {
                        notKeyAttributesByFd[fd] = new List<string>();
                    }
                    notKeyAttributesByFd[fd].Add(notKeyAttribute);
                }
                drNotKeys.Dispose();

                // Создаем словарь для функциональных зависимостей
                var functionalDependency = new Dictionary<List<string>, List<string>>();

                // Объединяем ключевые и неключевые атрибуты по fd
                foreach (var fd in keyAttributesByFd.Keys)
                {
                    var keyAttributes = keyAttributesByFd[fd];
                    var notKeyAttributes = notKeyAttributesByFd.ContainsKey(fd) ? notKeyAttributesByFd[fd] : new List<string>();

                    // Добавляем в функциональную зависимость
                    functionalDependency[keyAttributes] = notKeyAttributes;
                }

                // Закрываем соединение
                cn.Dispose();

                // Возвращаем функциональные зависимости
                return functionalDependency;
            }*/
            using (var cn = NpgsqlDataSource.Create(Global.conStr))
            {
                cn.OpenConnection();

                // Преобразуем значение Global.variant в строку и вставляем в SQL-запрос
                var sqlCreateViewKeys = "create or replace view keys as " +
                                         "(select fd, a.attribute_name from \"KeyAttributes\" ka " +
                                         "join \"Attributes\" a on ka.k_name = a.id_attribute " +
                                         "where ka.variant = " + Global.variant + ")";

                var sqlCreateViewNotKeys = "create or replace view not_keys as " +
                                            "(select fd, a.attribute_name from \"NotKeyAttributes\" nka " +
                                            "join \"Attributes\" a on nka.nk_name = a.id_attribute " +
                                            "where nka.variant = " + Global.variant + ")";

                // Создаем команды для обновления представлений
                var cmdCreateViewKeys = cn.CreateCommand(sqlCreateViewKeys);
                var cmdCreateViewNotKeys = cn.CreateCommand(sqlCreateViewNotKeys);

                // Выполняем команды для обновления представлений
                cmdCreateViewKeys.ExecuteNonQuery();
                cmdCreateViewNotKeys.ExecuteNonQuery();

                // Теперь извлекаем данные из представлений
                var sqlKeys = "select fd, attribute_name from keys";
                var sqlNotKeys = "select fd, attribute_name from not_keys";

                var cmdKeys = cn.CreateCommand(sqlKeys);
                var cmdNotKeys = cn.CreateCommand(sqlNotKeys);

                var drKeys = cmdKeys.ExecuteReader();
                var drNotKeys = cmdNotKeys.ExecuteReader();

                // Используем два словаря для хранения атрибутов по fd
                var keyAttributesByFd = new Dictionary<int, List<string>>();
                var notKeyAttributesByFd = new Dictionary<int, List<string>>();

                // Заполняем словарь для ключевых атрибутов
                while (drKeys.Read())
                {
                    int fd = (int)drKeys["fd"];
                    string keyAttribute = drKeys["attribute_name"].ToString();

                    if (!keyAttributesByFd.ContainsKey(fd))
                    {
                        keyAttributesByFd[fd] = new List<string>();
                    }
                    keyAttributesByFd[fd].Add(keyAttribute);
                }
                drKeys.Dispose();

                // Заполняем словарь для неключевых атрибутов
                while (drNotKeys.Read())
                {
                    int fd = (int)drNotKeys["fd"];
                    string notKeyAttribute = drNotKeys["attribute_name"].ToString();

                    if (!notKeyAttributesByFd.ContainsKey(fd))
                    {
                        notKeyAttributesByFd[fd] = new List<string>();
                    }
                    notKeyAttributesByFd[fd].Add(notKeyAttribute);
                }
                drNotKeys.Dispose();

                // Создаем словарь для функциональных зависимостей
                var functionalDependency = new Dictionary<List<string>, List<string>>();

                // Объединяем ключевые и неключевые атрибуты по fd
                foreach (var fd in keyAttributesByFd.Keys)
                {
                    var keyAttributes = keyAttributesByFd[fd];
                    var notKeyAttributes = notKeyAttributesByFd.ContainsKey(fd) ? notKeyAttributesByFd[fd] : new List<string>();

                    // Добавляем в функциональную зависимость
                    functionalDependency[keyAttributes] = notKeyAttributes;
                }

                // Закрываем соединение
                cn.Dispose();

                // Возвращаем функциональные зависимости
                return functionalDependency;
            }
        }

        public static void OpenDir(string dir)
        {
            // Создаем диалог для открытия файлов
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Получаем путь к папке в каталоге bin проекта
            string binFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dir);

            // Задаем начальный каталог для открытия файлов
            openFileDialog.InitialDirectory = binFolderPath;

            // Устанавливаем фильтр файлов только для Excel
            openFileDialog.Filter = "Excel файлы (*.xls;*.xlsx)|*.xls;*.xlsx|Все файлы (*.*)|*.*";

            // Открываем диалог
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                string selectedFilePath = openFileDialog.FileName;
                //MessageBox.Show($"Выбран Excel файл: {selectedFilePath}");
                Global.OpenExcelFile(selectedFilePath);
            }
        }
    }
}
