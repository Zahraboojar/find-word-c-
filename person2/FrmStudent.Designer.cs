namespace person2
{
    partial class FrmStudent
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtNationalCode = new TextBox();
            TxtFamily = new TextBox();
            TxtName = new TextBox();
            TxtStCode = new TextBox();
            label4 = new Label();
            label5 = new Label();
            CobGrade = new ComboBox();
            BtnSave = new Button();
            BtnSave2 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(235, 111);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 9;
            label3.Text = "national code :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 82);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "family:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 48);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 11;
            label1.Text = "name:";
            // 
            // TxtNationalCode
            // 
            TxtNationalCode.Location = new Point(81, 103);
            TxtNationalCode.Name = "TxtNationalCode";
            TxtNationalCode.Size = new Size(148, 23);
            TxtNationalCode.TabIndex = 2;
            TxtNationalCode.KeyPress += TxtStCode_KeyPress;
            // 
            // TxtFamily
            // 
            TxtFamily.Location = new Point(81, 74);
            TxtFamily.Name = "TxtFamily";
            TxtFamily.Size = new Size(148, 23);
            TxtFamily.TabIndex = 1;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(81, 45);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(148, 23);
            TxtName.TabIndex = 0;
            // 
            // TxtStCode
            // 
            TxtStCode.Location = new Point(81, 132);
            TxtStCode.Name = "TxtStCode";
            TxtStCode.Size = new Size(148, 23);
            TxtStCode.TabIndex = 3;
            TxtStCode.KeyPress += TxtStCode_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 140);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 9;
            label4.Text = "student code:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 169);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 9;
            label5.Text = "grade :";
            // 
            // CobGrade
            // 
            CobGrade.FormattingEnabled = true;
            CobGrade.Location = new Point(108, 169);
            CobGrade.Name = "CobGrade";
            CobGrade.Size = new Size(121, 23);
            CobGrade.TabIndex = 4;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(184, 225);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 23);
            BtnSave.TabIndex = 5;
            BtnSave.Text = "ثبت و بازگشت";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnSave2
            // 
            BtnSave2.Location = new Point(81, 225);
            BtnSave2.Name = "BtnSave2";
            BtnSave2.Size = new Size(75, 23);
            BtnSave2.TabIndex = 5;
            BtnSave2.Text = "ثبت و جدید";
            BtnSave2.UseVisualStyleBackColor = true;
            BtnSave2.Click += BtnSave_Click;
            // 
            // FrmStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 300);
            Controls.Add(BtnSave2);
            Controls.Add(BtnSave);
            Controls.Add(CobGrade);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtStCode);
            Controls.Add(TxtNationalCode);
            Controls.Add(TxtFamily);
            Controls.Add(TxtName);
            Name = "FrmStudent";
            RightToLeft = RightToLeft.Yes;
            Text = "FrmStudent";
            Load += FrmStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TxtNationalCode;
        private TextBox TxtFamily;
        private TextBox TxtName;
        private TextBox TxtStCode;
        private Label label4;
        private Label label5;
        private ComboBox CobGrade;
        private Button BtnSave;
        private Button BtnSave2;
    }
}