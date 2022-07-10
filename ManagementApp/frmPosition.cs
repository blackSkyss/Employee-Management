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
    public partial class frmPosition : Form
    {
        IPositionRepository posRepo = new PositionRepository();
        BindingSource source;
        public frmPosition()
        {
            InitializeComponent();
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
            txtIdPosition.Enabled = false;
            txtPosDescription.Enabled = false;
            txtPosName.Enabled = false;
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            loadPosition();
        }
        public void loadPosition()
        {
            var listPos = posRepo.GetPositions();
            try
            {
                source = new BindingSource();
                Binding(listPos);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list certificate!!!");
            }
        }
        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        public void Binding(List<Position> List)
        {
            source.Clear();
            source.DataSource = List;
            txtIdPosition.DataBindings.Clear();
            txtPosName.DataBindings.Clear();
            txtPosDescription.DataBindings.Clear();

            txtIdPosition.DataBindings.Add("Text", source, "idPos");
            txtPosName.DataBindings.Add("Text", source, "posName");
            txtPosDescription.DataBindings.Add("Text", source, "description");
            dgvPosition.DataSource = null;
            dgvPosition.DataSource = source;
            dgvPosition.Columns[3].Visible = false;

            if (List.Count == 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {


        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            frmPositionDetail frmPositionDetail = new frmPositionDetail
            {
                Text = "Create Position",
                posRepo = posRepo,
                InsertOrUpdate = false
            };

            if (frmPositionDetail.ShowDialog() == DialogResult.OK)
            {
                loadPosition();
                source.Position = source.Count - 1;
            }
        }


        private void dgvPosition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPositionDetail frmPositionDetail = new frmPositionDetail
            {
                Text = "Update position",
                posRepo = posRepo,
                posInfo = GetObjectPos(),
                InsertOrUpdate = true
            };

            if (frmPositionDetail.ShowDialog() == DialogResult.OK)
            {
                loadPosition();
                source.Position = source.Count - 1;
            }
        }


        private Position GetObjectPos()
        {
            Position pos = null;
            try
            {
                pos = new Position
                {
                    IdPos = int.Parse(txtIdPosition.Text),
                    PosName = txtPosName.Text,
                    Description = txtPosDescription.Text,
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Position!!!");
            }

            return pos;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var pos = GetObjectPos();
                var confirmation = MessageBox.Show("Are you sure to delete this position?", "Confirm Delete!!!", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    posRepo.DeletePosition(pos);
                    MessageBox.Show("Delete successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadPosition();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a position!!!");

            }
        }

        

        private void txtSearchh_TextChanged(object sender, EventArgs e)
        {
            string value = txtSearchh.Text;
            string type = cboTypee.SelectedItem.ToString();
            try
            {

                if (!string.IsNullOrEmpty(value))
                {
                    var listPos = new List<Position>();
                    if (type.Equals("ID"))
                    {
                        listPos = posRepo.SearchPositionByID(value);
                    }
                    else
                    {
                        listPos = posRepo.GetPositionByName(value);
                    }
                    if (type.Equals(""))
                    {
                        MessageBox.Show("YOU NEED SELECT TYPE");
                    }

                    Binding(listPos);
                }
                else
                {
                    loadPosition();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found");
            }
        }
    }
}
