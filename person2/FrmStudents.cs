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
    public partial class FrmStudents : Form
    {
        StudentManagerList StudentManagerli = new StudentManagerList();
        StudentManagerAccess StudentManagerAcc = new StudentManagerAccess();
        StudentManagerSql StudentManagerSql = new StudentManagerSql();
        Student student = new Student();

        public event Action StudentChanged;
        public FrmStudents()
        {
            InitializeComponent();
            StudentChanged += Fill_Dvg;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            FrmStudent Frmstudent = new FrmStudent(StudentChanged);

            if (btn.Name == "BtnEdit")
            {
                if (student.IsSelected(dataGridView1).IsSuccess)
                {
                    Student row = (Student)dataGridView1.CurrentRow.DataBoundItem;
                    int index = dataGridView1.CurrentRow.Index;
                    Frmstudent = new FrmStudent(row, index);
                }
                else
                {
                    AlertHelper.Error(student.IsSelected(dataGridView1).Message);
                    return;
                }


            }

            Frmstudent.ShowDialog();

            Fill_Dvg();
        }
        private void Fill_Dvg()
        {
            if (ManageDataSource.SelectedDataSource == DataSources.list)
            {
                dataGridView1.DataSource = StudentManagerli.GetAll().ToList();
            }
            else if (ManageDataSource.SelectedDataSource == DataSources.sql)
            {
                dataGridView1.DataSource = StudentManagerSql.Select(txtSearch.Text).Data;
            }
            else
            {
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (student.IsSelected(dataGridView1).IsSuccess)
            {
                Student row = (Student)dataGridView1.CurrentRow.DataBoundItem;

                DialogResult result = AlertHelper.Question("آیا مایل یه حذف دانش آموز هستید ؟");
                if (result == DialogResult.Yes)
                {
                    StudentManagerli.Remove(row);
                    AlertHelper.Information("دانش آموز با موفقیت حذف شد");
                    Fill_Dvg();
                }
            }
            else
                AlertHelper.Error(student.IsSelected(dataGridView1).Message);
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            Fill_Dvg();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Fill_Dvg();
        }
    }
}
