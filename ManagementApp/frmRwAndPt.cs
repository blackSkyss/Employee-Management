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
    public partial class frmRwAndPt : Form
    {
        IRegulationRepository regRepo = new RegulationRepository();
        IEmployeeRepository empRepo = new EmployeeRepository();
        IRewardAndPenaltyRepository RPRepo = new RewardAndPenaltyRepository();
        BindingSource source;
        public frmRwAndPt()
        {
            InitializeComponent();
        }
        public void Binding(List<RewardAndPenalty> List)
        {
            source.Clear();
            source.DataSource = List;
            txtIDRP.DataBindings.Clear();
            txtReason.DataBindings.Clear();
            dtpAppDate.DataBindings.Clear();
            txtTimes.DataBindings.Clear();
            txtIDRegulation.DataBindings.Clear();
            txtEmployee.DataBindings.Clear();
            txtIDRP.DataBindings.Add("Text", source, "idRP");
            txtReason.DataBindings.Add("Text", source, "reason");
            dtpAppDate.DataBindings.Add("Text", source, "applicableDate");
            txtTimes.DataBindings.Add("Text", source, "times");
            txtIDRegulation.DataBindings.Add("Text", source, "idReg");
            txtEmployee.DataBindings.Add("Text", source, "idEmp");
            dgvRP.DataSource = null;
            dgvRP.DataSource = source;
            dgvRP.Columns[6].Visible = false;
            dgvRP.Columns[7].Visible = false;
            if (List.Count == 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmRwAndPt_Load(object sender, EventArgs e)
        {
            txtIDRP.Enabled = false;
            txtReason.Enabled = false;
            dtpAppDate.Enabled = false;
            txtTimes.Enabled = false;
            txtEmployee.Enabled = false;
            txtIDRegulation.Enabled = false;
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            loadRP();
        }

        public void loadRP()
        {
            var listRP = RPRepo.GetRewardAndPenalty();
            try
            {
                source = new BindingSource();
                Binding(listRP);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list RP!!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var RP = GetObjectRP();
                var confirmation = MessageBox.Show("Are you sure to delete this RP?", "Confirm Delete!!!", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    RPRepo.DeleteRewardAndPenalty(RP);
                    MessageBox.Show("Delete successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadRP();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a RP!!!");

            }
        }

        private RewardAndPenalty GetObjectRP()
        {
            RewardAndPenalty RP = null;
            try
            {
                RP = new RewardAndPenalty
                {
                    IdRp = int.Parse(txtIDRP.Text),
                    Reason = txtReason.Text,
                    ApplicableDate = DateTime.ParseExact(dtpAppDate.Text, "MM-dd-yyyy", CultureInfo.InvariantCulture),
                    Times = int.Parse(txtTimes.Text),
                    IdReg = int.Parse(txtIDRegulation.Text),
                    IdEmp = int.Parse(txtEmployee.Text),

                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get RP!!!");
            }

            return RP;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmRwAndPtDetail frmRwAndPtDetail = new frmRwAndPtDetail
            {
                Text = "Create RP",
                empRepo = empRepo,
                regRepo = regRepo,
                RPrepo = RPRepo,
                InsertOrUpdate = false
            };

            if (frmRwAndPtDetail.ShowDialog() == DialogResult.OK)
            {
                loadRP();
                source.Position = source.Count - 1;
            }
        }

        private void dgvRP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRwAndPtDetail frmRwAndPtDetail = new frmRwAndPtDetail
            {
                Text = "Create RP",
                empRepo = empRepo,
                regRepo = regRepo,
                RPrepo = RPRepo,
                RPInfo = GetObjectRP(),
                InsertOrUpdate = true
            };

            if (frmRwAndPtDetail.ShowDialog() == DialogResult.OK)
            {
                loadRP();
                source.Position = source.Count - 1;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string value = txtSearch.Text;
            string type = cboType.SelectedItem.ToString();
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var listRP = new List<RewardAndPenalty>();
                    if (type.Equals("ID"))
                    {
                        listRP = RPRepo.SearchRewardAndPenaltyById(value);
                    }

                    Binding(listRP);
                }
                else
                {
                    loadRP();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found");
            }
        }
    }
}
