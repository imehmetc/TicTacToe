namespace TicTacToe
{
    partial class LoginForm
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
            txtPassword = new TextBox();
            txtUserName = new TextBox();
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
            pnlLogin.Size = new Size(304, 181);
            pnlLogin.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.loginAvatar;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(221, 425);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(71, 28);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(159, 359);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 45);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(28, 359);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 45);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(28, 303);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 22);
            txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe UI", 12F);
            txtUserName.Location = new Point(28, 235);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(233, 22);
            txtUserName.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(28, 281);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(28, 213);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 7;
            label1.Text = "Username";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 459);
            Controls.Add(pnlLogin);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
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
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label2;
        private Label label1;
    }
}