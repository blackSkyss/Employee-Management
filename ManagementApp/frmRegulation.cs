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
    public partial class frmRegulation : Form
    {
        public frmRegulation()
        {
            InitializeComponent();
        }

        private void frmRegulation_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
