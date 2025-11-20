using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace person2
{
    public partial class FrmEditPerson : Form
    {
        Person person;
        int index;
        public FrmEditPerson(Person person, int index)
        {
            InitializeComponent();
            this.person = person;
            this.index = index;
        }

        private void FrmEditPerson_Load(object sender, EventArgs e)
        {
            TxtName.Text = person.Name;
            TxtFamily.Text = person.Family;
            TxtNationalCode.Text = person.National_code;
            if (person.Gender == "famale")
                RBtnFamale.Checked = true;
            else
                RBtnMale.Checked = true;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Person person = new Person();

            if (person.ValidateTextBox(TxtName).IsSuccess)
                person.Name = TxtName.Text;
            else
            {
                MessageBox.Show(person.ValidateTextBox(TxtName).message);
                return;
            }

            if (person.ValidateTextBox(TxtFamily).IsSuccess)
                    person.Family = TxtFamily.Text;
            else
            {
                MessageBox.Show(person.ValidateTextBox(TxtFamily).message);
                return;
            }

            if (person.ValidateTextBox(TxtNationalCode).IsSuccess)
                if (!TxtNationalCode.Text.ValidateNationalCode())
                {
                    MessageBox.Show("Invalid national code");
                    return;
                }
                else
                    person.National_code = TxtNationalCode.Text;
            else
            {
                MessageBox.Show(person.ValidateTextBox(TxtNationalCode).message);
                return;
            }
            string gender = "famale";
            if (RBtnMale.Checked) gender = "male";
            else gender = "famale";
                person.Gender = gender;
            var frmEdit = Application.OpenForms["FrmPerson"] as FrmPerson;

            frmEdit.ListPerson[index] = person;
            this.Close();
        }
    }
}
