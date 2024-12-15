using System.Data.Common;

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
    }
}
