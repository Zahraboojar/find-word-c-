namespace person2
{
    partial class FrmTeacher
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
            TxtPhoneNumber = new TextBox();
            TxtAddress = new TextBox();
            label5 = new Label();
            label6 = new Label();
            TxtField = new TextBox();
            label7 = new Label();
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
            TxtNationalCode.KeyPress += TxtNationalCode_KeyPress;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(85, 303);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 8;
            BtnSave.Text = "ذخیره";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 47);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 5;
            label1.Text = "نام :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 81);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "نام خانوادگی :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 110);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "کد ملی :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 246);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 5;
            label4.Text = "gender :";
            // 
            // RBtnFamale
            // 
            RBtnFamale.AutoSize = true;
            RBtnFamale.Checked = true;
            RBtnFamale.Location = new Point(85, 246);
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
            RBtnMale.Location = new Point(28, 246);
            RBtnMale.Name = "RBtnMale";
            RBtnMale.Size = new Size(51, 19);
            RBtnMale.TabIndex = 7;
            RBtnMale.Text = "Male";
            RBtnMale.UseVisualStyleBackColor = true;
            // 
            // TxtPhoneNumber
            // 
            TxtPhoneNumber.Location = new Point(12, 130);
            TxtPhoneNumber.Name = "TxtPhoneNumber";
            TxtPhoneNumber.Size = new Size(148, 23);
            TxtPhoneNumber.TabIndex = 3;
            TxtPhoneNumber.KeyPress += TxtNationalCode_KeyPress;
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(12, 159);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(148, 23);
            TxtAddress.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 138);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 5;
            label5.Text = "شماره موبایل :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(166, 167);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 5;
            label6.Text = "آدرس :";
            // 
            // TxtField
            // 
            TxtField.Location = new Point(12, 190);
            TxtField.Name = "TxtField";
            TxtField.Size = new Size(148, 23);
            TxtField.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(166, 198);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 5;
            label7.Text = "رشته :";
            // 
            // FrmTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 338);
            Controls.Add(RBtnMale);
            Controls.Add(RBtnFamale);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtField);
            Controls.Add(label1);
            Controls.Add(TxtAddress);
            Controls.Add(BtnSave);
            Controls.Add(TxtPhoneNumber);
            Controls.Add(TxtNationalCode);
            Controls.Add(TxtFamily);
            Controls.Add(TxtName);
            Name = "FrmTeacher";
            RightToLeft = RightToLeft.Yes;
            Text = "FrmAEditPerson";
            Load += FrmAddPerson_Load;
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
        private TextBox TxtPhoneNumber;
        private TextBox TxtAddress;
        private Label label5;
        private Label label6;
        private TextBox TxtField;
        private Label label7;
    }
}