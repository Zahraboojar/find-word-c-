namespace find_word
{
    partial class Form1
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
            this.txtword = new System.Windows.Forms.TextBox();
            this.txtchar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCountWord = new System.Windows.Forms.Button();
            this.BtnCountChar = new System.Windows.Forms.Button();
            this.BtcWordList = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtword
            // 
            this.txtword.Location = new System.Drawing.Point(226, 60);
            this.txtword.Multiline = true;
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(301, 39);
            this.txtword.TabIndex = 0;
            // 
            // txtchar
            // 
            this.txtchar.Location = new System.Drawing.Point(406, 137);
            this.txtchar.Multiline = true;
            this.txtchar.Name = "txtchar";
            this.txtchar.Size = new System.Drawing.Size(121, 29);
            this.txtchar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "کلمات :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "کاراکتر :";
            // 
            // BtnCountWord
            // 
            this.BtnCountWord.Location = new System.Drawing.Point(496, 193);
            this.BtnCountWord.Name = "BtnCountWord";
            this.BtnCountWord.Size = new System.Drawing.Size(80, 56);
            this.BtnCountWord.TabIndex = 4;
            this.BtnCountWord.Text = "تعداد کلمه";
            this.BtnCountWord.UseVisualStyleBackColor = true;
            this.BtnCountWord.Click += new System.EventHandler(this.BtnCountWord_Click);
            // 
            // BtnCountChar
            // 
            this.BtnCountChar.Location = new System.Drawing.Point(377, 193);
            this.BtnCountChar.Name = "BtnCountChar";
            this.BtnCountChar.Size = new System.Drawing.Size(90, 56);
            this.BtnCountChar.TabIndex = 5;
            this.BtnCountChar.Text = "تعداد حرف";
            this.BtnCountChar.UseVisualStyleBackColor = true;
            this.BtnCountChar.Click += new System.EventHandler(this.BtnCountChar_Click);
            // 
            // BtcWordList
            // 
            this.BtcWordList.Location = new System.Drawing.Point(247, 193);
            this.BtcWordList.Name = "BtcWordList";
            this.BtcWordList.Size = new System.Drawing.Size(103, 56);
            this.BtcWordList.TabIndex = 6;
            this.BtcWordList.Text = "لیست کلمات";
            this.BtcWordList.UseVisualStyleBackColor = true;
            this.BtcWordList.Click += new System.EventHandler(this.BtcWordList_Click);
            // 
            // LblResult
            // 
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(12, 61);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(199, 188);
            this.LblResult.TabIndex = 7;
            this.LblResult.Text = "                    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "نتیجه :";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(654, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtcWordList);
            this.Controls.Add(this.BtnCountChar);
            this.Controls.Add(this.BtnCountWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtchar);
            this.Controls.Add(this.txtword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.TextBox txtchar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCountWord;
        private System.Windows.Forms.Button BtnCountChar;
        private System.Windows.Forms.Button BtcWordList;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label label4;
    }
}

