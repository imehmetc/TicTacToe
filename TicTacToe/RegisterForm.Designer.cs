namespace TicTacToe
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLogin = new Panel();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            btnRegister = new Button();
            btnLogin = new Button();
            txtPassword2 = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Dock = DockStyle.Top;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(288, 181);
            pnlLogin.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.loginAvatar;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(204, 490);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(71, 28);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(80, 419);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 45);
            btnRegister.TabIndex = 21;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(11, 490);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(71, 28);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword2
            // 
            txtPassword2.BorderStyle = BorderStyle.None;
            txtPassword2.Font = new Font("Segoe UI", 12F);
            txtPassword2.Location = new Point(24, 359);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(233, 22);
            txtPassword2.TabIndex = 17;
            txtPassword2.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(24, 293);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 22);
            txtPassword.TabIndex = 18;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(24, 225);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(233, 22);
            txtUsername.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(24, 337);
            label3.Name = "label3";
            label3.Size = new Size(120, 19);
            label3.TabIndex = 14;
            label3.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(24, 271);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(24, 203);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 16;
            label1.Text = "Username";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 536);
            Controls.Add(pnlLogin);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword2);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLogin;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnRegister;
        private Button btnLogin;
        private TextBox txtPassword2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}