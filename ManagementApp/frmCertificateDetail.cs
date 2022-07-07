using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        //Load list employee---------------------------------------------------------------------------
        public void LoadEmployee()
        {
            try
            {
                var listEmp = empRep.GetEmployees();
                cboemployee.DataSource = listEmp;
                cboemployee.ValueMember = "IdEmp";
                cboemployee.DisplayMember = "Email";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of employee!!!");
            }
        }

        //Load list type of certificate----------------------------------------------------------------
        public void LoadType()
        {
            try
            {
                var listType = cerRep.GetAllTypeCerti();
                cbotype.DataSource = listType;
                cbotype.ValueMember = "IdTypeCer";
                cbotype.DisplayMember = "Name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of type!!!");
            }
        }

        //Load form certificate detail-----------------------------------------------------------------
        private void frmCertificateDetail_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            LoadType();

            if (InsertOrUpdate == false)
            {
                cboemployee.SelectedIndex = 0;
                cbotype.SelectedIndex = 0;
            }
            else
            {
                txtid.Text = cerInfo.CerId.ToString();
                txtname.Text = cerInfo.CerName.ToString();
                dtpdoi.Text = cerInfo.Doi?.ToString("MM-dd-yyyy");
                cboemployee.SelectedValue = cerInfo.IdEmp;
                cbotype.SelectedValue = cerInfo.IdTypeCer;

                txtid.Enabled = false;
            }
        }


        //Cancel button---------------------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e) => Close();


        //Check contain only number---------------------------------------------------------------------
        private bool checkOnlyNumber(string value)
        {
            string strRegex = "^[0-9]*$";
            Regex re = new Regex(strRegex);

            return re.IsMatch(value);
        }

        //Check beteween two day------------------------------------------------------------------------
        public static bool isBetweenTwoDates(string checkdate)
        {
            DateTime dayStart = DateTime.ParseExact("01-01-1990", "MM-dd-yyyy", CultureInfo.InvariantCulture);
            DateTime dayEnd = DateTime.ParseExact(DateTime.Now.ToString("MM-dd-yyyy"), "MM-dd-yyyy", CultureInfo.InvariantCulture);
            DateTime checkDay = DateTime.Parse(checkdate);
            if (checkDay.Date >= dayStart.Date && checkDay.Date <= dayEnd.Date)
            {
                return true;
            }

            return false;
        }

        //Save button-----------------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtid.Text.ToString() == ""
              || txtname.Text == "")
            {
                MessageBox.Show("All field are required!", "Certificate Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkOnlyNumber(txtid.Text) == false)
            {
                MessageBox.Show("ID contain only number", "Employee Management",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (isBetweenTwoDates(dtpdoi.Text) == false)
            {
                MessageBox.Show("Day of birth must be from 01-01-1990 to today", "Employee Management",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Certificate cer = new Certificate
                    {
                        CerId = int.Parse(txtid.Text),
                        CerName = txtname.Text,
                        Doi = DateTime.ParseExact(dtpdoi.Text, "MM-dd-yyyy", CultureInfo.InvariantCulture),
                        IdEmp = int.Parse(cboemployee.SelectedValue.ToString()),
                        IdTypeCer = int.Parse(cbotype.SelectedValue.ToString()),
                    };

                    if (cer != null)
                    {
                        ValidationContext context = new ValidationContext(cer, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(cer, context, errors, true))
                        {
                            foreach (ValidationResult result in errors)
                            {
                                MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;

                            }
                        }
                        else
                        {
                            if (InsertOrUpdate == false)
                            {
                                if (cerRep.GetCertificateByID(int.Parse(txtid.Text)) != null)
                                {
                                    MessageBox.Show("ID already exist", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    this.DialogResult = DialogResult.OK;
                                    cerRep.InsertCertificate(cer);
                                    MessageBox.Show("Create successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                this.DialogResult = DialogResult.OK;
                                cerRep.UpdateCertificate(cer);
                                MessageBox.Show("Update successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new certificate" : "Update certificate");
                }
            }
        }
    }
}
