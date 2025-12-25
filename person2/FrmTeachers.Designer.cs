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
            dataGridView1.Location = new Point(35, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(717, 271);
            dataGridView1.TabIndex = 3;
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
    }
}
