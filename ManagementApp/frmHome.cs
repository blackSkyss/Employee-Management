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

            frmRwAndPt frmrwAndPt = new frmRwAndPt();

            frmrwAndPt.MdiParent = this;
            frmrwAndPt.Dock = DockStyle.Fill;
            frmrwAndPt.Show();

        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frmDepartment frmdepartment = new frmDepartment();

            frmdepartment.MdiParent = this;
            frmdepartment.Dock = DockStyle.Fill;
            frmdepartment.Show();

        }

        private void posToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frmPosition frmposition = new frmPosition();

            frmposition.MdiParent = this;
            frmposition.Dock = DockStyle.Fill;
            frmposition.Show();

        }

        private void certificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frmCertificate frmcertificate = new frmCertificate
            {
                email = email,
                role = role
            };

            frmcertificate.MdiParent = this;
            frmcertificate.Dock = DockStyle.Fill;
            frmcertificate.Show();

        }

        private void regulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frmRegulation frmregulation = new frmRegulation();

            frmregulation.MdiParent = this;
            frmregulation.Dock = DockStyle.Fill;
            frmregulation.Show();

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
