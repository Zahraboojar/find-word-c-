namespace person2
{
    partial class FrmTeachers
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
            BtnAdd = new Button();
            BtnDelete = new Button();
            BtnUpdate = new Button();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            family = new DataGridViewTextBoxColumn();
            national_code = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Field = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(80, 12);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 71);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(242, 12);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 71);
            BtnDelete.TabIndex = 2;
            BtnDelete.Text = "-";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(161, 12);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 71);
            BtnUpdate.TabIndex = 1;
            BtnUpdate.Text = "✒️";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, name, family, national_code, PhoneNumber, Address, Field });
            dataGridView1.Location = new Point(35, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(717, 271);
            dataGridView1.TabIndex = 3;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "کد";
            Id.Name = "Id";
            // 
            // name
            // 
            name.DataPropertyName = "Name";
            name.HeaderText = "نام";
            name.Name = "name";
            // 
            // family
            // 
            family.DataPropertyName = "Family";
            family.HeaderText = "نام خانوادگی";
            family.Name = "family";
            // 
            // national_code
            // 
            national_code.DataPropertyName = "National_code";
            national_code.HeaderText = "کد ملی";
            national_code.Name = "national_code";
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "شماره موبایل";
            PhoneNumber.Name = "PhoneNumber";
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "آدرس";
            Address.Name = "Address";
            // 
            // Field
            // 
            Field.DataPropertyName = "Field";
            Field.HeaderText = "رشته";
            Field.Name = "Field";
            // 
            // FrmTeachers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 450);
            Controls.Add(dataGridView1);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(BtnAdd);
            Name = "FrmTeachers";
            Text = "Form1";
            Load += FrmTeacher_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAdd;
        private Button BtnDelete;
        private Button BtnUpdate;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn family;
        private DataGridViewTextBoxColumn national_code;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Field;
    }
}
