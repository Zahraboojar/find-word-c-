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
    }
}
