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
    public partial class frmPositionDetail : Form
    {
        public IPositionRepository posRepo { get; set; }
        public bool InsertOrUpdate { get; set; }

        public Position posInfo { get; set; }
        public frmPositionDetail()
        {
            InitializeComponent();
        }

        private void frmPositionDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txtPosId.Text = posInfo.IdPos.ToString();
                txtPosName.Text = posInfo.PosName.ToString();
                txtDes.Text = posInfo.Description.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPosId.Text.ToString() == ""
              || txtPosName.Text == "" || txtDes.Text == "")
            {
                MessageBox.Show("All field are required!", "Certificate Management",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    Position pos = new Position
                    {
                        IdPos = int.Parse(txtPosId.Text),
                        PosName = txtPosName.Text,
                        Description = txtDes.Text,
                    };

                    if (pos != null)
                    {
                        ValidationContext context = new ValidationContext(pos, null, null);
                        IList<ValidationResult> errors = new List<ValidationResult>();
                        if (!Validator.TryValidateObject(pos, context, errors, true))
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
                                if (posRepo.GetPositionByID(int.Parse(txtPosId.Text)) != null)
                                {
                                    MessageBox.Show("ID already exist", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    this.DialogResult = DialogResult.OK;
                                    posRepo.InsertCertificate(pos);
                                    MessageBox.Show("Create successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                this.DialogResult = DialogResult.OK;
                                posRepo.UpdateCertificate(pos);
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


    }
}
