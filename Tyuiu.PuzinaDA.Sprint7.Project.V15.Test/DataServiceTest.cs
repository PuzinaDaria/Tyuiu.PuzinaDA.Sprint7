using Tyuiu.PuzinaDA.Sprint7.Project.V15.Lib;
using static Tyuiu.PuzinaDA.Sprint7.Project.V15.Lib.DataService;
namespace Tyuiu.PuzinaDA.Sprint7.Project.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MatrixChecked()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\Материал\Тест\Тест.csv";
            string[,] res = ds.GetMatrix(path);
            string[,] wait =
            {
                {"24245",  "Никитич Никита Никитович", "895458772", "20.02.2024", "бульвар Славы, 92", "45000", "PR-менеджер"},
                {"17853", "Николаев Николай Николаевич", "245646638", "28.01.2024", "пер. Косиора, 14", "25000", "Уборщица"},
                {"98164", "Дмитриев Дмитрий Дмитриевич", "450596744", "19.11.2023", "пр. Славы, 37", "35000", "Электрик"}
            };
            CollectionAssert.AreEqual(res, wait);

        }
        [TestMethod]
        public void TrudDogovorChecked()
        {
            DataService ds = new DataService();
            ContractData contractData = new ContractData
            {
                номер_договора = "12345",
                дата_составления = "01.10.2024",
                город = "Тюмень",
                ФИО_руководителя = "Иванов Иван Иванович",
                должность_руководителя = "Генеральный договор",
                документ_основание_работодателя = "Устав",
                гражданство_работника = "Российская федерация",
                ФИО_работника = "Николаев Николай Николаевич",
                паспортные_данные_работника = "849324832",
                адрес_работы = "ул. Максима Горького, 44",
                должность_работника = "Программист",
                дата_начала_работы = "01.01.01",
                период_договора = "бессрочный",
                испытательный_срок = "2 недели",
                система_оплаты_труда = "оклад",
                оклад = "30000",
                дата_выплаты_зарплаты = "каждое 25 число месяца",
                условия_премирования = "Премии устанавливаются по итогам работы за квартал",
                режим_рабочего_времени = "пятидневная рабочая неделя с 9:00 до 18:00",
                количество_дней_отпуска = "28",
                подпись_работодателя = "(подпись)",
                подпись_работника = "(подпись)"
            };
            bool tr = false;
            string path = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\Материал\Трудовой договор\ТрудовойДоговор.txt";
            string generatedContract = GenerateContract(path, contractData);
            string filePath = @"C:\\Users\\daria\\source\\repos\\Tyuiu.PuzinaDA.Sprint7\\Материал\\Трудовой договор\\Текстовый документ.txt";
            File.WriteAllText(@"C:\\Users\\daria\\source\\repos\\Tyuiu.PuzinaDA.Sprint7\\Материал\\Трудовой договор\\Текстовый документ.txt", generatedContract);
            if(File.Exists(filePath))
            {
                tr = true;
            }
            Assert.IsTrue(tr);
        }
        [TestMethod]
        public void GetChoiceOrganizationChecked()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\Материал\Тест\Organization.csv";
            string[] matrix = ds.GetChoiceOrganization(path);
            string[] wait = {"ITSpin", "ffff", "dfdsfdsf", "dsfdsf", "fsdfdsfv", "vv"};
            CollectionAssert.AreEqual(wait, matrix);
        }
    }
}