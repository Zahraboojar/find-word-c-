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
    public partial class FrmStudent : Form
    {
        StudentManagerList studentManager = new StudentManagerList();
        Student student;
        int index;
        Action action;
        public FrmStudent(Action fillDvg)
        {
            InitializeComponent();
            action = fillDvg;
        }

        public FrmStudent(Student student, int index)
        {
            InitializeComponent();
            this.student = student;
            this.index = index;
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            CobGrade.Items.AddRange(Student.GetAllFaGrade());
            if (student != null)
            {
                TxtName.Text = student.Name;
                TxtFamily.Text = student.Family;
                TxtNationalCode.Text = student.National_code;
                TxtStCode.Text = student.StudentCode;
                CobGrade.SelectedIndex = (int)student.Grade;
                BtnSave2.Visible = false;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            if (IsValidContrles(newStudent))
            {
                newStudent.Name = TxtName.Text;
                newStudent.Family = TxtFamily.Text;
                newStudent.National_code = TxtNationalCode.Text;
                newStudent.StudentCode = TxtStCode.Text;
                newStudent.Grade = (Grade)CobGrade.SelectedIndex;
                if (newStudent.Id == 0)
                    newStudent.Id = studentManager.LastIndex() + 1;

                if (this.student == null)
                {
                    studentManager.Add(newStudent);
                    AlertHelper.Information("دانش آموز با موفقیت اضافه شد");
                }
                else
                {
                    studentManager.Edit(newStudent, index);
                    AlertHelper.Information("دانش آموز با موفقیت ویرایش شد");
                }
            }
            Button btn = sender as Button;
            if (btn.Name == "BtnSave")
            {
                this.Close();
                return;
            }
            TxtName.Text = "";
            TxtFamily.Text = "";
            TxtNationalCode.Text = "";
            TxtStCode.Text = "";
            CobGrade.SelectedIndex = -1;
            action();

        }

        private bool IsValidContrles(Student newStudent)
        {
            if (newStudent.ValidateTextBox(TxtNationalCode).IsSuccess)
            {
                if (this.student == null || this.student.National_code != TxtNationalCode.Text)
                    if (studentManager.IsDuplicateNationalCode(TxtNationalCode.Text))
                    {
                        AlertHelper.Error("کد ملی تکراری است");
                        return false;
                    }
            }
            if (newStudent.ValidateTextBox(TxtStCode).IsSuccess)
            {
                if (this.student == null || this.student.StudentCode != TxtStCode.Text)
                    if (studentManager.IsDuplicateStudentCode(TxtStCode.Text))
                    {
                        AlertHelper.Error("کد دانش آموزی تکراری است");
                        return false;
                    }

            }
            if (CobGrade.SelectedIndex == -1)
            {
                AlertHelper.Error("مقطع تحصیلی را انتخاب کنید");
                return false;
            }
            return true;
        }

        private void TxtStCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
    }
}
