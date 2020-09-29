using K204ShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K204ShoppingApp
{
    public partial class RegisterForm : Form
    {
        ShoppingDBEntities db = new ShoppingDBEntities();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegCustomer_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string repeatPassword = txtConfirmPassword.Text;
            string[] myArray = new[] { firstname, lastname, phone, email, password, repeatPassword };
            if(Extensions.IsEmptyString(myArray,string.Empty))
            {
                if(long.TryParse(phone,out long phoneL))
                {
                    if (password.Length>5)
                    {
                        if (password == repeatPassword)
                        {
                            lblError.Visible = false;

                            Customer cus = new Customer()
                            {
                                Firstname = firstname,
                                Lastname = lastname,
                                Phone = phone,
                                Password =  password.HashMe(),
                                Email = email
                            };
                            db.Customers.Add(cus);
                            db.SaveChanges();
                            MessageBox.Show(cus.Firstname + " " + cus.Lastname + " added successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            lblError.Text = "Please,Password and Confirm password does not match!";
                            lblError.Visible = true;
                        }
                    }
                    else
                    {
                        lblError.Text = "Please,Password length should be greater 6 charachter!";
                        lblError.Visible = true;
                    }
                }
                else
                {
                    lblError.Text = "Please,Phone number non-numeric charachter!";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Please,Fill all the field!";
                lblError.Visible = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<48 || e.KeyChar > 57 || txtPhone.Text.Length > 15) && (e.KeyChar!=8))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
