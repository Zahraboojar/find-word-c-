using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace person2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnStudents_Click(object sender, EventArgs e)
        {
            FrmStudents frmStudents = new FrmStudents();
            frmStudents.ShowDialog();
        }

        private void BtnTeachers_Click(object sender, EventArgs e)
        {
            FrmTeachers frmTeachers = new FrmTeachers();
            frmTeachers.ShowDialog();
        }
    }
}
