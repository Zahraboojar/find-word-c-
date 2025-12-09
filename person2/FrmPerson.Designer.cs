namespace person2
{
    partial class FrmPerson
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
            name = new DataGridViewTextBoxColumn();
            family = new DataGridViewTextBoxColumn();
            national_code = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(615, 27);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(75, 23);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(452, 27);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 1;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(286, 27);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 23);
            BtnUpdate.TabIndex = 2;
            BtnUpdate.Text = "Edit";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, family, national_code });
            dataGridView1.Location = new Point(261, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(447, 271);
            dataGridView1.TabIndex = 3;
            // 
            // name
            // 
            name.DataPropertyName = "Name";
            name.HeaderText = "name";
            name.Name = "name";
            // 
            // family
            // 
            family.DataPropertyName = "Family";
            family.HeaderText = "family";
            family.Name = "family";
            // 
            // national_code
            // 
            national_code.DataPropertyName = "National_code";
            national_code.HeaderText = "national_code";
            national_code.Name = "national_code";
            // 
            // FrmPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(BtnAdd);
            Name = "FrmPerson";
            Text = "Form1";
            Load += FrmPerson_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAdd;
        private Button BtnDelete;
        private Button BtnUpdate;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn family;
        private DataGridViewTextBoxColumn national_code;
    }
}
