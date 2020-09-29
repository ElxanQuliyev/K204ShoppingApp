using K204ShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K204ShoppingApp
{
    public partial class LoginForm : Form
    {
        ShoppingDBEntities db = new ShoppingDBEntities();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
           Customer selectedCustomer= db.Customers.FirstOrDefault(cs=>cs.Email==email);
            if (selectedCustomer != null) {
                if (selectedCustomer.Password == password.HashMe())
                {
                     if (chRemember.Checked)
                     {
                        Properties.Settings.Default.email = email;
                        Properties.Settings.Default.password = password;
                        Properties.Settings.Default.isRemember = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.email = "";
                        Properties.Settings.Default.password = "";
                        Properties.Settings.Default.isRemember = false;
                        Properties.Settings.Default.Save();

                    }
                    CustomerDashboard csDash = new CustomerDashboard();
                    csDash.Show();
                    this.Close();
                }
                else
                {
                    lblError.Text = "Password doesn't correct";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Email doesn't correct";
                lblError.Visible = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isRemember)
            {
                txtEmail.Text = Properties.Settings.Default.email;
                txtPassword.Text = Properties.Settings.Default.password;
                chRemember.Checked = true;
            }
        }
    }
}
