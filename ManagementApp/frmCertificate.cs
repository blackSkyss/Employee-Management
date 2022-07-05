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
    public partial class frmCertificate : Form
    {
        public string email { get; set; }
        public int? role { get; set; }
        public frmCertificate()
        {
            InitializeComponent();
        }

        private void frmCertificate_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e) => Close();
    }
}
