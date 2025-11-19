namespace person2
{
    partial class FrmAddPerson
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
            TxtName = new TextBox();
            TxtFamily = new TextBox();
            TxtNationalCode = new TextBox();
            BtnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            RBtnFamale = new RadioButton();
            RBtnMale = new RadioButton();
            SuspendLayout();
            // 
            // TxtName
            // 
            TxtName.Location = new Point(12, 44);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(148, 23);
            TxtName.TabIndex = 0;
            // 
            // TxtFamily
            // 
            TxtFamily.Location = new Point(12, 73);
            TxtFamily.Name = "TxtFamily";
            TxtFamily.Size = new Size(148, 23);
            TxtFamily.TabIndex = 1;
            // 
            // TxtNationalCode
            // 
            TxtNationalCode.Location = new Point(12, 102);
            TxtNationalCode.Name = "TxtNationalCode";
            TxtNationalCode.Size = new Size(148, 23);
            TxtNationalCode.TabIndex = 2;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(85, 187);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 3;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 47);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 81);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "family:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 110);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 5;
            label3.Text = "national code :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 143);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 5;
            label4.Text = "gender :";
            // 
            // RBtnFamale
            // 
            RBtnFamale.AutoSize = true;
            RBtnFamale.Checked = true;
            RBtnFamale.Location = new Point(85, 143);
            RBtnFamale.Name = "RBtnFamale";
            RBtnFamale.Size = new Size(63, 19);
            RBtnFamale.TabIndex = 6;
            RBtnFamale.TabStop = true;
            RBtnFamale.Text = "Famale";
            RBtnFamale.UseVisualStyleBackColor = true;
            // 
            // RBtnMale
            // 
            RBtnMale.AutoSize = true;
            RBtnMale.Location = new Point(28, 143);
            RBtnMale.Name = "RBtnMale";
            RBtnMale.Size = new Size(51, 19);
            RBtnMale.TabIndex = 6;
            RBtnMale.Text = "Male";
            RBtnMale.UseVisualStyleBackColor = true;
            // 
            // FrmAddPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 281);
            Controls.Add(RBtnMale);
            Controls.Add(RBtnFamale);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSave);
            Controls.Add(TxtNationalCode);
            Controls.Add(TxtFamily);
            Controls.Add(TxtName);
            Name = "FrmAddPerson";
            RightToLeft = RightToLeft.Yes;
            Text = "FrmAddPerson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtName;
        private TextBox TxtFamily;
        private TextBox TxtNationalCode;
        private Button BtnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton RBtnFamale;
        private RadioButton RBtnMale;
    }
}