namespace person2
{
    partial class FrmEditPerson
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
            RBtnMale = new RadioButton();
            RBtnFamale = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BtnSave = new Button();
            TxtNationalCode = new TextBox();
            TxtFamily = new TextBox();
            TxtName = new TextBox();
            SuspendLayout();
            // 
            // RBtnMale
            // 
            RBtnMale.AutoSize = true;
            RBtnMale.Location = new Point(28, 124);
            RBtnMale.Name = "RBtnMale";
            RBtnMale.Size = new Size(51, 19);
            RBtnMale.TabIndex = 15;
            RBtnMale.Text = "Male";
            RBtnMale.UseVisualStyleBackColor = true;
            // 
            // RBtnFamale
            // 
            RBtnFamale.AutoSize = true;
            RBtnFamale.Checked = true;
            RBtnFamale.Location = new Point(85, 124);
            RBtnFamale.Name = "RBtnFamale";
            RBtnFamale.Size = new Size(63, 19);
            RBtnFamale.TabIndex = 16;
            RBtnFamale.TabStop = true;
            RBtnFamale.Text = "Famale";
            RBtnFamale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 124);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 11;
            label4.Text = "gender :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 91);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 12;
            label3.Text = "national code :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 62);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 13;
            label2.Text = "family:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 28);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 14;
            label1.Text = "name:";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(85, 168);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 10;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // TxtNationalCode
            // 
            TxtNationalCode.Location = new Point(12, 83);
            TxtNationalCode.Name = "TxtNationalCode";
            TxtNationalCode.Size = new Size(148, 23);
            TxtNationalCode.TabIndex = 9;
            // 
            // TxtFamily
            // 
            TxtFamily.Location = new Point(12, 54);
            TxtFamily.Name = "TxtFamily";
            TxtFamily.Size = new Size(148, 23);
            TxtFamily.TabIndex = 8;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(12, 25);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(148, 23);
            TxtName.TabIndex = 7;
            // 
            // FrmEditPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 221);
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
            Name = "FrmEditPerson";
            RightToLeft = RightToLeft.Yes;
            Text = "FrmEditPerson";
            Load += FrmEditPerson_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RBtnMale;
        private RadioButton RBtnFamale;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnSave;
        private TextBox TxtNationalCode;
        private TextBox TxtFamily;
        private TextBox TxtName;
    }
}