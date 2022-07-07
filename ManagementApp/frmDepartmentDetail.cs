using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class frmDepartmentDetail : Form
    {

        public IDepartmentRepository depRep { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Department depInfo { get; set; }

        public frmDepartmentDetail()
        {
            InitializeComponent();
        }


        //Load form department detail to insert or update------------------------------------------------ 
        private void frmDepartmentDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txtid.Text = depInfo.DepNum.ToString();
                txtname.Text = depInfo.DepName.ToString();
                txtdes.Text = depInfo.Description.ToString();
                txtloc.Text = depInfo.Location.ToString();

                txtid.Enabled = false;
            }
        }

        //Check contain only number---------------------------------------------------------------------
        private bool checkOnlyNumber(string value)
        {
            string strRegex = "^[0-9]*$";
            Regex re = new Regex(strRegex);

            return re.IsMatch(value);
        }

        //Cancel button-----------------------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e) => Close();


        //Save button-------------------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtid.Text.ToString() == ""
              || txtname.Text == ""
              || txtdes.Text == ""
              || txtloc.Text == "")
            {
                MessageBox.Show("All field are required!", "Certificate Management",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkOnlyNumber(txtid.Text) == false)
            {
                MessageBox.Show("ID contain only number", "Employee Management",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Department dep = new Department
                    {
                        DepNum = int.Parse(txtid.Text),
                        DepName = txtname.Text,
                        Description = txtdes.Text,
                        Location = txtloc.Text
                    };

                    if (dep != null)
                    {
                        ValidationContext context = new ValidationContext(dep, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(dep, context, errors, true))
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
                                if (depRep.GetDepartmentByID(int.Parse(txtid.Text)) != null)
                                {
                                    MessageBox.Show("ID already exist", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    this.DialogResult = DialogResult.OK;
                                    depRep.InsertDepartment(dep);
                                    MessageBox.Show("Create successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                this.DialogResult = DialogResult.OK;
                                depRep.UpdateDepartment(dep);
                                MessageBox.Show("Update successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new department" : "Update department");
                }
            }
        }
    }
}
