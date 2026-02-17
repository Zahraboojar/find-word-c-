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
    public partial class FrmDataSource : Form
    {
        public FrmDataSource()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "sql")
                ManageDataSource.SelectedDataSource = DataSources.sql;
            else if (comboBox1.SelectedItem == "list")
                ManageDataSource.SelectedDataSource = DataSources.list;
            else
                ManageDataSource.SelectedDataSource = DataSources.access;
            var frmMain = new FrmMain();
            frmMain.Show();
        }
    }
}
