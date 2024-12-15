namespace Tyuiu.PuzinaDA.Sprint7.Project.V15
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButton_PDA = new Panel();
            groupBoxFunction_PDA = new GroupBox();
            buttonSave_PDA = new Button();
            buttonAdd_PDA = new Button();
            buttonQuestion_PDA = new Button();
            buttonMinus_PDA = new Button();
            buttonPlus_PDA = new Button();
            comboBoxChoice_PDA = new ComboBox();
            groupBoxOrganization_PDA = new GroupBox();
            buttonDown_PDA = new Button();
            panelBut_PDA = new Panel();
            comboBoxSort_PDA = new ComboBox();
            buttonPlusLine_PDA = new Button();
            buttonFilter_PDA = new Button();
            buttonSorting_PDA = new Button();
            buttonSearch_PDA = new Button();
            textBoxSearch_PDA = new TextBox();
            panelDataGrid_PDA = new Panel();
            dataGridViewList_PDA = new DataGridView();
            НомерДокумента = new DataGridViewTextBoxColumn();
            Сотрудник = new DataGridViewTextBoxColumn();
            Телефон = new DataGridViewTextBoxColumn();
            Дата = new DataGridViewTextBoxColumn();
            Адрес = new DataGridViewTextBoxColumn();
            Оклад = new DataGridViewTextBoxColumn();
            Должность = new DataGridViewTextBoxColumn();
            openFileDialogDown_PDA = new OpenFileDialog();
            panelButton_PDA.SuspendLayout();
            groupBoxFunction_PDA.SuspendLayout();
            groupBoxOrganization_PDA.SuspendLayout();
            panelBut_PDA.SuspendLayout();
            panelDataGrid_PDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList_PDA).BeginInit();
            SuspendLayout();
            // 
            // panelButton_PDA
            // 
            panelButton_PDA.Controls.Add(groupBoxFunction_PDA);
            panelButton_PDA.Controls.Add(buttonMinus_PDA);
            panelButton_PDA.Controls.Add(buttonPlus_PDA);
            panelButton_PDA.Controls.Add(comboBoxChoice_PDA);
            panelButton_PDA.Controls.Add(groupBoxOrganization_PDA);
            panelButton_PDA.Dock = DockStyle.Top;
            panelButton_PDA.Location = new Point(0, 0);
            panelButton_PDA.Name = "panelButton_PDA";
            panelButton_PDA.Size = new Size(1063, 86);
            panelButton_PDA.TabIndex = 0;
            // 
            // groupBoxFunction_PDA
            // 
            groupBoxFunction_PDA.Controls.Add(buttonSave_PDA);
            groupBoxFunction_PDA.Controls.Add(buttonAdd_PDA);
            groupBoxFunction_PDA.Controls.Add(buttonQuestion_PDA);
            groupBoxFunction_PDA.Dock = DockStyle.Fill;
            groupBoxFunction_PDA.Location = new Point(394, 0);
            groupBoxFunction_PDA.Name = "groupBoxFunction_PDA";
            groupBoxFunction_PDA.Size = new Size(669, 86);
            groupBoxFunction_PDA.TabIndex = 6;
            groupBoxFunction_PDA.TabStop = false;
            groupBoxFunction_PDA.Text = "Функции";
            // 
            // buttonSave_PDA
            // 
            buttonSave_PDA.Location = new Point(110, 26);
            buttonSave_PDA.Name = "buttonSave_PDA";
            buttonSave_PDA.Size = new Size(95, 45);
            buttonSave_PDA.TabIndex = 2;
            buttonSave_PDA.Text = "Сохранить";
            buttonSave_PDA.UseVisualStyleBackColor = true;
            // 
            // buttonAdd_PDA
            // 
            buttonAdd_PDA.Location = new Point(18, 26);
            buttonAdd_PDA.Name = "buttonAdd_PDA";
            buttonAdd_PDA.Size = new Size(86, 45);
            buttonAdd_PDA.TabIndex = 1;
            buttonAdd_PDA.Text = "Добавить";
            buttonAdd_PDA.UseVisualStyleBackColor = true;
            // 
            // buttonQuestion_PDA
            // 
            buttonQuestion_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuestion_PDA.Location = new Point(611, 27);
            buttonQuestion_PDA.Name = "buttonQuestion_PDA";
            buttonQuestion_PDA.Size = new Size(46, 45);
            buttonQuestion_PDA.TabIndex = 0;
            buttonQuestion_PDA.UseVisualStyleBackColor = true;
            // 
            // buttonMinus_PDA
            // 
            buttonMinus_PDA.Location = new Point(213, 27);
            buttonMinus_PDA.Name = "buttonMinus_PDA";
            buttonMinus_PDA.Size = new Size(27, 28);
            buttonMinus_PDA.TabIndex = 2;
            buttonMinus_PDA.Text = "-";
            buttonMinus_PDA.UseVisualStyleBackColor = true;
            // 
            // buttonPlus_PDA
            // 
            buttonPlus_PDA.Location = new Point(180, 27);
            buttonPlus_PDA.Name = "buttonPlus_PDA";
            buttonPlus_PDA.Size = new Size(27, 28);
            buttonPlus_PDA.TabIndex = 1;
            buttonPlus_PDA.Text = "+";
            buttonPlus_PDA.UseVisualStyleBackColor = true;
            // 
            // comboBoxChoice_PDA
            // 
            comboBoxChoice_PDA.FormattingEnabled = true;
            comboBoxChoice_PDA.ItemHeight = 20;
            comboBoxChoice_PDA.Items.AddRange(new object[] { "ITSpin" });
            comboBoxChoice_PDA.Location = new Point(27, 27);
            comboBoxChoice_PDA.Name = "comboBoxChoice_PDA";
            comboBoxChoice_PDA.Size = new Size(147, 28);
            comboBoxChoice_PDA.Sorted = true;
            comboBoxChoice_PDA.TabIndex = 0;
            // 
            // groupBoxOrganization_PDA
            // 
            groupBoxOrganization_PDA.Controls.Add(buttonDown_PDA);
            groupBoxOrganization_PDA.Dock = DockStyle.Left;
            groupBoxOrganization_PDA.Location = new Point(0, 0);
            groupBoxOrganization_PDA.Name = "groupBoxOrganization_PDA";
            groupBoxOrganization_PDA.Size = new Size(394, 86);
            groupBoxOrganization_PDA.TabIndex = 5;
            groupBoxOrganization_PDA.TabStop = false;
            groupBoxOrganization_PDA.Text = "Выбор организации";
            // 
            // buttonDown_PDA
            // 
            buttonDown_PDA.Location = new Point(265, 51);
            buttonDown_PDA.Name = "buttonDown_PDA";
            buttonDown_PDA.Size = new Size(94, 29);
            buttonDown_PDA.TabIndex = 0;
            buttonDown_PDA.Text = "Вывести";
            buttonDown_PDA.UseVisualStyleBackColor = true;
            buttonDown_PDA.Click += buttonDown_PDA_Click;
            // 
            // panelBut_PDA
            // 
            panelBut_PDA.Controls.Add(comboBoxSort_PDA);
            panelBut_PDA.Controls.Add(buttonPlusLine_PDA);
            panelBut_PDA.Controls.Add(buttonFilter_PDA);
            panelBut_PDA.Controls.Add(buttonSorting_PDA);
            panelBut_PDA.Controls.Add(buttonSearch_PDA);
            panelBut_PDA.Controls.Add(textBoxSearch_PDA);
            panelBut_PDA.Dock = DockStyle.Top;
            panelBut_PDA.Location = new Point(0, 86);
            panelBut_PDA.Name = "panelBut_PDA";
            panelBut_PDA.Size = new Size(1063, 35);
            panelBut_PDA.TabIndex = 1;
            // 
            // comboBoxSort_PDA
            // 
            comboBoxSort_PDA.FormattingEnabled = true;
            comboBoxSort_PDA.Items.AddRange(new object[] { "Номер документа", "Сотрудник", "Телефон", "Адрес", "Оклад", "Должность" });
            comboBoxSort_PDA.Location = new Point(390, 5);
            comboBoxSort_PDA.Name = "comboBoxSort_PDA";
            comboBoxSort_PDA.Size = new Size(108, 28);
            comboBoxSort_PDA.TabIndex = 6;
            // 
            // buttonPlusLine_PDA
            // 
            buttonPlusLine_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPlusLine_PDA.Location = new Point(895, 5);
            buttonPlusLine_PDA.Name = "buttonPlusLine_PDA";
            buttonPlusLine_PDA.Size = new Size(28, 29);
            buttonPlusLine_PDA.TabIndex = 5;
            buttonPlusLine_PDA.Text = "+";
            buttonPlusLine_PDA.UseVisualStyleBackColor = true;
            // 
            // buttonFilter_PDA
            // 
            buttonFilter_PDA.Location = new Point(12, 3);
            buttonFilter_PDA.Name = "buttonFilter_PDA";
            buttonFilter_PDA.Size = new Size(94, 29);
            buttonFilter_PDA.TabIndex = 4;
            buttonFilter_PDA.Text = "Фильтр";
            buttonFilter_PDA.UseVisualStyleBackColor = true;
            // 
            // buttonSorting_PDA
            // 
            buttonSorting_PDA.Location = new Point(504, 3);
            buttonSorting_PDA.Name = "buttonSorting_PDA";
            buttonSorting_PDA.Size = new Size(104, 29);
            buttonSorting_PDA.TabIndex = 3;
            buttonSorting_PDA.Text = "Сортировка";
            buttonSorting_PDA.UseVisualStyleBackColor = true;
            buttonSorting_PDA.Click += buttonSorting_PDA_Click;
            // 
            // buttonSearch_PDA
            // 
            buttonSearch_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch_PDA.Location = new Point(1033, 6);
            buttonSearch_PDA.Name = "buttonSearch_PDA";
            buttonSearch_PDA.Size = new Size(27, 24);
            buttonSearch_PDA.TabIndex = 2;
            buttonSearch_PDA.Text = "button6";
            buttonSearch_PDA.UseVisualStyleBackColor = true;
            buttonSearch_PDA.Click += buttonSearch_PDA_Click;
            // 
            // textBoxSearch_PDA
            // 
            textBoxSearch_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch_PDA.Location = new Point(929, 5);
            textBoxSearch_PDA.Name = "textBoxSearch_PDA";
            textBoxSearch_PDA.Size = new Size(98, 27);
            textBoxSearch_PDA.TabIndex = 1;
            // 
            // panelDataGrid_PDA
            // 
            panelDataGrid_PDA.Controls.Add(dataGridViewList_PDA);
            panelDataGrid_PDA.Dock = DockStyle.Fill;
            panelDataGrid_PDA.Location = new Point(0, 121);
            panelDataGrid_PDA.Name = "panelDataGrid_PDA";
            panelDataGrid_PDA.Size = new Size(1063, 502);
            panelDataGrid_PDA.TabIndex = 2;
            // 
            // dataGridViewList_PDA
            // 
            dataGridViewList_PDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList_PDA.Columns.AddRange(new DataGridViewColumn[] { НомерДокумента, Сотрудник, Телефон, Дата, Адрес, Оклад, Должность });
            dataGridViewList_PDA.Dock = DockStyle.Fill;
            dataGridViewList_PDA.Location = new Point(0, 0);
            dataGridViewList_PDA.Name = "dataGridViewList_PDA";
            dataGridViewList_PDA.RowHeadersVisible = false;
            dataGridViewList_PDA.RowHeadersWidth = 51;
            dataGridViewList_PDA.ScrollBars = ScrollBars.Vertical;
            dataGridViewList_PDA.Size = new Size(1063, 502);
            dataGridViewList_PDA.TabIndex = 0;
            // 
            // НомерДокумента
            // 
            НомерДокумента.HeaderText = "Номер документа";
            НомерДокумента.MinimumWidth = 6;
            НомерДокумента.Name = "НомерДокумента";
            НомерДокумента.Width = 125;
            // 
            // Сотрудник
            // 
            Сотрудник.HeaderText = "Сотрудник";
            Сотрудник.MinimumWidth = 6;
            Сотрудник.Name = "Сотрудник";
            Сотрудник.Width = 125;
            // 
            // Телефон
            // 
            Телефон.HeaderText = "Телефон";
            Телефон.MinimumWidth = 6;
            Телефон.Name = "Телефон";
            Телефон.Width = 125;
            // 
            // Дата
            // 
            Дата.HeaderText = "Дата";
            Дата.MinimumWidth = 6;
            Дата.Name = "Дата";
            Дата.Width = 125;
            // 
            // Адрес
            // 
            Адрес.HeaderText = "Адрес";
            Адрес.MinimumWidth = 6;
            Адрес.Name = "Адрес";
            Адрес.Width = 125;
            // 
            // Оклад
            // 
            Оклад.HeaderText = "Оклад";
            Оклад.MinimumWidth = 6;
            Оклад.Name = "Оклад";
            Оклад.Width = 125;
            // 
            // Должность
            // 
            Должность.HeaderText = "Должность";
            Должность.MinimumWidth = 6;
            Должность.Name = "Должность";
            Должность.Width = 125;
            // 
            // openFileDialogDown_PDA
            // 
            openFileDialogDown_PDA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 623);
            Controls.Add(panelDataGrid_PDA);
            Controls.Add(panelBut_PDA);
            Controls.Add(panelButton_PDA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Договорная деятельность организаций";
            panelButton_PDA.ResumeLayout(false);
            groupBoxFunction_PDA.ResumeLayout(false);
            groupBoxOrganization_PDA.ResumeLayout(false);
            panelBut_PDA.ResumeLayout(false);
            panelBut_PDA.PerformLayout();
            panelDataGrid_PDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewList_PDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButton_PDA;
        private ComboBox comboBoxChoice_PDA;
        private Button buttonMinus_PDA;
        private Button buttonPlus_PDA;
        private GroupBox groupBoxFunction_PDA;
        private Button buttonAdd_PDA;
        private Button buttonQuestion_PDA;
        private GroupBox groupBoxOrganization_PDA;
        private Button buttonSave_PDA;
        private Panel panelBut_PDA;
        private Panel panelDataGrid_PDA;
        private DataGridView dataGridViewList_PDA;
        private Button buttonFilter_PDA;
        private Button buttonSorting_PDA;
        private Button buttonSearch_PDA;
        private TextBox textBoxSearch_PDA;
        private Button buttonPlusLine_PDA;
        private Button buttonDown_PDA;
        private OpenFileDialog openFileDialogDown_PDA;
        private DataGridViewTextBoxColumn НомерДокумента;
        private DataGridViewTextBoxColumn Сотрудник;
        private DataGridViewTextBoxColumn Телефон;
        private DataGridViewTextBoxColumn Дата;
        private DataGridViewTextBoxColumn Адрес;
        private DataGridViewTextBoxColumn Оклад;
        private DataGridViewTextBoxColumn Должность;
        private ComboBox comboBoxSort_PDA;
    }
}
