using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace find_word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string[] GetWord() 
        {
            var text = txtword.Text;
            var words = text.Split(' ');
            return words;
        }

        bool CheckTextBox()
        {
            if (txtword.Text == "")
            {
                MessageBox.Show("مقدار فیلد کلمات نباید خالی باشد", "خطا");
                return false;
            }
            if (txtchar.Text == "")
            {
                MessageBox.Show("مقدار فیلد کاراکتر نباید خالی باشد", "خطا");
                return false;
            }
            if (txtchar.Text.Length > 1)
            {
                MessageBox.Show("مقدار فیلد کاراکتر نباید بیش از ی کاراکتر باشد", "خطا");
                return false;
            }
            return true;
        }

        private void BtnCountWord_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                string[] words = GetWord();
                char character = txtchar.Text.Trim()[0];
                int count = 0;
                for (int i = 0; i < words.Count(); i++)
                {
                    if (words[i].IndexOf(character) != -1)
                        count++;
                }
                LblResult.Text = "تعداد کلمات : " + count;
            }
        }

        private void BtnCountChar_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                string[] words = GetWord();
                char character = txtchar.Text.Trim()[0];
                int count = 0;
                for (int i = 0; i < words.Count(); i++)
                {
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (words[i][j] == character)
                        count++;
                    }
                    
                }
                LblResult.Text = "تعداد حروف : " + count;
            }
        }

        private void BtcWordList_Click(object sender, EventArgs e)
        {
            if (CheckTextBox())
            {
                string[] words = GetWord();
                string words2 = "";
                char character = txtchar.Text.Trim()[0];
                for (int i = 0; i < words.Count(); i++)
                {
                    if (words[i].IndexOf(character) != -1)
                        words2 += words[i] + " - ";
                }
                LblResult.Text = "لیست کلمات : \n" + words2;
            }
        }
    }
}
