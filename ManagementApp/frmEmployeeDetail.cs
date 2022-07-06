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


    public partial class frmEmployeeDetail : Form
    {

        public IEmployeeRepository empRep { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Employee empInfo { get; set; }

        private IDepartmentRepository depReg = new DepartmentRepository();

        private IPositionRepository posReg = new PositionRepository();

        public frmEmployeeDetail()
        {
            InitializeComponent();
        }

        //Save button--------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {

        }


        //Cancel button-------------------------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e) => Close();


        //Load form-----------------------------------------------------------------------------
        private void frmEmployeeDetail_Load(object sender, EventArgs e)
        {

            if (InsertOrUpdate == false)
            {
                LoadDepartment();
                LoadPosition();
                cbogender.SelectedIndex = 0;

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
