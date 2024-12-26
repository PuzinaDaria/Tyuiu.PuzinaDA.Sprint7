using System;
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
        public void DeleteItemChoice(string path, string name)
        {           
            int rows = 0;
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    rows++;
                }

            }
            string[] mass = new string[rows];
            string str = "";
            using (StreamReader sr = new StreamReader(path))
            {
                if (((line = sr.ReadLine()) != null) || ((line = sr.ReadLine()) != name))
                {
                    for(int i = 0; i < rows; i++)
                    {
                        str = line + Environment.NewLine;
                    }
                   
                }
            }
            File.WriteAllText(path, str);

            
        }
    }
}