using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    public partial class frmLogin : Form
    {
        IEmployeeRepository empRep = new EmployeeRepository();
        public frmLogin()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string pass = txtpassword.Text;
            string fileName = "appsettings.json";
            string json = File.ReadAllText(fileName);
            var adminAccount = JsonSerializer.Deserialize<DefaultAccount>(json, null);
            string email = adminAccount.Email;
            string password = adminAccount.Password;
            Employee emp = empRep.Login(user, pass);

            if (email.Equals(user) && password.Equals(pass))
            {
                frmHome frmhome = new frmHome
                {
                    email = email,
                    role = 1
                };

                this.Hide();
                frmhome.ShowDialog();
            }
            else if (emp != null)
            {
                frmHome frmhome = new frmHome
                {
                    email = emp.Email,
                    role = emp.Role

                };
                this.Hide();
                frmhome.ShowDialog();
            }
            else
            {
                MessageBox.Show("User or password is wrong, Try again.", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
