using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Context;
using TicTacToe.Enitities;

namespace TicTacToe
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            pnlLogin.BackColor = Color.FromArgb(112, 128, 144);

            btnLogin.BackColor = Color.FromArgb(112, 128, 144);
            btnLogin.ForeColor = Color.White;

            btnExit.BackColor = Color.FromArgb(112, 128, 144);
            btnExit.ForeColor = Color.White;

            btnRegister.BackColor = Color.FromArgb(112, 128, 144);
            btnRegister.ForeColor = Color.White;

            btnRegister.BackColor = Color.FromArgb(112, 128, 144);
            btnRegister.ForeColor = Color.White;

            txtPassword.UseSystemPasswordChar = true;
            txtPassword2.UseSystemPasswordChar = true;

            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
            txtPassword2.TabIndex = 1;
            txtUsername.Focus();

        }

        TicTacToeDbContext context = new();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUsername.Text;
                string password = txtPassword.Text;
                string confirmPassword = txtPassword2.Text;

                if (userName.Trim().Length == 0 || userName != userName.Trim() || password.Trim().Length == 0 || password != password.Trim() || confirmPassword.Trim().Length == 0 || confirmPassword != confirmPassword.Trim())
                {
                    MessageBox.Show("Please do not leave the field empty.");
                    return;
                }

                if (userName.Length > 20)
                {
                    MessageBox.Show("Password must be maximum 20 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password.Length > 30)
                {
                    MessageBox.Show("Password must be maximum 30 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var userNameControl = context.Players.Any(x => x.UserName == userName);

                if (userNameControl)
                {
                    MessageBox.Show("Username is already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Player newPlayer = new()
                {
                    UserName = userName,
                    Password = password
                };

                context.Players.Add(newPlayer);
                context.SaveChanges();

                MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtPassword2.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
