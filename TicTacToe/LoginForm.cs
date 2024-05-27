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

namespace TicTacToe
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
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

            txtUserName.TabIndex = 0;
            txtPassword.TabIndex = 1;
            txtUserName.Focus();
        }
        
        
        TicTacToeDbContext context = new();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text;
                string password = txtPassword.Text;

                if (userName.Trim().Length == 0 || userName != userName.Trim() || password.Trim().Length == 0 || password != password.Trim())
                {
                    MessageBox.Show("Please do not leave the field empty.");
                    return;
                }

                var user = context.Players.FirstOrDefault(x => x.UserName == userName && x.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtUserName.Text = string.Empty;
                    txtPassword.Text = string.Empty;

                    TicTacToe ticTacToe = new TicTacToe(userName);
                    ticTacToe.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
