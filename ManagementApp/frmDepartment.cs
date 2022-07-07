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
    public partial class frmDepartment : Form
    {
        IDepartmentRepository depRep = new DepartmentRepository();

        BindingSource source;

        public frmDepartment()
        {
            InitializeComponent();
        }


        //Load form department----------------------------------------------------------------------
        private void frmDepartment_Load(object sender, EventArgs e)
        {

            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;

            txtid.Enabled = false;
            txtname.Enabled = false;
            txtdes.Enabled = false;
            txtloc.Enabled = false;

            cbotype.SelectedIndex = 0;
            btnDelete.Enabled = false;

            LoadListDepartment();

            dgvdep.CellDoubleClick += Dgvdep_CellDoubleClick;
        }


        //Close button--------------------------------------------------------------------------------
        private void btnClose_Click(object sender, EventArgs e) => Close();

        //Load list department------------------------------------------------------------------------
        public void LoadListDepartment()
        {

            var listDep = depRep.GetAllDepartment();
            try
            {
                source = new BindingSource();
                Binding(listDep);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list department!!!");
            }

        }

        //Get object department-----------------------------------------------------------------------
        private Department GetObjectDepartment()
        {
            Department dep = null;
            try
            {
                dep = new Department
                {
                    DepNum = int.Parse(txtid.Text),
                    DepName = txtname.Text,
                    Description = txtdes.Text,
                    Location = txtloc.Text
                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get department!!!");
            }

            return dep;
        }

        //Binding data to text box--------------------------------------------------------------------
        public void Binding(List<Department> List)
        {
            source.Clear();
            source.DataSource = List;
            txtid.DataBindings.Clear();
            txtname.DataBindings.Clear();
            txtdes.DataBindings.Clear();
            txtloc.DataBindings.Clear();

            txtid.DataBindings.Add("Text", source, "DepNum");
            txtname.DataBindings.Add("Text", source, "DepName");
            txtdes.DataBindings.Add("Text", source, "Description");
            txtloc.DataBindings.Add("Text", source, "Location");

            dgvdep.DataSource = null;
            dgvdep.DataSource = source;


            if (List.Count == 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }

        //Double click to update department----------------------------------------------------------
        public void Dgvdep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDepartmentDetail frmdepartmentDetail = new frmDepartmentDetail
            {
                Text = "Update department",
                depRep = depRep,
                InsertOrUpdate = true,
                depInfo = GetObjectDepartment()
            };

            if (frmdepartmentDetail.ShowDialog() == DialogResult.OK)
            {
                LoadListDepartment();
                source.Position = source.Count - 1;
            }
        }

        //Create button------------------------------------------------------------------------------
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmDepartmentDetail frmdepartmentDetail = new frmDepartmentDetail
            {
                Text = "Create department",
                depRep = depRep,
                InsertOrUpdate = false
            };

            if (frmdepartmentDetail.ShowDialog() == DialogResult.OK)
            {
                LoadListDepartment();
                source.Position = source.Count - 1;
            }

        }


        //Button delete--------------------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var dep = GetObjectDepartment();
                var confirmation = MessageBox.Show("Are you sure to delete this department?", "Confirm Delete!!!", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    depRep.DeleteDepartment(dep);
                    MessageBox.Show("Delete successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListDepartment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a department!!!");

            }
        }


        //Change text to search----------------------------------------------------------------------
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string value = txtsearch.Text;
            string type = cbotype.SelectedItem.ToString();
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var listDep = new List<Department>();
                    if (type.Equals("ID"))
                    {
                        listDep = depRep.SearchDepartmentByID(value);
                    }
                    else
                    {
                        listDep = depRep.GetDepartmentByName(value);
                    }

                    Binding(listDep);
                }
                else
                {
                    LoadListDepartment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found");
            }
        }
    }
}

