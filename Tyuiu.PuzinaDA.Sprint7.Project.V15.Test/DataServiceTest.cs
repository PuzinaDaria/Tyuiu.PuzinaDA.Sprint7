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