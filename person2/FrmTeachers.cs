namespace person2
{
    public partial class FrmTeachers : Form
    {
        TeacherManager teacherManager = new TeacherManager();
        public FrmTeachers()
        {
            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            if (teacher.IsSelected(dataGridView1).IsSuccess)
            {
                Teacher row = (Teacher)dataGridView1.CurrentRow.DataBoundItem;
                DialogResult rersult = AlertHelper.Question($"آیا میخواهید استاد {row.Name} را حذف کنید ؟ ");
                if (rersult == DialogResult.Yes)
                {
                    teacherManager.Remove(row);
                    AlertHelper.Information($"استاد {row.Name} با موفقیت حذف شد");
                }
                Fill_Dvg();
            }
            else
                MessageBox.Show(teacher.IsSelected(dataGridView1).Message);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmTeacher FrmNewTeacher = new FrmTeacher();
            FrmNewTeacher.Text = "افزودن استاد جدید";
            FrmNewTeacher.ShowDialog();
            Fill_Dvg();
        }
        private void Fill_Dvg()
        {
            dataGridView1.DataSource = teacherManager.GetAll().ToList();
        }

        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            Fill_Dvg();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            if (teacher.IsSelected(dataGridView1).IsSuccess)
            {
                Teacher row = (Teacher)dataGridView1.CurrentRow.DataBoundItem;
                int index = dataGridView1.CurrentRow.Index;
                FrmTeacher FrmEditTeacher = new FrmTeacher(row, index);
                FrmEditTeacher.Text = $"ویرایش استاد {row.Name}";
                FrmEditTeacher.ShowDialog();
                Fill_Dvg();
            }
            else
                MessageBox.Show(teacher.IsSelected(dataGridView1).Message);
        }
    }
}
