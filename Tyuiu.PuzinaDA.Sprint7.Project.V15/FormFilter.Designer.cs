namespace Tyuiu.PuzinaDA.Sprint7.Project.V15
{
    partial class FormFilter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxZP_PDA = new TextBox();
            textBoxAdres_PDA = new TextBox();
            textBoxWorks_PDA = new TextBox();
            comboBoxOklad_PDA = new ComboBox();
            comboBoxData_PDA = new ComboBox();
            comboBoxWork_PDA = new ComboBox();
            buttonFilter_PDA = new Button();
            SuspendLayout();
            // 
            // textBoxZP_PDA
            // 
            textBoxZP_PDA.BorderStyle = BorderStyle.None;
            textBoxZP_PDA.Location = new Point(11, 12);
            textBoxZP_PDA.Name = "textBoxZP_PDA";
            textBoxZP_PDA.ReadOnly = true;
            textBoxZP_PDA.Size = new Size(125, 20);
            textBoxZP_PDA.TabIndex = 4;
            textBoxZP_PDA.Text = "Оклад";
            // 
            // textBoxAdres_PDA
            // 
            textBoxAdres_PDA.BorderStyle = BorderStyle.None;
            textBoxAdres_PDA.Location = new Point(11, 45);
            textBoxAdres_PDA.Name = "textBoxAdres_PDA";
            textBoxAdres_PDA.ReadOnly = true;
            textBoxAdres_PDA.Size = new Size(125, 20);
            textBoxAdres_PDA.TabIndex = 5;
            textBoxAdres_PDA.Text = "Дата";
            // 
            // textBoxWorks_PDA
            // 
            textBoxWorks_PDA.BackColor = SystemColors.Control;
            textBoxWorks_PDA.BorderStyle = BorderStyle.None;
            textBoxWorks_PDA.Location = new Point(11, 78);
            textBoxWorks_PDA.Name = "textBoxWorks_PDA";
            textBoxWorks_PDA.Size = new Size(125, 20);
            textBoxWorks_PDA.TabIndex = 6;
            textBoxWorks_PDA.Text = "Должность";
            // 
            // comboBoxOklad_PDA
            // 
            comboBoxOklad_PDA.FormattingEnabled = true;
            comboBoxOklad_PDA.Items.AddRange(new object[] { "0-30000", "30000-50000", "50000-80000", "80000-100000" });
            comboBoxOklad_PDA.Location = new Point(155, 11);
            comboBoxOklad_PDA.Name = "comboBoxOklad_PDA";
            comboBoxOklad_PDA.Size = new Size(151, 28);
            comboBoxOklad_PDA.TabIndex = 7;
            // 
            // comboBoxData_PDA
            // 
            comboBoxData_PDA.FormattingEnabled = true;
            comboBoxData_PDA.Items.AddRange(new object[] { "до 2024 года", "с 2024 года" });
            comboBoxData_PDA.Location = new Point(155, 45);
            comboBoxData_PDA.Name = "comboBoxData_PDA";
            comboBoxData_PDA.Size = new Size(151, 28);
            comboBoxData_PDA.TabIndex = 7;
            // 
            // comboBoxWork_PDA
            // 
            comboBoxWork_PDA.FormattingEnabled = true;
            comboBoxWork_PDA.Items.AddRange(new object[] { "Директора", "Руководители", "Аналитики", "Продвижение компании", "IT-специалисты", "Уборщики и электрики", "Инженеры" });
            comboBoxWork_PDA.Location = new Point(155, 77);
            comboBoxWork_PDA.Name = "comboBoxWork_PDA";
            comboBoxWork_PDA.Size = new Size(151, 28);
            comboBoxWork_PDA.TabIndex = 7;
            // 
            // buttonFilter_PDA
            // 
            buttonFilter_PDA.DialogResult = DialogResult.OK;
            buttonFilter_PDA.Location = new Point(90, 111);
            buttonFilter_PDA.Name = "buttonFilter_PDA";
            buttonFilter_PDA.Size = new Size(108, 29);
            buttonFilter_PDA.TabIndex = 8;
            buttonFilter_PDA.Text = "Фильтровать";
            buttonFilter_PDA.UseVisualStyleBackColor = true;
            buttonFilter_PDA.Click += buttonFilter_PDA_Click;
            // 
            // FormFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 151);
            Controls.Add(buttonFilter_PDA);
            Controls.Add(comboBoxWork_PDA);
            Controls.Add(comboBoxData_PDA);
            Controls.Add(comboBoxOklad_PDA);
            Controls.Add(textBoxWorks_PDA);
            Controls.Add(textBoxAdres_PDA);
            Controls.Add(textBoxZP_PDA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Фильтрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxZP_PDA;
        private TextBox textBoxAdres_PDA;
        private TextBox textBoxWorks_PDA;
        public ComboBox comboBoxOklad_PDA;
        public ComboBox comboBoxData_PDA;
        public ComboBox comboBoxWork_PDA;
        private Button buttonFilter_PDA;
    }
}