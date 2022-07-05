using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class frmEmployee : Form
    {
        public string email { get; set; }
        public int? role { get; set; }
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            btnDelete.Enabled = false;

            txtid.Enabled = false;
            txtname.Enabled = false;
            txtaddress.Enabled = false;
            txtgender.Enabled = false;
            txtphone.Enabled = false;
            dtpdob.Enabled = false;
            dtpjoindate.Enabled = false;
            txtemail.Enabled = false;
            txtpassword.Enabled = false;
            txtrole.Enabled = false;
            txtsalary.Enabled = false;
            txtiddep.Enabled = false;
            txtidpos.Enabled = false;

            cbotype.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e) => Close();
    }
}
