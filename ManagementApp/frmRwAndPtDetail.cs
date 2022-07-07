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
    public partial class frmRwAndPtDetail : Form
    {
        public IEmployeeRepository empRepo { get; set; }
        public bool InsertOrUpdate { get; set; }
        public RewardAndPenalty RPInfo { get; set; }

        public IRegulationRepository regRepo { get; set; }
        public IRewardAndPenaltyRepository RPrepo { get; set; }
        public frmRwAndPtDetail()
        {
            InitializeComponent();
        }

        private bool checkOnlyNumber(string value)
        {
            string strRegex = "^[0-9]*$";
            Regex re = new Regex(strRegex);

            return re.IsMatch(value);
        }

        private void frmRwAndPtDetail_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            LoadRegulation();
            if (InsertOrUpdate == true)
            {
                txtIDRP.Text = RPInfo.IdRp.ToString();
                txtReason.Text = RPInfo.Reason;
                dtpAppDate.Text = RPInfo.ApplicableDate?.ToString("MM-dd-yyyy");
                txtTimes.Text = RPInfo.Times.ToString();
                cboRegulation.SelectedValue = RPInfo.IdReg;
                cboEmployee.SelectedValue = RPInfo.IdEmp;
                txtIDRP.Enabled = false;
                cboEmployee.Enabled = false;
            }
        }

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

        public void LoadRegulation()
        {
            try
            {
                var regulationList = regRepo.GetRegulation();
                cboRegulation.DataSource = regulationList;
                cboRegulation.ValueMember = "idReg";
                cboRegulation.DisplayMember = "name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Regulation!!!");
            }
        }

        public void LoadEmployee()
        {
            try
            {
                var empList = empRepo.GetEmployees();
                cboEmployee.DataSource = empList;
                cboEmployee.ValueMember = "idEmp";
                cboEmployee.DisplayMember = "name";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of Employee!!!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtIDRP.Text.ToString() == ""
               || txtReason.Text == ""
               || txtTimes.Text == "")
            {
                MessageBox.Show("All field are required!", "Reward and penalty Management",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (checkOnlyNumber(txtIDRP.Text) == false)
            {
                MessageBox.Show("ID contain only number", "Reward and penalty Management",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (isBetweenTwoDates(dtpAppDate.Text) == false)
            {
                MessageBox.Show("Day of birth must be from 01-01-1990 to today", "Reward and penalty Management",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (checkOnlyNumber(txtTimes.Text) == false)
            {
                MessageBox.Show("Times contain only number", "Reward and penalty Management",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    RewardAndPenalty rp = new RewardAndPenalty
                    {
                        IdRp = int.Parse(txtIDRP.Text),
                        Reason = txtReason.Text,
                        ApplicableDate = DateTime.ParseExact(dtpAppDate.Text, "MM-dd-yyyy", CultureInfo.InvariantCulture),
                        Times = int.Parse(txtTimes.Text),
                        IdReg = int.Parse(cboRegulation.SelectedValue.ToString()),
                        IdEmp = int.Parse(cboEmployee.SelectedValue.ToString()),
                    };

                    if (rp != null)
                    {
                        ValidationContext context = new ValidationContext(rp, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(rp, context, errors, true))
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
                                if (RPrepo.GetRewardAndPenaltyByID(int.Parse(txtIDRP.Text)) != null)
                                {
                                    MessageBox.Show("ID already exist", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }                              
                                else
                                {
                                    this.DialogResult = DialogResult.OK;
                                    RPrepo.InsertRewardAndPenalty(rp);
                                    MessageBox.Show("Create successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                this.DialogResult = DialogResult.OK;
                                RPrepo.UpdateRewardAndPenalty(rp);
                                MessageBox.Show("Update successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new RP" : "Update RP");
                }
            }
        }
    }
}
