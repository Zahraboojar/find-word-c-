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
        PersonManager personManager = new PersonManager();
        Person person ;
        int index;

        public FrmAddPerson()
        {
            InitializeComponent();
            person = null;
            index = 0;
        }

        public FrmAddPerson(Person persone, int index)
        {
            InitializeComponent(); 
            this.person = persone;
            this.index = index;
            TxtFamily.Text = persone.Family;
            TxtName.Text = persone.Name;
            TxtNationalCode.Text = person.National_code;
            if (persone.Gender == Gender.Famale)
                RBtnFamale.Checked = true;
            else RBtnMale.Checked = true;
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            if (person.ValidateTextBox(TxtName).IsSuccess)
                person.Name = TxtName.Text;
            else
            {
                MessageBox.Show(person.ValidateTextBox(TxtName).Message);
                return;
            }

            if (person.ValidateTextBox(TxtFamily).IsSuccess)
                person.Family = TxtFamily.Text;
            else
            {
                MessageBox.Show(person.ValidateTextBox(TxtFamily).Message);
                return;
            }

            if (person.ValidateTextBox(TxtNationalCode).IsSuccess)
                if (!TxtNationalCode.Text.IsValidateNationalCode())
                {
                    MessageBox.Show("Invalid national code");
                    return;
                }
                else
                    person.National_code = TxtNationalCode.Text;
            else
            {
                MessageBox.Show(person.ValidateTextBox(TxtNationalCode).Message);
                return;
            }
            if (RBtnMale.Checked) person.Gender = Gender.Male;
            else person.Gender = Gender.Famale;

            if (this.person == null)
            {
                personManager.Add(person);
                AlertHelper.Information("add new person successfully");

            } else
            {
                personManager.Edit(person, index);
                AlertHelper.Information("edit person successfully");
            }
            this.Close();

        }

        private void FrmAddPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
