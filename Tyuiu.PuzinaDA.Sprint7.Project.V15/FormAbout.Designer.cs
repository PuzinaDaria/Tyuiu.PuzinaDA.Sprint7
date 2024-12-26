namespace Tyuiu.PuzinaDA.Sprint7.Project.V15
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAbout_PDA = new PictureBox();
            textBoxAbout_PDA = new TextBox();
            buttonOk_PDA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_PDA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAbout_PDA
            // 
            pictureBoxAbout_PDA.Image = (Image)resources.GetObject("pictureBoxAbout_PDA.Image");
            pictureBoxAbout_PDA.Location = new Point(12, 12);
            pictureBoxAbout_PDA.Name = "pictureBoxAbout_PDA";
            pictureBoxAbout_PDA.Size = new Size(151, 203);
            pictureBoxAbout_PDA.TabIndex = 0;
            pictureBoxAbout_PDA.TabStop = false;
            // 
            // textBoxAbout_PDA
            // 
            textBoxAbout_PDA.BorderStyle = BorderStyle.None;
            textBoxAbout_PDA.Location = new Point(183, 12);
            textBoxAbout_PDA.Multiline = true;
            textBoxAbout_PDA.Name = "textBoxAbout_PDA";
            textBoxAbout_PDA.ReadOnly = true;
            textBoxAbout_PDA.Size = new Size(401, 184);
            textBoxAbout_PDA.TabIndex = 1;
            textBoxAbout_PDA.TabStop = false;
            textBoxAbout_PDA.Text = resources.GetString("textBoxAbout_PDA.Text");
            // 
            // buttonOk_PDA
            // 
            buttonOk_PDA.BackColor = Color.Linen;
            buttonOk_PDA.Location = new Point(490, 186);
            buttonOk_PDA.Name = "buttonOk_PDA";
            buttonOk_PDA.Size = new Size(94, 29);
            buttonOk_PDA.TabIndex = 2;
            buttonOk_PDA.Text = "OK";
            buttonOk_PDA.UseVisualStyleBackColor = false;
            buttonOk_PDA.Click += buttonOk_PDA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 223);
            Controls.Add(buttonOk_PDA);
            Controls.Add(textBoxAbout_PDA);
            Controls.Add(pictureBoxAbout_PDA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_PDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAbout_PDA;
        private TextBox textBoxAbout_PDA;
        private Button buttonOk_PDA;
    }
}