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
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;

            txtid.Enabled = false;
            txtname.Enabled = false;
            txtdes.Enabled = false;
            txtloc.Enabled = false;

            cbotype.SelectedIndex = 0;
            btnDelete.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
