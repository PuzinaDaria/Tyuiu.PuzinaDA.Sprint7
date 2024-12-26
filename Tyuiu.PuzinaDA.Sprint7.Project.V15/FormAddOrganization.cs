using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PuzinaDA.Sprint7.Project.V15
{
    public partial class FormAddOrganization : Form
    {
        public FormAddOrganization()
        {
            InitializeComponent();
        }

        private void buttonAddOrg_PDA_Click(object sender, EventArgs e)
        {
            string path;
            
            try
            {
                if ((comboBoxAddDocument_PDA.Text != "") && (textBoxAddNameOrg_PDA.Text != ""))
                {
                    path = Path.Combine(@"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\Материал\База данных", textBoxAddNameOrg_PDA.Text + ".csv");
                    string fileOrg = @"C:\Users\daria\source\repos\Tyuiu.PuzinaDA.Sprint7\Материал\Организации\Organization.csv";
                    if (comboBoxAddDocument_PDA.SelectedItem == "Создать документ")
                    {
                        File.Create(path);

                    }
                    if (comboBoxAddDocument_PDA.SelectedItem == "Добавить доукмент")
                    {
                        openFileDialogAdd_PDA.ShowDialog();
                        string openFilePath = openFileDialogAdd_PDA.FileName;
                        File.Copy(openFilePath, path);
                    }
                    File.AppendAllText(fileOrg, Environment.NewLine + textBoxAddNameOrg_PDA.Text);
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
