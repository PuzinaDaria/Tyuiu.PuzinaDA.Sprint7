using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tyuiu.PuzinaDA.Sprint7.Project.V15.Lib;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static Tyuiu.PuzinaDA.Sprint7.Project.V15.Lib.DataService;
namespace Tyuiu.PuzinaDA.Sprint7.Project.V15
{
    public partial class FormMain : Form
    {
        string path;
        public FormMain()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            openFileDialogDown_PDA.Filter = "��������, ���������� �������(*.csv)|*.csv|(*.*)|*.*";
            saveFileDialog_PDA.Filter = "��������, ���������� �������(*.csv)|*.csv|(*.*)|*.*";

        }

        int rows, column;
        string[,] matrix;
        private void FormMain_Load(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            string path = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\��������\�����������\Organization.csv";
            string[] matrix = ds.GetChoiceOrganization(path);
            comboBoxChoice_PDA.Items.AddRange(matrix);
            System.Windows.Forms.ToolTip tt = new System.Windows.Forms.ToolTip();
            tt.SetToolTip(buttonDown_PDA, "������� ������� � �������");
            tt.SetToolTip(buttonPlus_PDA, "�������� �����������");
            tt.SetToolTip(buttonMinus_PDA, "������� �����������");
            tt.SetToolTip(buttonSave_PDA, "��������� � ���� ������");
            tt.SetToolTip(buttonSaveAs_PDA, "��������� � ��������� �����");
            tt.SetToolTip(buttonQuestion_PDA, "� ���������");
            tt.SetToolTip(buttonSearch_PDA, "������� � ���� ������ � ��������� �����");
            tt.SetToolTip(buttonDeleteRow_PDA, "������� ��������� ������");
            tt.SetToolTip(buttonSorting_PDA, "�������� �������� � ��������� ����������");
            tt.SetToolTip(buttonFilter_PDA, "���������� �� �������");

        }
        private void buttonDown_PDA_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                string pt = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\��������\���� ������";
                path = Path.Combine(pt, comboBoxChoice_PDA.Text + ".csv");

                matrix = ds.GetMatrix(path);

                rows = matrix.GetLength(0);

