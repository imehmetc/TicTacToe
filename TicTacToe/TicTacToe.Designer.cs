namespace TicTacToe
{
    partial class TicTacToe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnA1 = new Button();
            btnA2 = new Button();
            btnA3 = new Button();
            btnB1 = new Button();
            btnB2 = new Button();
            btnB3 = new Button();
            btnC1 = new Button();
            btnC2 = new Button();
            btnC3 = new Button();
            btnNewGame = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            lblPlayer2Text = new Label();
            lblPlayer2 = new Label();
            label7 = new Label();
            lblPlayer2Score = new Label();
            lblPlayer1Score = new Label();
            lblPlayer1Text = new Label();
            lblPlayer1 = new Label();
            label1 = new Label();
            btnReset = new Button();
            label2 = new Label();
            dgvRank = new DataGridView();
            label3 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRank).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnA1);
            flowLayoutPanel1.Controls.Add(btnA2);
            flowLayoutPanel1.Controls.Add(btnA3);
            flowLayoutPanel1.Controls.Add(btnB1);
            flowLayoutPanel1.Controls.Add(btnB2);
            flowLayoutPanel1.Controls.Add(btnB3);
            flowLayoutPanel1.Controls.Add(btnC1);
            flowLayoutPanel1.Controls.Add(btnC2);
            flowLayoutPanel1.Controls.Add(btnC3);
            flowLayoutPanel1.Location = new Point(12, 44);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(498, 390);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnA1
            // 
            btnA1.Font = new Font("Segoe UI", 65F);
            btnA1.Location = new Point(3, 3);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(160, 123);
            btnA1.TabIndex = 0;
            btnA1.UseVisualStyleBackColor = true;
            btnA1.Click += btnA1_Click;
            // 
            // btnA2
            // 
            btnA2.Font = new Font("Segoe UI", 65F);
            btnA2.Location = new Point(169, 3);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(160, 123);
            btnA2.TabIndex = 1;
            btnA2.UseVisualStyleBackColor = true;
            btnA2.Click += btnA1_Click;
            // 
            // btnA3
            // 
            btnA3.Font = new Font("Segoe UI", 65F);
            btnA3.Location = new Point(335, 3);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(160, 123);
            btnA3.TabIndex = 2;
            btnA3.UseVisualStyleBackColor = true;
            btnA3.Click += btnA1_Click;
            // 
            // btnB1
            // 
            btnB1.Font = new Font("Segoe UI", 65F);
            btnB1.Location = new Point(3, 132);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(160, 123);
            btnB1.TabIndex = 3;
            btnB1.UseVisualStyleBackColor = true;
            btnB1.Click += btnA1_Click;
            // 
            // btnB2
            // 
            btnB2.Font = new Font("Segoe UI", 65F);
            btnB2.Location = new Point(169, 132);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(160, 123);
            btnB2.TabIndex = 4;
            btnB2.UseVisualStyleBackColor = true;
            btnB2.Click += btnA1_Click;
            // 
            // btnB3
            // 
            btnB3.Font = new Font("Segoe UI", 65F);
            btnB3.Location = new Point(335, 132);
            btnB3.Name = "btnB3";
            btnB3.Size = new Size(160, 123);
            btnB3.TabIndex = 5;
            btnB3.UseVisualStyleBackColor = true;
            btnB3.Click += btnA1_Click;
            // 
            // btnC1
            // 
            btnC1.Font = new Font("Segoe UI", 65F);
            btnC1.Location = new Point(3, 261);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(160, 123);
            btnC1.TabIndex = 6;
            btnC1.UseVisualStyleBackColor = true;
            btnC1.Click += btnA1_Click;
            // 
            // btnC2
            // 
            btnC2.Font = new Font("Segoe UI", 65F);
            btnC2.Location = new Point(169, 261);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(160, 123);
            btnC2.TabIndex = 7;
            btnC2.UseVisualStyleBackColor = true;
            btnC2.Click += btnA1_Click;
            // 
            // btnC3
            // 
            btnC3.Font = new Font("Segoe UI", 65F);
            btnC3.Location = new Point(335, 261);
            btnC3.Name = "btnC3";
            btnC3.Size = new Size(160, 123);
            btnC3.TabIndex = 8;
            btnC3.UseVisualStyleBackColor = true;
            btnC3.Click += btnA1_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNewGame.Location = new Point(11, 171);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(149, 38);
            btnNewGame.TabIndex = 1;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.Location = new Point(868, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 27);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblPlayer2Text);
            panel1.Controls.Add(lblPlayer2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblPlayer2Score);
            panel1.Controls.Add(lblPlayer1Score);
            panel1.Controls.Add(lblPlayer1Text);
            panel1.Controls.Add(lblPlayer1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnNewGame);
            panel1.Location = new Point(527, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 390);
            panel1.TabIndex = 3;
            // 
            // lblPlayer2Text
            // 
            lblPlayer2Text.AutoSize = true;
            lblPlayer2Text.Font = new Font("Segoe UI", 14F);
            lblPlayer2Text.ForeColor = Color.Red;
            lblPlayer2Text.Location = new Point(14, 350);
            lblPlayer2Text.Name = "lblPlayer2Text";
            lblPlayer2Text.Size = new Size(78, 25);
            lblPlayer2Text.TabIndex = 4;
            lblPlayer2Text.Text = "Player2:";
            // 
            // lblPlayer2
            // 
            lblPlayer2.AutoSize = true;
            lblPlayer2.Font = new Font("Segoe UI", 14F);
            lblPlayer2.Location = new Point(11, 117);
            lblPlayer2.Name = "lblPlayer2";
            lblPlayer2.Size = new Size(116, 25);
            lblPlayer2.TabIndex = 4;
            lblPlayer2.Text = "Player2  -  O";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(51, 281);
            label7.Name = "label7";
            label7.Size = new Size(67, 25);
            label7.TabIndex = 4;
            label7.Text = "Score:";
            // 
            // lblPlayer2Score
            // 
            lblPlayer2Score.AutoSize = true;
            lblPlayer2Score.Font = new Font("Segoe UI", 14F);
            lblPlayer2Score.ForeColor = Color.Red;
            lblPlayer2Score.Location = new Point(115, 350);
            lblPlayer2Score.Name = "lblPlayer2Score";
            lblPlayer2Score.Size = new Size(22, 25);
            lblPlayer2Score.TabIndex = 4;
            lblPlayer2Score.Text = "0";
            // 
            // lblPlayer1Score
            // 
            lblPlayer1Score.AutoSize = true;
            lblPlayer1Score.Font = new Font("Segoe UI", 14F);
            lblPlayer1Score.ForeColor = Color.Blue;
            lblPlayer1Score.Location = new Point(115, 316);
            lblPlayer1Score.Name = "lblPlayer1Score";
            lblPlayer1Score.Size = new Size(22, 25);
            lblPlayer1Score.TabIndex = 4;
            lblPlayer1Score.Text = "0";
            // 
            // lblPlayer1Text
            // 
            lblPlayer1Text.AutoSize = true;
            lblPlayer1Text.Font = new Font("Segoe UI", 14F);
            lblPlayer1Text.ForeColor = Color.Blue;
            lblPlayer1Text.Location = new Point(14, 316);
            lblPlayer1Text.Name = "lblPlayer1Text";
            lblPlayer1Text.Size = new Size(78, 25);
            lblPlayer1Text.TabIndex = 4;
            lblPlayer1Text.Text = "Player1:";
            // 
            // lblPlayer1
            // 
            lblPlayer1.AutoSize = true;
            lblPlayer1.Font = new Font("Segoe UI", 14F);
            lblPlayer1.Location = new Point(11, 68);
            lblPlayer1.Name = "lblPlayer1";
            lblPlayer1.Size = new Size(113, 25);
            lblPlayer1.TabIndex = 4;
            lblPlayer1.Text = "Player1  -  X";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 3;
            label1.Text = "Active Player:";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReset.Location = new Point(11, 217);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(149, 35);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(200, 9);
            label2.Name = "label2";
            label2.Size = new Size(155, 30);
            label2.TabIndex = 4;
            label2.Text = "Tic - Tac - Toe";
            // 
            // dgvRank
            // 
            dgvRank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRank.Location = new Point(724, 71);
            dgvRank.Name = "dgvRank";
            dgvRank.Size = new Size(230, 364);
            dgvRank.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(775, 44);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 3;
            label3.Text = "Leader Board";
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(970, 453);
            Controls.Add(dgvRank);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TicTacToe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRank).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnA1;
        private Button btnA2;
        private Button btnA3;
        private Button btnB1;
        private Button btnB2;
        private Button btnB3;
        private Button btnC1;
        private Button btnC2;
        private Button btnC3;
        private Button btnNewGame;
        private Button btnExit;
        private Panel panel1;
        private Button btnReset;
        private Label label2;
        private Label lblPlayer2Text;
        private Label lblPlayer2;
        private Label label7;
        private Label lblPlayer1Text;
        private Label lblPlayer1;
        private Label label1;
        private Label lblPlayer2Score;
        private Label lblPlayer1Score;
        private DataGridView dgvRank;
        private Label label3;
    }
}
