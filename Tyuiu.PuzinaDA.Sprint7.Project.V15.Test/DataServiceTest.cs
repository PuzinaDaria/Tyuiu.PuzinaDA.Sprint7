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
            string path = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\��������\����\����.csv";
            string[,] res = ds.GetMatrix(path);
            string[,] wait =
            {
                {"24245",  "������� ������ ���������", "895458772", "20.02.2024", "������� �����, 92", "45000", "PR-��������"},
                {"17853", "�������� ������� ����������", "245646638", "28.01.2024", "���. �������, 14", "25000", "��������"},
                {"98164", "�������� ������� ����������", "450596744", "19.11.2023", "��. �����, 37", "35000", "��������"}
            };
            CollectionAssert.AreEqual(res, wait);

        }
        [TestMethod]
        public void TrudDogovorChecked()
        {
            DataService ds = new DataService();
            ContractData contractData = new ContractData
            {
                �����_�������� = "12345",
                ����_����������� = "01.10.2024",
                ����� = "������",
                ���_������������ = "������ ���� ��������",
                ���������_������������ = "����������� �������",
                ��������_���������_������������ = "�����",
                �����������_��������� = "���������� ���������",
                ���_��������� = "�������� ������� ����������",
                ����������_������_��������� = "849324832",
                �����_������ = "��. ������� ��������, 44",
                ���������_��������� = "�����������",
                ����_������_������ = "01.01.01",
                ������_�������� = "����������",
                �������������_���� = "2 ������",
                �������_������_����� = "�����",
                ����� = "30000",
                ����_�������_�������� = "������ 25 ����� ������",
                �������_������������ = "������ ��������������� �� ������ ������ �� �������",
                �����_��������_������� = "����������� ������� ������ � 9:00 �� 18:00",
                ����������_����_������� = "28",
                �������_������������ = "(�������)",
                �������_��������� = "(�������)"
            };
            bool tr = false;
            string path = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\��������\�������� �������\���������������.txt";
            string generatedContract = GenerateContract(path, contractData);
            string filePath = @"C:\\Users\\daria\\source\\repos\\Tyuiu.PuzinaDA.Sprint7\\��������\\�������� �������\\��������� ��������.txt";
            File.WriteAllText(@"C:\\Users\\daria\\source\\repos\\Tyuiu.PuzinaDA.Sprint7\\��������\\�������� �������\\��������� ��������.txt", generatedContract);
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
            string path = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\��������\����\Organization.csv";
            string[] matrix = ds.GetChoiceOrganization(path);
            string[] wait = {"ITSpin", "ffff", "dfdsfdsf", "dsfdsf", "fsdfdsfv", "vv"};
            CollectionAssert.AreEqual(wait, matrix);
        }
    }
}