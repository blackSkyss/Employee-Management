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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class frmRegulationDetail : Form
    {
        public IRegulationRepository regRepo { get; set; }
        public bool InsertOrUpdate { get; set; }

        public Regulation regInfo { get; set; }
        public frmRegulationDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIDReg.Text.ToString() == ""
             || txtName.Text == "" || txtStatus.Text == "")
            {
                MessageBox.Show("All field are required!", "Regulation Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Regulation reg = new Regulation
                    {
                        IdReg = int.Parse(txtIDReg.Text),
                        Name = txtName.Text,
                        Status = int.Parse(txtStatus.Text),
                    };

                    if (reg != null)
                    {
                        ValidationContext context = new ValidationContext(reg, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(reg, context, errors, true))
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
                                if (regRepo.GetRegulationByID(int.Parse(txtIDReg.Text)) != null)
                                {
                                    MessageBox.Show("ID already exist", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    this.DialogResult = DialogResult.OK;
                                    regRepo.InsertRegulation(reg);
                                    MessageBox.Show("Create successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                this.DialogResult = DialogResult.OK;
                                regRepo.UpdateRegulation(reg);
                                MessageBox.Show("Update successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new position" : "Update position");
                }
            }
        }

        private void frmRegulationDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txtIDReg.Text = regInfo.IdReg.ToString();
                txtName.Text = regInfo.Name.ToString();
                txtStatus.Text = regInfo.Status.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

    }
}
