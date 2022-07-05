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
    }
}
