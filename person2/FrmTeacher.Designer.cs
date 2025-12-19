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
            BtnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            RBtnFamale = new RadioButton();
            RBtnMale = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtName = new CustomTextBox();
            TxtFamily = new CustomTextBox();
            TxtNationalCode = new CustomTextBox();
            TxtPhoneNumber = new CustomTextBox();
            TxtAddress = new CustomTextBox();
            TxtField = new CustomTextBox();
            SuspendLayout();
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(114, 292);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 9;
            BtnSave.Text = "ذخیره";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 36);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 5;
            label1.Text = "نام :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 70);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "نام خانوادگی :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 99);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "کد ملی :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 235);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 5;
            label4.Text = "gender :";
            // 
            // RBtnFamale
            // 
            RBtnFamale.AutoSize = true;
            RBtnFamale.Checked = true;
            RBtnFamale.Location = new Point(114, 235);
            RBtnFamale.Name = "RBtnFamale";
            RBtnFamale.Size = new Size(63, 19);
            RBtnFamale.TabIndex = 7;
            RBtnFamale.TabStop = true;
            RBtnFamale.Text = "Famale";
            RBtnFamale.UseVisualStyleBackColor = true;
            // 
            // RBtnMale
            // 
            RBtnMale.AutoSize = true;
            RBtnMale.Location = new Point(57, 235);
            RBtnMale.Name = "RBtnMale";
            RBtnMale.Size = new Size(51, 19);
            RBtnMale.TabIndex = 8;
            RBtnMale.Text = "Male";
            RBtnMale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(195, 127);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 5;
            label5.Text = "شماره موبایل :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 156);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 5;
            label6.Text = "آدرس :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(195, 187);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 5;
            label7.Text = "رشته :";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(57, 33);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(132, 23);
            TxtName.TabIndex = 1;
            // 
            // TxtFamily
            // 
            TxtFamily.Location = new Point(57, 62);
            TxtFamily.Name = "TxtFamily";
            TxtFamily.Size = new Size(132, 23);
            TxtFamily.TabIndex = 2;
            // 
            // TxtNationalCode
            // 
            TxtNationalCode.Location = new Point(57, 96);
            TxtNationalCode.Name = "TxtNationalCode";
            TxtNationalCode.Size = new Size(132, 23);
            TxtNationalCode.TabIndex = 3;
            TxtNationalCode.KeyPress += TxtNationalCode_KeyPress;
            // 
            // TxtPhoneNumber
            // 
            TxtPhoneNumber.Location = new Point(57, 124);
            TxtPhoneNumber.Name = "TxtPhoneNumber";
            TxtPhoneNumber.Size = new Size(132, 23);
            TxtPhoneNumber.TabIndex = 4;
            TxtPhoneNumber.KeyPress += this.TxtNationalCode_KeyPress;
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(57, 158);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.Size = new Size(132, 23);
            TxtAddress.TabIndex = 5;
            // 
            // TxtField
            // 
            TxtField.Location = new Point(57, 184);
            TxtField.Name = "TxtField";
            TxtField.Size = new Size(132, 23);
            TxtField.TabIndex = 6;
            // 
            // FrmTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 338);
            Controls.Add(TxtField);
            Controls.Add(TxtAddress);
            Controls.Add(TxtPhoneNumber);
            Controls.Add(TxtNationalCode);
            Controls.Add(TxtFamily);
            Controls.Add(TxtName);
            Controls.Add(RBtnMale);
            Controls.Add(RBtnFamale);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnSave);
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
        private Label label5;
        private Label label6;
        private Label label7;
        private CustomTextBox customTextBox1;
        private CustomTextBox customTextBox2;
        private CustomTextBox customTextBox3;
        private CustomTextBox TxtPhoneNumber;
        private CustomTextBox TxtAddress;
        private CustomTextBox TxtField;
    }
}