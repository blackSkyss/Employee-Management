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


    public partial class frmEmployeeDetail : Form
    {

        public IEmployeeRepository empRep { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Employee empInfo { get; set; }

        public IDepartmentRepository depReg { get; set; }
        public IPositionRepository posReg { get; set; }

        public frmEmployeeDetail()
        {
            InitializeComponent();
        }

        //Check contain only number------------------------------------------------------------
        private bool checkOnlyNumber(string value)
        {
            string strRegex = "^[0-9]*$";
            Regex re = new Regex(strRegex);

            return re.IsMatch(value);
        }


        //Check between two day----------------------------------------------------------------
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

        //Save button--------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == ""
               || txtname.Text == ""
               || txtaddress.Text == ""
               || txtphone.Text == ""
               || txtsalary.Text == ""
               || txtemail.Text == ""
               || txtpassword.Text == "")
            {
                MessageBox.Show("All field are required!", "Employee Management",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkOnlyNumber(txtid.Text) == false)
            {
                MessageBox.Show("ID contain only number", "Employee Management",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (isBetweenTwoDates(dtpdob.Text) == false)
            {
                MessageBox.Show("Day of birth must be from 01-01-1990 to today", "Employee Management",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (isBetweenTwoDates(dtpjoindate.Text) == false)
            {
                MessageBox.Show("Join date must be from 01-01-1990 to today", "Employee Management",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkOnlyNumber(txtsalary.Text) == false)
            {
                MessageBox.Show("Salary contain only number", "Employee Management",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Employee emp = new Employee
                    {
                        IdEmp = int.Parse(txtid.Text),
                        Name = txtname.Text,
                        Address = txtaddress.Text,
                        Gender = cbogender.Text,
                        PhoneNum = txtphone.Text,
                        Dob = DateTime.ParseExact(dtpdob.Text, "MM-dd-yyyy", CultureInfo.InvariantCulture),
                        JoinDate = DateTime.ParseExact(dtpjoindate.Text, "MM-dd-yyyy", CultureInfo.InvariantCulture),
                        BaseSalary = int.Parse(txtsalary.Text),
                        Email = txtemail.Text,
                        Password = txtpassword.Text,
                        IdPos = int.Parse(cboposition.SelectedValue.ToString()),
                        DepNum = int.Parse(cbodepartment.SelectedValue.ToString()),
                        Role = 0
                    };

                    if (emp != null)
                    {
                        ValidationContext context = new ValidationContext(emp, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(emp, context, errors, true))
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
                                if (empRep.GetEmployeeByID(int.Parse(txtid.Text)) != null)
                                {
                                    MessageBox.Show("ID already exist", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (empRep.CheckEmailExist(txtemail.Text) != null)
                                {
                                    MessageBox.Show("Email already exist", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    this.DialogResult = DialogResult.OK;
                                    empRep.InsertEmployee(emp);
                                    MessageBox.Show("Create successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                this.DialogResult = DialogResult.OK;
                                empRep.UpdateEmployee(emp);
                                MessageBox.Show("Update successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new employee" : "Update employee");
                }
            }
        }


        //Cancel button-------------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e) => Close();


        //Load form-----------------------------------------------------------------------------
        private void frmEmployeeDetail_Load(object sender, EventArgs e)
        {
            LoadDepartment();
            LoadPosition();
            if (InsertOrUpdate == false)
            {

                cbogender.SelectedIndex = 0;

            }
            else
            {
                txtid.Text = empInfo.IdEmp.ToString();
                txtname.Text = empInfo.Name;
                txtaddress.Text = empInfo.Address;
                cbogender.SelectedIndex = cbogender.Items.IndexOf(empInfo.Gender);
                txtphone.Text = empInfo.PhoneNum;
                dtpdob.Text = empInfo.Dob?.ToString("MM-dd-yyyy");
                dtpjoindate.Text = empInfo.JoinDate?.ToString("MM-dd-yyyy");
                txtemail.Text = empInfo.Email;
                txtpassword.Text = empInfo.Password;
                txtsalary.Text = empInfo.BaseSalary.ToString();
                cbodepartment.SelectedValue = empInfo.DepNum;
                cboposition.SelectedValue = empInfo.IdPos;

                txtid.Enabled = false;
                txtemail.Enabled = false;
            }


        }

        //Load department list-------------------------------------------------------------------
        public void LoadDepartment()
        {
            try
            {
                var depList = depReg.GetAllDepartment();
                cbodepartment.DataSource = depList;
                cbodepartment.ValueMember = "DepNum";
                cbodepartment.DisplayMember = "DepName";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of department!!!");
            }
        }

        //Load position list---------------------------------------------------------------------
        public void LoadPosition()
        {
            try
            {
                var posList = posReg.GetPositions();
                cboposition.DataSource = posList;
                cboposition.ValueMember = "IdPos";
                cboposition.DisplayMember = "PosName";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of position!!!");
            }
        }
    }
}
