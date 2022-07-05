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
    public partial class frmHome : Form
    {
        public string email { get; set; }
        public int? role { get; set; }
        public frmHome()
        {
            InitializeComponent();
        }

        private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            frmEmployee frmemployee = new frmEmployee
            {
                email = email,
                role = role
            };

            frmemployee.MdiParent = this;
            frmemployee.Dock = DockStyle.Fill;
            frmemployee.Show();
        }

        private void rewardAndPenaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void posToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void certificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void regulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }
    }
}
