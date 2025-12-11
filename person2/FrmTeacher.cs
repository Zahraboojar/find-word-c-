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
    public partial class FrmTeacher : Form
    {
        TeacherManager teacherManager = new TeacherManager();
        Teacher teacher;
        int index;

        public FrmTeacher()
        {
            InitializeComponent();
            teacher = null;
            index = 0;
        }

        public FrmTeacher(Teacher teacher, int index)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.index = index;
            TxtFamily.Text = teacher.Family;
            TxtName.Text = teacher.Name;
            TxtNationalCode.Text = teacher.National_code;
            TxtPhoneNumber.Text = teacher.PhoneNumber;
            TxtAddress.Text = teacher.Address;
            TxtField.Text = teacher.Field;
            if (teacher.Gender == Gender.Famale)
                RBtnFamale.Checked = true;
            else RBtnMale.Checked = true;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            if (teacher.ValidateTextBox(TxtName).IsSuccess)
                teacher.Name = TxtName.Text;
            else
            {
                AlertHelper.Error(teacher.ValidateTextBox(TxtName).Message);
                return;
            }

            if (teacher.ValidateTextBox(TxtFamily).IsSuccess)
                teacher.Family = TxtFamily.Text;
            else
            {
                AlertHelper.Error(teacher.ValidateTextBox(TxtFamily).Message);
                return;
            }

            if (teacher.ValidateTextBox(TxtNationalCode).IsSuccess)
                    if (!TxtNationalCode.Text.IsValidateNationalCode())
                {
                    AlertHelper.Error("کد ملی نامعتبر است");
                    return;
                }
                else
                    teacher.National_code = TxtNationalCode.Text;
            else
            {
                AlertHelper.Error(teacher.ValidateTextBox(TxtNationalCode).Message);
                return;
            }

            if (teacher.ValidateTextBox(TxtPhoneNumber).IsSuccess)
                if (TxtPhoneNumber.TextLength == 11)
                    teacher.PhoneNumber = TxtPhoneNumber.Text;
                else
                {
                    AlertHelper.Error("شماره موبایل باید 11 عدد باشد");
                    return;
                }
            else
            {
                AlertHelper.Error(teacher.ValidateTextBox(TxtPhoneNumber).Message);
                return;
            }

            if (teacher.ValidateTextBox(TxtAddress).IsSuccess)
                teacher.Address = TxtAddress.Text;
            else
            {
                AlertHelper.Error(teacher.ValidateTextBox(TxtAddress).Message);
                return;
            }

            if (teacher.ValidateTextBox(TxtField).IsSuccess)
                teacher.Field = TxtField.Text;
            else
            {
                AlertHelper.Error(teacher.ValidateTextBox(TxtField).Message);
                return;
            }

            if (RBtnMale.Checked) teacher.Gender = Gender.Male;
            else teacher.Gender = Gender.Famale;

            teacher.Id = teacherManager.LastIndex()+1;

            if (this.teacher == null)
            {
                if (teacherManager.Equals(teacher))
                {
                    AlertHelper.Error("شماره موبایل و کدملی با استاد دیگری مطابقت دارد .", "خطای تکراری بودن ");
                    return;
                }
                    teacherManager.Add(teacher);
                AlertHelper.Information("استاد با موفقیت اضافه شد");

            }
            else
            {
                if (teacherManager.Equals(teacher))
                    if (this.teacher.National_code != TxtNationalCode.Text
                    && this.teacher.PhoneNumber != TxtPhoneNumber.Text)
                    {
                        AlertHelper.Error("شماره موبایل و کدملی با استاد دیگری مطابقت دارد .", "خطای تکراری بودن ");
                        return;
                    }
                teacherManager.Edit(teacher, index);
                AlertHelper.Information("استاد با موفقیت ویرایش شد");
            }
            this.Close();

        }

        private void FrmAddPerson_Load(object sender, EventArgs e)
        {

        }

        private void TxtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}
