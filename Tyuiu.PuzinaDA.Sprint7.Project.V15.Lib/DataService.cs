using System.Data.Common;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.RegularExpressions;

namespace Tyuiu.PuzinaDA.Sprint7.Project.V15.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path)
        {
            int column = 0, rows = 0;
            string line;
            int index = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] mass = line.Split(";");
                    column = mass.Length;
                    rows++;
                }

            }
            string[,] matrix = new string[rows, column];
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                string[] z = new string[column];

                while ((line = sr.ReadLine()) != null)
                {
                    z = line.Split(";");
                    for (int i = 0; i < z.Length; i++)
                    {
                        matrix[index, i] = z[i];
                    }
                    index++;
                    z = [];
                }
            }

            return matrix;
        }
        public static string GenerateContract(string templatePath, ContractData contractData)
        {
            // Проверка входных данных
            if (string.IsNullOrEmpty(templatePath) || contractData == null)
            {
                throw new ArgumentException("Неверные входные данные.");
            }

            if (!File.Exists(templatePath))
            {
                throw new FileNotFoundException("Шаблон договора не найден.", templatePath);
            }

            try
            {
                // Загрузка шаблона
                string template = File.ReadAllText(templatePath);

                // Замена местозаполнителей с использованием регулярных выражений
                foreach (var property in contractData.GetType().GetProperties())
                {
                    string propertyName = property.Name;
                    string propertyValue = property.GetValue(contractData)?.ToString() ?? ""; // Обработка null
                    string pattern = $"{{{{{propertyName}}}}}"; // Регулярное выражение для точного совпадения
                    template = Regex.Replace(template, pattern, propertyValue);
                }

                return template; // Возвращаем сгенерированный договор
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при генерации договора: {ex.Message}", ex); // Передаем исходное исключение
            }
        }


        // Класс для хранения данных договора (определение должно быть вне метода)
        public class ContractData
        {
            public string номер_договора { get; set; }
            public string дата_составления { get; set; }
            public string город { get; set; }
            public string ФИО_руководителя { get; set; }
            public string должность_руководителя { get; set; }
            public string документ_основание_работодателя { get; set; }
            public string ФИО_работника { get; set; }
            public string гражданство_работника { get; set; }
            public string паспортные_данные_работника { get; set; }
            public string адрес_работы { get; set; }
            public string должность_работника { get; set; }
            public string дата_начала_работы { get; set; }
            public string период_договора { get; set; }
            public string испытательный_срок { get; set; }
            public string система_оплаты_труда { get; set; }
            public string оклад { get; set; }
            public string дата_выплаты_зарплаты { get; set; }
            public string условия_премирования { get; set; }
            public string режим_рабочего_времени { get; set; }
            public string количество_дней_отпуска { get; set; }
            public string подпись_работодателя { get; set; }
            public string подпись_работника { get; set; }
        }
        public int row = 0;
        public string[] GetChoiceOrganization(string path)
        {
            int column = 0, rows = 0;
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    rows++;
                }
            }
            string[] matrix = new string[rows];
            int index = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    matrix[index] = line;
                    index++;
                }
            }
            return matrix;
        }
    }
        {

        }


    }
}

   

