namespace Tyuiu.PuzinaDA.Sprint7.Project.V15
{
    partial class FormAddOrganization
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
            textBoxOrganization_PDA = new TextBox();
            textBoxAddNameOrg_PDA = new TextBox();
            buttonAddOrg_PDA = new Button();
            comboBoxAddDocument_PDA = new ComboBox();
            openFileDialogAdd_PDA = new OpenFileDialog();
            SuspendLayout();
            // 
            // textBoxOrganization_PDA
            // 
            textBoxOrganization_PDA.BackColor = SystemColors.Control;
            textBoxOrganization_PDA.BorderStyle = BorderStyle.None;
            textBoxOrganization_PDA.Location = new Point(7, 7);
            textBoxOrganization_PDA.Name = "textBoxOrganization_PDA";
            textBoxOrganization_PDA.ReadOnly = true;
            textBoxOrganization_PDA.Size = new Size(229, 20);
            textBoxOrganization_PDA.TabIndex = 0;
            textBoxOrganization_PDA.Text = "Введите название организации";
            // 
            // textBoxAddNameOrg_PDA
            // 
            textBoxAddNameOrg_PDA.Location = new Point(7, 33);
            textBoxAddNameOrg_PDA.Name = "textBoxAddNameOrg_PDA";
            textBoxAddNameOrg_PDA.Size = new Size(229, 27);
            textBoxAddNameOrg_PDA.TabIndex = 1;
            // 
            // buttonAddOrg_PDA
            // 
            buttonAddOrg_PDA.DialogResult = DialogResult.OK;
            buttonAddOrg_PDA.Location = new Point(191, 66);
            buttonAddOrg_PDA.Name = "buttonAddOrg_PDA";
            buttonAddOrg_PDA.Size = new Size(45, 31);
            buttonAddOrg_PDA.TabIndex = 2;
            buttonAddOrg_PDA.Text = "OK";
            buttonAddOrg_PDA.UseVisualStyleBackColor = true;
            buttonAddOrg_PDA.Click += buttonAddOrg_PDA_Click;
            // 
            // comboBoxAddDocument_PDA
            // 
            comboBoxAddDocument_PDA.FormattingEnabled = true;
            comboBoxAddDocument_PDA.Items.AddRange(new object[] { "", "Создать документ", "Добавить доукмент" });
            comboBoxAddDocument_PDA.Location = new Point(7, 66);
            comboBoxAddDocument_PDA.Name = "comboBoxAddDocument_PDA";
            comboBoxAddDocument_PDA.Size = new Size(151, 28);
            comboBoxAddDocument_PDA.TabIndex = 3;
            // 
            // openFileDialogAdd_PDA
            // 
            openFileDialogAdd_PDA.FileName = "openFileDialog1";
            // 
            // FormAddOrganization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 102);
            Controls.Add(comboBoxAddDocument_PDA);
            Controls.Add(buttonAddOrg_PDA);
            Controls.Add(textBoxAddNameOrg_PDA);
            Controls.Add(textBoxOrganization_PDA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddOrganization";
            Text = "Добавить организацию";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxOrganization_PDA;
        public TextBox textBoxAddNameOrg_PDA;
        public Button buttonAddOrg_PDA;
        public ComboBox comboBoxAddDocument_PDA;
        private OpenFileDialog openFileDialogAdd_PDA;
    }
}