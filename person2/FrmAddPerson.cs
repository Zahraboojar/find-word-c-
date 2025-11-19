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
    public partial class FrmAddPerson : Form
    {
        public FrmAddPerson()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.National_code = TxtNationalCode.Text;
            person.Name = TxtName.Text;
            person.Family = TxtFamily.Text;
            string gender = "famale";
            if (RBtnMale.Checked) gender = "male";
            person.Gender = gender;
            var frmFirst = Application.OpenForms["FrmPerson"] as FrmPerson;

            frmFirst.ListPerson.Add(person);

        }
    }
}
