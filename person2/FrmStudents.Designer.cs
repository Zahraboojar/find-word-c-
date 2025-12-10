namespace person2
{
    partial class FrmStudents
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
            BtnDelete = new Button();
            BtnEdit = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            BtnAdd = new Button();
            dataGridView1 = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            ColFamily = new DataGridViewTextBoxColumn();
            ColNationalCode = new DataGridViewTextBoxColumn();
            ColStudentCode = new DataGridViewTextBoxColumn();
            ColGrade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(118, 51);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(61, 59);
            BtnDelete.TabIndex = 1;
            BtnDelete.Text = "-";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Location = new Point(185, 51);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(61, 59);
            BtnEdit.TabIndex = 2;
            BtnEdit.Text = "✒️";
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnAdd_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(460, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(670, 73);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "جستجو :";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(51, 51);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(61, 59);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColId, ColName, ColFamily, ColNationalCode, ColStudentCode, ColGrade });
            dataGridView1.Location = new Point(70, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(619, 150);
            dataGridView1.TabIndex = 6;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "Id";
            ColId.HeaderText = "شماره";
            ColId.Name = "ColId";
            // 
            // ColName
            // 
            ColName.DataPropertyName = "Name";
            ColName.HeaderText = "نام";
            ColName.Name = "ColName";
            // 
            // ColFamily
            // 
            ColFamily.DataPropertyName = "Family";
            ColFamily.HeaderText = "نام خانوادگی";
            ColFamily.Name = "ColFamily";
            // 
            // ColNationalCode
            // 
            ColNationalCode.DataPropertyName = "National_Code";
            ColNationalCode.HeaderText = "کد ملی";
            ColNationalCode.Name = "ColNationalCode";
            // 
            // ColStudentCode
            // 
            ColStudentCode.DataPropertyName = "StudentCode";
            ColStudentCode.HeaderText = "کد دانش آموزی";
            ColStudentCode.Name = "ColStudentCode";
            // 
            // ColGrade
            // 
            ColGrade.DataPropertyName = "Grade";
            ColGrade.HeaderText = "مقطع تحصیلی";
            ColGrade.Name = "ColGrade";
            // 
            // FrmStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Controls.Add(BtnDelete);
            Name = "FrmStudents";
            Text = "FrmStudents";
            Load += FrmStudents_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button BtnDelete;
        private Button BtnEdit;
        private TextBox textBox1;
        private Label label1;
        private Button BtnAdd;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColFamily;
        private DataGridViewTextBoxColumn ColNationalCode;
        private DataGridViewTextBoxColumn ColStudentCode;
        private DataGridViewTextBoxColumn ColGrade;
    }
}