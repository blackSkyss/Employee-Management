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
    public partial class frmEmployee : Form
    {
        IEmployeeRepository empRep = new EmployeeRepository();

        IDepartmentRepository depRep = new DepartmentRepository();

        IPositionRepository posRep = new PositionRepository();

        public string email { get; set; }
        public int? role { get; set; }

        BindingSource source;
        public frmEmployee()
        {
            InitializeComponent();
        }

        //Load button------------------------------------------------------------------------------
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;


            txtid.Enabled = false;
            txtname.Enabled = false;
            txtaddress.Enabled = false;
            txtgender.Enabled = false;
            txtphone.Enabled = false;
            dtpdob.Enabled = false;
            dtpjoindate.Enabled = false;
            txtemail.Enabled = false;
            txtpassword.Enabled = false;
            txtrole.Enabled = false;
            txtsalary.Enabled = false;
            txtiddep.Enabled = false;
            txtidpos.Enabled = false;

            cbotype.SelectedIndex = 0;

            LoadListEmployee();

            if (role == 0)
            {
                cbofilterdep.Enabled = false;
                cbofilterpos.Enabled = false;
                cbotype.Enabled = false;
                txtsearch.Enabled = false;

                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
            }




            dgvemp.CellDoubleClick += Dgvemp_CellDoubleClick;


        }

        //Close button--------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e) => Close();


        //Load all employee---------------------------------------------------------------------
        public void LoadListEmployee()
        {
            if (role == 1)
            {
                var listEmp = empRep.GetEmployees();
                try
                {
                    source = new BindingSource();
                    Binding(listEmp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load list employee!!!");
                }
            }
            else
            {
                var listEmp = empRep.GetEmployeeByEmail(email);
                try
                {
                    source = new BindingSource();
                    Binding(listEmp);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load list employee!!!");
                }
            }
        }


        //Load button---------------------------------------------------------------------------
        private void btnLoad_Click(object sender, EventArgs e)
        {   
        }


        //Create button--------------------------------------------------------------------------
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmEmployeeDetail frmemployeeDetail = new frmEmployeeDetail
            {
                Text = "Create Employee",
                empRep = empRep,
                InsertOrUpdate = false,
                depReg = depRep,
                posReg = posRep

            };

            if (frmemployeeDetail.ShowDialog() == DialogResult.OK)
            {
                LoadListEmployee();
                source.Position = source.Count - 1;
            }
        }

        //Cell double----------------------------------------------------------------------------
        private void Dgvemp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEmployeeDetail frmemployeeDetail = new frmEmployeeDetail
            {
                Text = "Update Employee",
                empRep = empRep,
                InsertOrUpdate = true,
                empInfo = GetEmployeeObject(),
                depReg = depRep,
                posReg = posRep
            };

            if (frmemployeeDetail.ShowDialog() == DialogResult.OK)
            {
                LoadListEmployee();
                source.Position = source.Count - 1;
            }
        }


        //Delete button---------------------------------------------------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = GetEmployeeObject();
                var confirmation = MessageBox.Show("Are you sure to delete this employee?", "Confirm Delete!!!", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    empRep.DeleteEmployee(emp);
                    MessageBox.Show("Delete successful", "Execution results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListEmployee();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a employee!!!");
            }
        }

        //Get ojbect employee----------------------------------------------------------------------
        private Employee GetEmployeeObject()
        {
            Employee emp = null;
            try
            {
                emp = new Employee
                {
                    IdEmp = int.Parse(txtid.Text),
                    Name = txtname.Text,
                    Address = txtaddress.Text,
                    Gender = txtgender.Text,
                    PhoneNum = txtphone.Text,
                    Dob = DateTime.ParseExact(dtpdob.Text, "MM-dd-yyyy", CultureInfo.InvariantCulture),
                    JoinDate = DateTime.ParseExact(dtpjoindate.Text, "MM-dd-yyyy", CultureInfo.InvariantCulture),
                    Email = txtemail.Text,
                    Password = txtpassword.Text,
                    Role = int.Parse(txtrole.Text),
                    BaseSalary = int.Parse(txtsalary.Text),
                    DepNum = int.Parse(txtiddep.Text),
                    IdPos = int.Parse(txtidpos.Text)

                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member!!!");
            }

            return emp;
        }

        //Load list department---------------------------------------------------------------
        public void LoadDepartment()
        {
            try
            {
                var depList = depRep.GetAllDepartment();
                cbofilterdep.DataSource = depList;
                cbofilterdep.ValueMember = "DepNum";
                cbofilterdep.DisplayMember = "DepName";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of department!!!");
            }
        }

        //Load list position-----------------------------------------------------------------
        public void LoadPosition()
        {
            try
            {
                var posList = posRep.GetPositions();
                cbofilterpos.DataSource = posList;
                cbofilterpos.ValueMember = "IdPos";
                cbofilterpos.DisplayMember = "PosName";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error on load list of position!!!");
            }
        }


        //Seleted value in combo box department----------------------------------------------------
        private void cbofilterdep_SelectedValueChanged(object sender, EventArgs e)
        {
            //ComboBox cb = (ComboBox)sender;
            string value;
            try
            {
                value = cbofilterdep.SelectedValue.ToString();
                var listEmp = empRep.GetEmployees();

                if (!String.IsNullOrEmpty(value))
                {
                    List<Employee> tmp = new List<Employee>();
                    foreach (Employee emp in listEmp)
                    {
                        if (emp.DepNum.ToString().Trim().Equals(value.Trim()))
                        {
                            tmp.Add(emp);
                        }
                    }

                    Binding(tmp);

                }
                else
                {
                    MessageBox.Show("Not found!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }


        //Click on combo box derpartment-----------------------------------------------------------------
        private void cbofilterdep_Click(object sender, EventArgs e)
        {
            LoadDepartment();

        }

        //Click on combo box position-----------------------------------------------------------------
        private void cbofilterpos_Click(object sender, EventArgs e)
        {
            LoadPosition();
        }

        //Seleted value in combo box position----------------------------------------------------
        private void cbofilterpos_SelectedValueChanged(object sender, EventArgs e)
        {
            //ComboBox cb = (ComboBox)sender;
            string value;
            try
            {
                value = cbofilterpos.SelectedValue.ToString();
                var listEmp = empRep.GetEmployees();

                if (!String.IsNullOrEmpty(value))
                {
                    List<Employee> tmp = new List<Employee>();
                    foreach (Employee emp in listEmp)
                    {
                        if (emp.IdPos.ToString().Trim().Equals(value.Trim()))
                        {
                            tmp.Add(emp);
                        }
                    }

                    Binding(tmp);
                }
                else
                {
                    MessageBox.Show("Not found!!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }

        //Binding data to txt----------------------------------------------------------------
        public void Binding(List<Employee> List)
        {
            source.Clear();
            source.DataSource = List;
            txtid.DataBindings.Clear();
            txtname.DataBindings.Clear();
            txtaddress.DataBindings.Clear();
            txtgender.DataBindings.Clear();
            txtphone.DataBindings.Clear();
            dtpdob.DataBindings.Clear();
            dtpjoindate.DataBindings.Clear();
            txtemail.DataBindings.Clear();
            txtpassword.DataBindings.Clear();
            txtrole.DataBindings.Clear();
            txtsalary.DataBindings.Clear();
            txtiddep.DataBindings.Clear();
            txtidpos.DataBindings.Clear();


            txtid.DataBindings.Add("Text", source, "IdEmp");
            txtname.DataBindings.Add("Text", source, "Name");
            txtaddress.DataBindings.Add("Text", source, "Address");
            txtgender.DataBindings.Add("Text", source, "Gender");
            txtphone.DataBindings.Add("Text", source, "PhoneNum");
            dtpdob.DataBindings.Add("Text", source, "Dob");
            dtpjoindate.DataBindings.Add("Text", source, "JoinDate");
            txtemail.DataBindings.Add("Text", source, "Email");
            txtpassword.DataBindings.Add("Text", source, "Password");
            txtrole.DataBindings.Add("Text", source, "Role");
            txtsalary.DataBindings.Add("Text", source, "BaseSalary");
            txtiddep.DataBindings.Add("Text", source, "DepNum");
            txtidpos.DataBindings.Add("Text", source, "IdPos");

            dgvemp.DataSource = null;
            dgvemp.DataSource = source;


            if (List.Count == 0)
            {
                btnDelete.Enabled = false;
            }
            else
            {
                if(role == 1)
                {
                    btnDelete.Enabled = true;
                }
            }
        }

        private void frmEmployee_Shown(object sender, EventArgs e)
        {
        }

        private void dgvemp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string value = txtsearch.Text;
            string type = cbotype.SelectedItem.ToString();
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var listEmp = new List<Employee>();
                    if (type.Equals("ID"))
                    {
                        listEmp = empRep.SearchEmployeeByID(value);
                    }
                    else if (type.Equals("Name"))
                    {
                        listEmp = empRep.GetEmployeeByName(value);
                    }
                    else
                    {
                        listEmp = empRep.GetEmployeeByEmail(value);
                    }

                    Binding(listEmp);
                }
                else
                {
                    LoadListEmployee();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not found");
            }
        }
    }
}
