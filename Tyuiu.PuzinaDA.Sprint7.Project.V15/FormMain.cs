using System.ComponentModel;
using System.Windows.Forms;
using Tyuiu.PuzinaDA.Sprint7.Project.V15.Lib;
namespace Tyuiu.PuzinaDA.Sprint7.Project.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        int rows, column;
        string[,] matrix;
        private void buttonDown_PDA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                string pt = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\Материал\База данных";
                string path = Path.Combine(pt, comboBoxChoice_PDA.Text + ".csv");

                matrix = ds.GetMatrix(path);

                rows = matrix.GetLength(0) + 1;
                column = (matrix.Length / rows);

                dataGridViewList_PDA.RowCount = rows;

                dataGridViewList_PDA.Columns[1].Width = 200;
                dataGridViewList_PDA.Columns[4].Width = 200;
                dataGridViewList_PDA.Columns[6].Width = 200;
                for (int i = 0; i < rows - 1; i++)
                {
                    for (int j = 0; j <= column; j++)
                    {
                        dataGridViewList_PDA.Rows[i].Cells[j].Value = matrix[i, j];

                    }
                }
            }
            catch
            {
                MessageBox.Show("Выберите организацию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSorting_PDA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= column; i++)
            {
                if (dataGridViewList_PDA.Columns[i].HeaderText == comboBoxSort_PDA.Text)
                {
                    dataGridViewList_PDA.Sort(dataGridViewList_PDA.Columns[i], ListSortDirection.Ascending);
                }
            }


        }

        private void buttonSearch_PDA_Click(object sender, EventArgs e)
        {
            
        }
    }
}