                MessageBox.Show(rows.ToString(), "���������� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);

                column = matrix.GetLength(1);

                dataGridViewList_PDA.RowCount = rows;

                dataGridViewList_PDA.Columns[1].Width = 200;
                dataGridViewList_PDA.Columns[4].Width = 200;
                dataGridViewList_PDA.Columns[6].Width = 200;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        dataGridViewList_PDA.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                buttonFilter_PDA.Enabled = true;
                comboBoxSort_PDA.Enabled = true;
                buttonSorting_PDA.Enabled = true;
                buttonPlusLine_PDA.Enabled = true;
                textBoxSearch_PDA.Enabled = true;
                buttonSearch_PDA.Enabled = true;
                buttonDeleteRow_PDA.Enabled = true;
                buttonSave_PDA.Enabled = true;
                buttonSaveAs_PDA.Enabled = true;
                buttonSumOklad_PDA.Enabled = true;
            }
            catch (Exception ex)
            {
                dataGridViewList_PDA.Rows.Clear();
                MessageBox.Show($"������: {ex.Message}. �������� �����������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void buttonSorting_PDA_Click(object sender, EventArgs e)
        {
            if (comboBoxSort_PDA != null)
            {
                for (int i = 0; i < column; i++)
                {
                    if (dataGridViewList_PDA.Columns[i].HeaderText == comboBoxSort_PDA.Text)
                    {
                        dataGridViewList_PDA.Sort(dataGridViewList_PDA.Columns[i], ListSortDirection.Ascending);
                    }
                }
            }
            else
            {
                MessageBox.Show("�������� �������, ������� ����� �������������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_PDA_Click(object sender, EventArgs e)
        {
            if (textBoxSearch_PDA.Text != "")
                for (int i = 0; i < dataGridViewList_PDA.RowCount; i++)
                {
                    dataGridViewList_PDA.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewList_PDA.ColumnCount; j++)
                        if (dataGridViewList_PDA.Rows[i].Cells[j].Value != null)
                            if (dataGridViewList_PDA.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearch_PDA.Text.ToLower()))
                            {
                                dataGridViewList_PDA.Rows[i].Selected = true;
                                break;
                            }
                }
            else
            {
                MessageBox.Show("������� ������� ��������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuestion_PDA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();

        }

        private void buttonPlusLine_PDA_Click(object sender, EventArgs e)
        {
            FormAdd fa = new FormAdd();
            if (fa.ShowDialog() == DialogResult.OK)
            {
                if ((fa.textBoxNumberDoc_PDA.Text != "") && (fa.textBoxHuman_PDA.Text != "") && (fa.textBoxPhone_PDA.Text != "")
                && (fa.textBoxDate_PDA.Text != "") && (fa.textBoxAdres_PDA.Text != "") && (fa.textBoxZarplata_PDA.Text != "")
                && (fa.textBoxWork_PDA.Text != ""))
                {
                    dataGridViewList_PDA.Rows.Add(1);
                    int index = dataGridViewList_PDA.Rows.Count - 2;
                    dataGridViewList_PDA.Rows[index].Cells[0].Value = fa.textBoxNumberDoc_PDA.Text;
                    dataGridViewList_PDA.Rows[index].Cells[1].Value = fa.textBoxHuman_PDA.Text;
                    dataGridViewList_PDA.Rows[index].Cells[2].Value = fa.textBoxPhone_PDA.Text;
                    dataGridViewList_PDA.Rows[index].Cells[3].Value = fa.textBoxDate_PDA.Text;
                    dataGridViewList_PDA.Rows[index].Cells[4].Value = fa.textBoxAdres_PDA.Text;
                    dataGridViewList_PDA.Rows[index].Cells[5].Value = fa.textBoxZarplata_PDA.Text;
                    dataGridViewList_PDA.Rows[index].Cells[6].Value = fa.textBoxWork_PDA.Text;
                }
                else
                {
                    MessageBox.Show("��������� ��� ����!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonFilter_PDA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewList_PDA.Rows)
            {
                row.Visible = true;
            }
            FormFilter ff = new FormFilter();
            if (ff.ShowDialog() == DialogResult.OK)
            {
                if ((ff.comboBoxData_PDA.Text != "") || (ff.comboBoxOklad_PDA.Text != ""))
                {
                    for (int i = 0; i < dataGridViewList_PDA.Rows.Count - 1; i++)
                    {
                        string lineData = dataGridViewList_PDA.Rows[i].Cells[3].Value.ToString();
                        string lineZp = dataGridViewList_PDA.Rows[i].Cells[5].Value.ToString();
                        if (ff.comboBoxData_PDA.SelectedItem == "�� 2024 ����")
                        {
                            if (lineData == null)
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                            else if (lineData[9] >= '4')
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                        }
                        else if (ff.comboBoxData_PDA.SelectedItem == "� 2024 ����")
                        {
                            if (lineData == null)
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                            else if (lineData[9] < '4')
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                        }
                        if (ff.comboBoxOklad_PDA.SelectedItem == "0-30000")
                        {
                            if (lineZp == null)
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                            else if (Convert.ToInt32(lineZp) >= 30000)
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                        }
                        if (ff.comboBoxOklad_PDA.SelectedItem == "30000-50000")
                        {
                            if (lineData == null)
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                            else if ((Convert.ToInt32(lineZp) < 30000) || (Convert.ToInt32(lineZp) >= 50000))
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                        }
                        if (ff.comboBoxOklad_PDA.SelectedItem == "50000-80000")
                        {
                            if (lineData == null)
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                            else if ((Convert.ToInt32(lineZp) < 50000) || (Convert.ToInt32(lineZp) >= 80000))
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                        }
                        if (ff.comboBoxOklad_PDA.SelectedItem == "80000 � ������")
                        {
                            if (lineZp == null)
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                            else if (Convert.ToInt32(lineZp) < 80000)
                            {
                                dataGridViewList_PDA.Rows[i].Visible = false;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("�������� ������ ���������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void saveFile()
        {
            string pt = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\��������\���� ������";
            string path = Path.Combine(pt, comboBoxChoice_PDA.Text + ".csv");
            using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
            {
                for (int j = 0; j < dataGridViewList_PDA.ColumnCount; j++)
                {
                    writer.Write(dataGridViewList_PDA.Columns[j].HeaderText);
                    if (j < dataGridViewList_PDA.ColumnCount - 1)
                    {
                        writer.Write(";");
                    }
                }
                writer.WriteLine();

                for (int i = 0; i < dataGridViewList_PDA.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewList_PDA.ColumnCount; j++)
                    {
                        writer.Write((dataGridViewList_PDA[j, i].Value ?? "").ToString());
                        if (j < dataGridViewList_PDA.ColumnCount - 1)
                        {
                            writer.Write(";");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }
        private void buttonSave_PDA_Click(object sender, EventArgs e)
        {
            saveFile();

        }

        private void buttonSaveAs_PDA_Click(object sender, EventArgs e)
        {
            saveFileDialog_PDA.FileName = "";
            saveFileDialog_PDA.InitialDirectory = Directory.GetCurrentDirectory();
            string f = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\��������\���� ������";
            string file = Path.Combine(f, comboBoxChoice_PDA.Text + ".csv");
            if (saveFileDialog_PDA.ShowDialog() == DialogResult.OK)
            {
                string pathSave = saveFileDialog_PDA.FileName;

                string fileCSV = "";
                for (int i = 0; i < dataGridViewList_PDA.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewList_PDA.ColumnCount; j++)
                    {
                        fileCSV += (dataGridViewList_PDA[j, i].Value ?? "").ToString() + ";";
                    }
                    fileCSV += "\r\n";
                }

                using (StreamWriter wr = new StreamWriter(pathSave, false, Encoding.UTF8))
                {
                    wr.Write(fileCSV);
                }
            }
            saveFile();
        }

        private void buttonPlus_PDA_Click(object sender, EventArgs e)
        {
            FormAddOrganization fao = new FormAddOrganization();
            if (fao.ShowDialog() == DialogResult.OK)
            {
                if ((fao.comboBoxAddDocument_PDA.Text != "") && (fao.textBoxAddNameOrg_PDA.Text != ""))
                {
                    comboBoxChoice_PDA.Items.Add(fao.textBoxAddNameOrg_PDA.Text);
                }
                else
                {
                    MessageBox.Show("��������� ��� ����!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonMinus_PDA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                if (comboBoxChoice_PDA.Text != "")
                {
                    if (MessageBox.Show("�� �������, ��� ������ ������� �����������?", "������", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {

                        string srtr = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\��������\�����������\Organization.csv";
                        string item = comboBoxChoice_PDA.Text;
                        ds.DeleteItemChoice(srtr, item);
                        comboBoxChoice_PDA.Items.RemoveAt(comboBoxChoice_PDA.SelectedIndex);
                    }
                }
                else
                {
                    MessageBox.Show("�������� �����������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("�������� �����������!", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDeleteRow_PDA_Click(object sender, EventArgs e)
        {
            int delet = dataGridViewList_PDA.SelectedCells[0].RowIndex;
            dataGridViewList_PDA.Rows.RemoveAt(delet);
        }

        private void buttonSumOklad_PDA_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += Convert.ToInt32(dataGridViewList_PDA.Rows[i].Cells[5].Value);
            }
            MessageBox.Show(sum.ToString() + " ���.", "��������� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
