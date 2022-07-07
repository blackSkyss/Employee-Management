using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        ICertificateRepository cerRep = new CertificateRepository();
        IEmployeeRepository empRep = new EmployeeRepository();

        BindingSource source;
        public frmCertificate()
        {
            InitializeComponent();
        }


        //Load form certificate----------------------------------------------------------------------
        private void frmCertificate_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;

            txtid.Enabled = false;
            txtname.Enabled = false;
            txtidtype.Enabled = false;
            txtidemp.Enabled = false;
            dtpdoi.Enabled = false;

            cboType.SelectedIndex = 0;
            btnDelete.Enabled = false;

            LoadListCertificate();

            dgvcer.CellDoubleClick += Dgvcer_CellDoubleClick;

        }

        //Load all certificate----------------------------------------------------------------------
        public void LoadListCertificate()
        {
            if (role == 1)
            {
                var listCer = cerRep.GetAllCertificate();
                try
                {
                    source = new BindingSource();
                    Binding(listCer);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load list certificate!!!");
                }
            }
            else
            {
                var listCer = cerRep.GetCertificateByIDEmp(empRep.GetEmployeeByEmailOne(email).IdEmp);
                try
                {
                    source = new BindingSource();
                    Binding(listCer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load list certificate!!!");
                }
            }
        }

        //Get list type certificate-----------------------------------------------------------------
        public void LoadTypeCer()
        {
            try
            {
                var listType = cerRep.GetAllTypeCerti();
                cbofilter.DataSource = listType;
                cbofilter.ValueMember = "IdTypeCer";
                cbofilter.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of type certificate!!!");
            }
        }

        //Binding source to text box-----------------------------------------------------------------
        public void Binding(List<Certificate> List)
        {
            source.Clear();
            source.DataSource = List;
            txtid.DataBindings.Clear();
            txtname.DataBindings.Clear();
            dtpdoi.DataBindings.Clear();
            txtidemp.DataBindings.Clear();
            txtidtype.DataBindings.Clear();

            txtid.DataBindings.Add("Text", source, "CerId");
            txtname.DataBindings.Add("Text", source, "CerName");
            dtpdoi.DataBindings.Add("Text", source, "Doi");
            txtidemp.DataBindings.Add("Text", source, "IdEmp");
            txtidtype.DataBindings.Add("Text", source, "IdTypeCer");

            dgvcer.DataSource = null;
            dgvcer.DataSource = source;


            if (List.Count == 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {

                btnDelete.Enabled = true;
            }
        }

        //Close button-------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e) => Close();


        //Create button------------------------------------------------------------------------------
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (role == 1)
            {
                frmCertificateDetail frmcertificateDetail = new frmCertificateDetail
                {
                    Text = "Create certificate",
                    empRep = empRep,
                    cerRep = cerRep,
                    InsertOrUpdate = false
                };


                if (frmcertificateDetail.ShowDialog() == DialogResult.OK)
                {
                    LoadListCertificate();
                    source.Position = source.Count - 1;
                }

            }
            else
            {
                frmCertificateDetail frmcertificateDetail = new frmCertificateDetail
                {
                    Text = "Create certificate",
                    empRep = empRep,
                    cerRep = cerRep,
                    InsertOrUpdate = false,
                    email = email,
                    role = role
                };

                if (frmcertificateDetail.ShowDialog() == DialogResult.OK)
                {
                    LoadListCertificate();
                    source.Position = source.Count - 1;
                }
            }

        }

        //Cell double click to update certificate-----------------------------------------------------
        public void Dgvcer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (role == 1)
            {
                frmCertificateDetail frmcertificateDetail = new frmCertificateDetail
                {
                    Text = "Update certificate",
                    empRep = empRep,
                    cerRep = cerRep,
                    cerInfo = GetObjectCertificate(),
                    InsertOrUpdate = true
                };

                if (frmcertificateDetail.ShowDialog() == DialogResult.OK)
                {
                    LoadListCertificate();
                    source.Position = source.Count - 1;
                }
            }
            else
            {
                frmCertificateDetail frmcertificateDetail = new frmCertificateDetail
                {
                    Text = "Update certificate",
                    empRep = empRep,
                    cerRep = cerRep,
                    cerInfo = GetObjectCertificate(),
                    InsertOrUpdate = true,
                    email = email,
                    role = role
                };

                if (frmcertificateDetail.ShowDialog() == DialogResult.OK)
                {
                    LoadListCertificate();
                    source.Position = source.Count - 1;
                }
            }

        }

        //Get object certificate---------------------------------------------------------------------
        private Certificate GetObjectCertificate()
        {
            Certificate cer = null;
            try
            {
                cer = new Certificate
                {
                    CerId = int.Parse(txtid.Text),
                    CerName = txtname.Text,
                    Doi = DateTime.ParseExact(dtpdoi.Text, "MM-dd-yyyy", CultureInfo.InvariantCulture),
                    IdEmp = int.Parse(txtidemp.Text),
                    IdTypeCer = int.Parse(txtidtype.Text)
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get certificate!!!");
            }

            return cer;
        }


        //Delete button---------------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var cer = GetObjectCertificate();
                var confirmation = MessageBox.Show("Are you sure to delete this certificate?", "Confirm Delete!!!", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    cerRep.DeleteCertificate(cer);
                    MessageBox.Show("Delete successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListCertificate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a certificate!!!");

            }
        }


        //Click combo box to show list of type certificate -----------------------------------------------------
        private void cbofilter_Click(object sender, EventArgs e)
        {
            LoadTypeCer();
        }


        //Select value in combo box to filter--------------------------------------------------------------------
        private void cbofilter_SelectedValueChanged(object sender, EventArgs e)
        {
            string value;
            try
            {
                value = cbofilter.SelectedValue.ToString();
                if (!String.IsNullOrEmpty(value))
                {
                    List<Certificate> listCer = cerRep.FilterCertificateByIDType(value);
                    Binding(listCer);
                }
                else
                {
                    MessageBox.Show("Not found!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string value = txtsearch.Text;
            string type = cboType.SelectedItem.ToString();
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var listCer = new List<Certificate>();
                    if (type.Equals("ID"))
                    {
                        listCer = cerRep.SearchCertificateByID(value);
                    }
                    else
                    {
                        listCer = cerRep.GetCertificateByName(value);
                    }

                    Binding(listCer);
                }
                else
                {
                    LoadListCertificate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found");
            }
        }
    }
}
