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
    public partial class frmRegulation : Form
    {
        IRegulationRepository regRepo = new RegulationRepository();
        BindingSource source;
        public frmRegulation()
        {
            InitializeComponent();
        }

        private void frmRegulation_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            loadReg();
        }

        public void loadReg()
        {
            var listReg = regRepo.GetRegulation();
            try
            {
                source = new BindingSource();
                Binding(listReg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list certificate!!!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void dgvRegulation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRegulationDetail frmRegulationDetail = new frmRegulationDetail
            {
                Text = "Create Regulation",
                regRepo = regRepo,
                regInfo = GetObjectRegulation(),
                InsertOrUpdate = true
            };

            if (frmRegulationDetail.ShowDialog() == DialogResult.OK)
            {
                loadReg();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var reg = GetObjectRegulation();
                var confirmation = MessageBox.Show("Are you sure to delete this Regulation?", "Confirm Delete!!!", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    regRepo.DeleteRegulation(reg);
                    MessageBox.Show("Delete successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadReg();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a regulation!!!");

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmRegulationDetail frmRegulationDetail = new frmRegulationDetail
            {
                Text = "Create Regulation",
                regRepo = regRepo,
                InsertOrUpdate = false
            };

            if (frmRegulationDetail.ShowDialog() == DialogResult.OK)
            {
                loadReg();
                source.Position = source.Count - 1;
            }
        }

        public void Binding(List<Regulation> List)
        {
            source.Clear();
            source.DataSource = List;
            txtIDReg.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtStatus.DataBindings.Clear();

            txtIDReg.DataBindings.Add("Text", source, "idReg");
            txtName.DataBindings.Add("Text", source, "name");
            txtStatus.DataBindings.Add("Text", source, "status");
            dgvRegulation.DataSource = null;
            dgvRegulation.DataSource = source;
            dgvRegulation.Columns[3].Visible = false;

            if (List.Count == 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private Regulation GetObjectRegulation()
        {
            Regulation reg = null;
            try
            {
                reg = new Regulation
                {
                    IdReg = int.Parse(txtIDReg.Text),
                    Name = txtName.Text,
                    Status = int.Parse(txtStatus.Text),
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Position!!!");
            }
            return reg;
        }
    }
}
