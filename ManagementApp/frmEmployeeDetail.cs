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
