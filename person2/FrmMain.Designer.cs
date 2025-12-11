namespace person2
{
    partial class FrmMain
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
            BtnStudents = new Button();
            BtnTeachers = new Button();
            SuspendLayout();
            // 
            // BtnStudents
            // 
            BtnStudents.Location = new Point(221, 115);
            BtnStudents.Name = "BtnStudents";
            BtnStudents.Size = new Size(134, 100);
            BtnStudents.TabIndex = 0;
            BtnStudents.Text = "دانش آموزان";
            BtnStudents.UseVisualStyleBackColor = true;
            BtnStudents.Click += this.BtnStudents_Click;
            // 
            // BtnTeachers
            // 
            BtnTeachers.Location = new Point(59, 115);
            BtnTeachers.Name = "BtnTeachers";
            BtnTeachers.Size = new Size(134, 100);
            BtnTeachers.TabIndex = 1;
            BtnTeachers.Text = "اساتید";
            BtnTeachers.UseVisualStyleBackColor = true;
            BtnTeachers.Click += this.BtnTeachers_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 288);
            Controls.Add(BtnTeachers);
            Controls.Add(BtnStudents);
            Name = "FrmMain";
            Text = "FrmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnStudents;
        private Button BtnTeachers;
    }
}