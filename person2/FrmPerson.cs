namespace person2
{
    public partial class FrmPerson : Form
    {
        PersonManager personManager = new PersonManager();
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
                DialogResult rersult = AlertHelper.Question($"Are you sure to delete {row.Name}");
                if (rersult == DialogResult.Yes)
                    personManager.RemovePerson(row);
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
            dataGridView1.DataSource = personManager.GetPersons().ToList();
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
                FrmAddPerson FrmEditPerson = new FrmAddPerson(row, index);
                FrmEditPerson.Text = "Edit person";
                FrmEditPerson.ShowDialog();
                Fill_Dvg();
            }
            else
                MessageBox.Show(person.IsSelected(dataGridView1).Message);
        }
    }
}
