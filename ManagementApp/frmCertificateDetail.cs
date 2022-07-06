using BusinessObject;
using DataAccess.Repository;
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
    public partial class frmCertificateDetail : Form
    {
        public IEmployeeRepository empRep { get; set; }
        
        public ICertificateRepository cerRep { get; set; }

        public bool InsertOrUpdate { get; set; }

        public Certificate cerInfo { get; set; }

        public frmCertificateDetail()
        {
            InitializeComponent();
        }

        private void frmCertificateDetail_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
