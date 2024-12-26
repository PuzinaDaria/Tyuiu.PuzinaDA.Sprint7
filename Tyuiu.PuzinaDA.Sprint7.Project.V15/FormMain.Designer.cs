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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtonMain_PDA = new Panel();
            groupBoxFunction_PDA = new GroupBox();
            buttonSaveAs_PDA = new Button();
            buttonSave_PDA = new Button();
            buttonQuestion_PDA = new Button();
            buttonMinus_PDA = new Button();
            buttonPlus_PDA = new Button();
            comboBoxChoice_PDA = new ComboBox();
            groupBoxOrganization_PDA = new GroupBox();
            buttonDown_PDA = new Button();
            panelButton_PDA = new Panel();
            buttonSumOklad_PDA = new Button();
            buttonDeleteRow_PDA = new Button();
            comboBoxSort_PDA = new ComboBox();
            buttonPlusLine_PDA = new Button();
            buttonFilter_PDA = new Button();
            buttonSorting_PDA = new Button();
            buttonSearch_PDA = new Button();
            textBoxSearch_PDA = new TextBox();
            panelDataGrid_PDA = new Panel();
            dataGridViewList_PDA = new DataGridView();
            NumberDocument = new DataGridViewTextBoxColumn();
            Human = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Adres = new DataGridViewTextBoxColumn();
            Zarplata = new DataGridViewTextBoxColumn();
            Work = new DataGridViewTextBoxColumn();
            openFileDialogDown_PDA = new OpenFileDialog();
            saveFileDialog_PDA = new SaveFileDialog();
            toolTip_PDA = new ToolTip(components);
            panelButtonMain_PDA.SuspendLayout();
            groupBoxFunction_PDA.SuspendLayout();
            groupBoxOrganization_PDA.SuspendLayout();
            panelButton_PDA.SuspendLayout();
            panelDataGrid_PDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewList_PDA).BeginInit();
            SuspendLayout();
            // 
            // panelButtonMain_PDA
            // 
            panelButtonMain_PDA.Controls.Add(groupBoxFunction_PDA);
            panelButtonMain_PDA.Controls.Add(buttonMinus_PDA);
            panelButtonMain_PDA.Controls.Add(buttonPlus_PDA);
            panelButtonMain_PDA.Controls.Add(comboBoxChoice_PDA);
            panelButtonMain_PDA.Controls.Add(groupBoxOrganization_PDA);
            panelButtonMain_PDA.Dock = DockStyle.Top;
            panelButtonMain_PDA.Location = new Point(0, 0);
            panelButtonMain_PDA.Name = "panelButtonMain_PDA";
            panelButtonMain_PDA.Size = new Size(1280, 86);
            panelButtonMain_PDA.TabIndex = 0;
            // 
            // groupBoxFunction_PDA
            // 
            groupBoxFunction_PDA.Controls.Add(buttonSaveAs_PDA);
            groupBoxFunction_PDA.Controls.Add(buttonSave_PDA);
            groupBoxFunction_PDA.Controls.Add(buttonQuestion_PDA);
            groupBoxFunction_PDA.Dock = DockStyle.Fill;
            groupBoxFunction_PDA.Location = new Point(394, 0);
            groupBoxFunction_PDA.Name = "groupBoxFunction_PDA";
            groupBoxFunction_PDA.Size = new Size(886, 86);
            groupBoxFunction_PDA.TabIndex = 6;
            groupBoxFunction_PDA.TabStop = false;
            groupBoxFunction_PDA.Text = "Функции";
            // 
            // buttonSaveAs_PDA
            // 
            buttonSaveAs_PDA.BackColor = SystemColors.ActiveCaption;
            buttonSaveAs_PDA.Enabled = false;
            buttonSaveAs_PDA.Location = new Point(103, 28);
            buttonSaveAs_PDA.Name = "buttonSaveAs_PDA";
            buttonSaveAs_PDA.Size = new Size(117, 45);
            buttonSaveAs_PDA.TabIndex = 3;
            buttonSaveAs_PDA.Text = "Сохранить как";
            buttonSaveAs_PDA.UseVisualStyleBackColor = false;
            buttonSaveAs_PDA.Click += buttonSaveAs_PDA_Click;
            // 
            // buttonSave_PDA
            // 
            buttonSave_PDA.BackColor = Color.FromArgb(192, 255, 255);
            buttonSave_PDA.Enabled = false;
            buttonSave_PDA.Location = new Point(6, 27);
            buttonSave_PDA.Name = "buttonSave_PDA";
            buttonSave_PDA.Size = new Size(91, 46);
            buttonSave_PDA.TabIndex = 2;
            buttonSave_PDA.Text = "Сохранить";
            buttonSave_PDA.UseVisualStyleBackColor = false;
            buttonSave_PDA.Click += buttonSave_PDA_Click;
            // 
            // buttonQuestion_PDA
            // 
            buttonQuestion_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonQuestion_PDA.Image = (Image)resources.GetObject("buttonQuestion_PDA.Image");
            buttonQuestion_PDA.Location = new Point(828, 27);
            buttonQuestion_PDA.Name = "buttonQuestion_PDA";
            buttonQuestion_PDA.Size = new Size(46, 45);
            buttonQuestion_PDA.TabIndex = 0;
            buttonQuestion_PDA.UseVisualStyleBackColor = true;
            buttonQuestion_PDA.Click += buttonQuestion_PDA_Click;
            // 
            // buttonMinus_PDA
            // 
            buttonMinus_PDA.BackColor = Color.IndianRed;
            buttonMinus_PDA.Location = new Point(213, 27);
            buttonMinus_PDA.Name = "buttonMinus_PDA";
            buttonMinus_PDA.Size = new Size(27, 28);
            buttonMinus_PDA.TabIndex = 2;
            buttonMinus_PDA.Text = "-";
            buttonMinus_PDA.UseVisualStyleBackColor = false;
            buttonMinus_PDA.Click += buttonMinus_PDA_Click;
            // 
            // buttonPlus_PDA
            // 
            buttonPlus_PDA.BackColor = Color.YellowGreen;
            buttonPlus_PDA.Location = new Point(180, 27);
            buttonPlus_PDA.Name = "buttonPlus_PDA";
            buttonPlus_PDA.Size = new Size(27, 28);
            buttonPlus_PDA.TabIndex = 1;
            buttonPlus_PDA.Text = "+";
            buttonPlus_PDA.UseVisualStyleBackColor = false;
            buttonPlus_PDA.Click += buttonPlus_PDA_Click;
            // 
            // comboBoxChoice_PDA
            // 
            comboBoxChoice_PDA.FormattingEnabled = true;
            comboBoxChoice_PDA.ItemHeight = 20;
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
            buttonDown_PDA.BackColor = Color.Pink;
            buttonDown_PDA.Location = new Point(265, 51);
            buttonDown_PDA.Name = "buttonDown_PDA";
            buttonDown_PDA.Size = new Size(94, 29);
            buttonDown_PDA.TabIndex = 0;
            buttonDown_PDA.Text = "Вывести";
            buttonDown_PDA.UseVisualStyleBackColor = false;
            buttonDown_PDA.Click += buttonDown_PDA_Click;
            // 
            // panelButton_PDA
            // 
            panelButton_PDA.Controls.Add(buttonSumOklad_PDA);
            panelButton_PDA.Controls.Add(buttonDeleteRow_PDA);
            panelButton_PDA.Controls.Add(comboBoxSort_PDA);
            panelButton_PDA.Controls.Add(buttonPlusLine_PDA);
            panelButton_PDA.Controls.Add(buttonFilter_PDA);
            panelButton_PDA.Controls.Add(buttonSorting_PDA);
            panelButton_PDA.Controls.Add(buttonSearch_PDA);
            panelButton_PDA.Controls.Add(textBoxSearch_PDA);
            panelButton_PDA.Dock = DockStyle.Top;
            panelButton_PDA.Location = new Point(0, 86);
            panelButton_PDA.Name = "panelButton_PDA";
            panelButton_PDA.Size = new Size(1280, 48);
            panelButton_PDA.TabIndex = 1;
            // 
            // buttonSumOklad_PDA
            // 
            buttonSumOklad_PDA.BackColor = Color.FromArgb(255, 255, 192);
            buttonSumOklad_PDA.Enabled = false;
            buttonSumOklad_PDA.Location = new Point(937, 11);
            buttonSumOklad_PDA.Name = "buttonSumOklad_PDA";
            buttonSumOklad_PDA.Size = new Size(94, 29);
            buttonSumOklad_PDA.TabIndex = 8;
            buttonSumOklad_PDA.Text = "Оклад";
            buttonSumOklad_PDA.UseVisualStyleBackColor = false;
            buttonSumOklad_PDA.Click += buttonSumOklad_PDA_Click;
            // 
            // buttonDeleteRow_PDA
            // 
            buttonDeleteRow_PDA.BackColor = Color.LightCoral;
            buttonDeleteRow_PDA.Enabled = false;
            buttonDeleteRow_PDA.Location = new Point(556, 12);
            buttonDeleteRow_PDA.Name = "buttonDeleteRow_PDA";
            buttonDeleteRow_PDA.Size = new Size(127, 29);
            buttonDeleteRow_PDA.TabIndex = 7;
            buttonDeleteRow_PDA.Text = "Удалить строку";
            buttonDeleteRow_PDA.UseVisualStyleBackColor = false;
            buttonDeleteRow_PDA.Click += buttonDeleteRow_PDA_Click;
            // 
            // comboBoxSort_PDA
            // 
            comboBoxSort_PDA.Enabled = false;
            comboBoxSort_PDA.FormattingEnabled = true;
            comboBoxSort_PDA.Items.AddRange(new object[] { "Номер документа", "Сотрудник", "Телефон", "Адрес", "Оклад", "Должность" });
            comboBoxSort_PDA.Location = new Point(265, 12);
            comboBoxSort_PDA.Name = "comboBoxSort_PDA";
            comboBoxSort_PDA.Size = new Size(108, 28);
            comboBoxSort_PDA.TabIndex = 6;
            // 
            // buttonPlusLine_PDA
            // 
            buttonPlusLine_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonPlusLine_PDA.BackColor = Color.FromArgb(192, 255, 192);
            buttonPlusLine_PDA.Enabled = false;
            buttonPlusLine_PDA.Location = new Point(711, 11);
            buttonPlusLine_PDA.Name = "buttonPlusLine_PDA";
            buttonPlusLine_PDA.Size = new Size(135, 29);
            buttonPlusLine_PDA.TabIndex = 5;
            buttonPlusLine_PDA.Text = "Добавить строку";
            buttonPlusLine_PDA.UseVisualStyleBackColor = false;
            buttonPlusLine_PDA.Click += buttonPlusLine_PDA_Click;
            // 
            // buttonFilter_PDA
            // 
            buttonFilter_PDA.BackColor = Color.MistyRose;
            buttonFilter_PDA.Enabled = false;
            buttonFilter_PDA.Location = new Point(12, 11);
            buttonFilter_PDA.Name = "buttonFilter_PDA";
            buttonFilter_PDA.Size = new Size(94, 29);
            buttonFilter_PDA.TabIndex = 4;
            buttonFilter_PDA.Text = "Фильтр";
            buttonFilter_PDA.UseVisualStyleBackColor = false;
            buttonFilter_PDA.Click += buttonFilter_PDA_Click;
            // 
            // buttonSorting_PDA
            // 
            buttonSorting_PDA.BackColor = Color.MintCream;
            buttonSorting_PDA.Enabled = false;
            buttonSorting_PDA.Location = new Point(379, 12);
            buttonSorting_PDA.Name = "buttonSorting_PDA";
            buttonSorting_PDA.Size = new Size(104, 29);
            buttonSorting_PDA.TabIndex = 3;
            buttonSorting_PDA.Text = "Сортировка";
            buttonSorting_PDA.UseVisualStyleBackColor = false;
            buttonSorting_PDA.Click += buttonSorting_PDA_Click;
            // 
            // buttonSearch_PDA
            // 
            buttonSearch_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch_PDA.Enabled = false;
            buttonSearch_PDA.Image = (Image)resources.GetObject("buttonSearch_PDA.Image");
            buttonSearch_PDA.Location = new Point(1239, 12);
            buttonSearch_PDA.Name = "buttonSearch_PDA";
            buttonSearch_PDA.Size = new Size(38, 30);
            buttonSearch_PDA.TabIndex = 2;
            buttonSearch_PDA.UseVisualStyleBackColor = true;
            buttonSearch_PDA.Click += buttonSearch_PDA_Click;
            // 
            // textBoxSearch_PDA
            // 
            textBoxSearch_PDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch_PDA.Enabled = false;
            textBoxSearch_PDA.Location = new Point(1135, 14);
            textBoxSearch_PDA.Name = "textBoxSearch_PDA";
            textBoxSearch_PDA.Size = new Size(98, 27);
            textBoxSearch_PDA.TabIndex = 1;
            // 
            // panelDataGrid_PDA
            // 
            panelDataGrid_PDA.Controls.Add(dataGridViewList_PDA);
            panelDataGrid_PDA.Dock = DockStyle.Fill;
            panelDataGrid_PDA.Location = new Point(0, 134);
            panelDataGrid_PDA.Name = "panelDataGrid_PDA";
            panelDataGrid_PDA.Size = new Size(1280, 500);
            panelDataGrid_PDA.TabIndex = 2;
            // 
            // dataGridViewList_PDA
            // 
            dataGridViewList_PDA.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewList_PDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewList_PDA.Columns.AddRange(new DataGridViewColumn[] { NumberDocument, Human, Phone, Date, Adres, Zarplata, Work });
            dataGridViewList_PDA.Dock = DockStyle.Fill;
            dataGridViewList_PDA.Location = new Point(0, 0);
            dataGridViewList_PDA.Name = "dataGridViewList_PDA";
            dataGridViewList_PDA.RowHeadersVisible = false;
            dataGridViewList_PDA.RowHeadersWidth = 51;
            dataGridViewList_PDA.ScrollBars = ScrollBars.Vertical;
            dataGridViewList_PDA.Size = new Size(1280, 500);
            dataGridViewList_PDA.TabIndex = 0;
            // 
            // NumberDocument
            // 
            NumberDocument.HeaderText = "Номер документа";
            NumberDocument.MinimumWidth = 6;
            NumberDocument.Name = "NumberDocument";
            NumberDocument.Width = 125;
            // 
            // Human
            // 
            Human.HeaderText = "Сотрудник";
            Human.MinimumWidth = 6;
            Human.Name = "Human";
            Human.Width = 125;
            // 
            // Phone
            // 
            Phone.HeaderText = "Телефон";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Дата";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Adres
            // 
            Adres.HeaderText = "Адрес";
            Adres.MinimumWidth = 6;
            Adres.Name = "Adres";
            Adres.Width = 125;
            // 
            // Zarplata
            // 
            Zarplata.HeaderText = "Оклад";
            Zarplata.MinimumWidth = 6;
            Zarplata.Name = "Zarplata";
            Zarplata.Width = 125;
            // 
            // Work
            // 
            Work.HeaderText = "Должность";
            Work.MinimumWidth = 6;
            Work.Name = "Work";
            Work.Width = 125;
            // 
            // openFileDialogDown_PDA
            // 
            openFileDialogDown_PDA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 634);
            Controls.Add(panelDataGrid_PDA);
            Controls.Add(panelButton_PDA);
            Controls.Add(panelButtonMain_PDA);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Договорная деятельность организаций";
            Load += FormMain_Load;
            panelButtonMain_PDA.ResumeLayout(false);
            groupBoxFunction_PDA.ResumeLayout(false);
            groupBoxOrganization_PDA.ResumeLayout(false);
            panelButton_PDA.ResumeLayout(false);
            panelButton_PDA.PerformLayout();
            panelDataGrid_PDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewList_PDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtonMain_PDA;
        private ComboBox comboBoxChoice_PDA;
        private Button buttonMinus_PDA;
        private Button buttonPlus_PDA;
        private GroupBox groupBoxFunction_PDA;
        private Button buttonQuestion_PDA;
        private GroupBox groupBoxOrganization_PDA;
        private Button buttonSave_PDA;
        private Panel panelButton_PDA;
        private Panel panelDataGrid_PDA;
        private DataGridView dataGridViewList_PDA;
        private Button buttonFilter_PDA;
        private Button buttonSorting_PDA;
        private Button buttonSearch_PDA;
        private TextBox textBoxSearch_PDA;
        private Button buttonPlusLine_PDA;
        private Button buttonDown_PDA;
        private OpenFileDialog openFileDialogDown_PDA;
        private ComboBox comboBoxSort_PDA;
        private SaveFileDialog saveFileDialog_PDA;
        private Button buttonSaveAs_PDA;
        private Button buttonDeleteRow_PDA;
        private DataGridViewTextBoxColumn NumberDocument;
        private DataGridViewTextBoxColumn Human;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Adres;
        private DataGridViewTextBoxColumn Zarplata;
        private DataGridViewTextBoxColumn Work;
        private ToolTip toolTip_PDA;
        private Button buttonSumOklad_PDA;
    }
}
