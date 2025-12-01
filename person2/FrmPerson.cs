namespace person2
{
    public partial class FrmPerson : Form
    {
        public List<Person> ListPerson = new List<Person>();
        public FrmPerson()
        {
            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            if (person.IsSelected(dataGridView1).IsSuccess)
            {
                Person row = (Person)dataGridView1.CurrentRow.DataBoundItem;
                ListPerson.Remove(row);
                Fill_Dvg();
            }
            else
                MessageBox.Show(person.IsSelected(dataGridView1).Message);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAddPerson FrmNewPerson = new FrmAddPerson();
            FrmNewPerson.Text = "add new person";
            FrmNewPerson.ShowDialog();
            Fill_Dvg();
        }
        private void Fill_Dvg()
        {
            dataGridView1.DataSource = ListPerson.ToList();
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {
            Fill_Dvg();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            if (person.IsSelected(dataGridView1).IsSuccess)
            {
                Person row = (Person)dataGridView1.CurrentRow.DataBoundItem;
                int index = dataGridView1.CurrentRow.Index;
                FrmEditPerson FrmEditPerson = new FrmEditPerson(row, index);
                FrmEditPerson.Text = "add new person";
                FrmEditPerson.ShowDialog();
                Fill_Dvg();
            }
            else
                MessageBox.Show(person.IsSelected(dataGridView1).Message);
        }
    }
}
