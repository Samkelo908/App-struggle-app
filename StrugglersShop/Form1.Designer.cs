namespace StrugglersShop
{
    partial class Form1
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
            lblWelcome = new Label();
            GetStart = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnRegister = new Button();
            btnLogin1 = new Button();
            txtPassword1 = new TextBox();
            txtUser1 = new TextBox();
            lblPassword = new Label();
            lblUser1 = new Label();
            btnRegister2 = new Button();
            panel3 = new Panel();
            btnLogin2 = new Button();
            txtPassword2 = new TextBox();
            txtUser2 = new TextBox();
            lblPassword2 = new Label();
            lblUser2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F);
            lblWelcome.Location = new Point(185, 56);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(292, 37);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome to Strugglers ";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // GetStart
            // 
            GetStart.BackColor = SystemColors.Highlight;
            GetStart.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GetStart.Location = new Point(241, 122);
            GetStart.Name = "GetStart";
            GetStart.Size = new Size(183, 40);
            GetStart.TabIndex = 1;
            GetStart.Text = "Get Started";
            GetStart.UseVisualStyleBackColor = false;
            GetStart.Click += GetStart_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(GetStart);
            panel1.Controls.Add(lblWelcome);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(655, 235);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnRegister);
            panel2.Controls.Add(btnLogin1);
            panel2.Controls.Add(txtPassword1);
            panel2.Controls.Add(txtUser1);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(lblUser1);
            panel2.Location = new Point(0, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 198);
            panel2.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkOrange;
            btnRegister.Location = new Point(49, 170);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(102, 23);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin1
            // 
            btnLogin1.BackColor = SystemColors.HotTrack;
            btnLogin1.Location = new Point(322, 140);
            btnLogin1.Name = "btnLogin1";
            btnLogin1.Size = new Size(102, 25);
            btnLogin1.TabIndex = 4;
            btnLogin1.Text = "Login";
            btnLogin1.UseVisualStyleBackColor = false;
            btnLogin1.Click += btnLogin1_Click;
            // 
            // txtPassword1
            // 
            txtPassword1.Location = new Point(185, 111);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(239, 23);
            txtPassword1.TabIndex = 3;
            txtPassword1.TextChanged += txtPassword1_TextChanged;
            // 
            // txtUser1
            // 
            txtUser1.Location = new Point(185, 59);
            txtUser1.Name = "txtUser1";
            txtUser1.Size = new Size(239, 23);
            txtUser1.TabIndex = 2;
            txtUser1.TextChanged += txtUser1_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(65, 109);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 21);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblUser1
            // 
            lblUser1.AutoSize = true;
            lblUser1.Font = new Font("Segoe UI", 12F);
            lblUser1.Location = new Point(60, 57);
            lblUser1.Name = "lblUser1";
            lblUser1.Size = new Size(81, 21);
            lblUser1.TabIndex = 0;
            lblUser1.Text = "Username";
            // 
            // btnRegister2
            // 
            btnRegister2.BackColor = SystemColors.HotTrack;
            btnRegister2.Location = new Point(323, 129);
            btnRegister2.Name = "btnRegister2";
            btnRegister2.Size = new Size(102, 23);
            btnRegister2.TabIndex = 6;
            btnRegister2.Text = "Register";
            btnRegister2.UseVisualStyleBackColor = false;
            btnRegister2.Click += btnRegister2_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnRegister2);
            panel3.Controls.Add(btnLogin2);
            panel3.Controls.Add(txtPassword2);
            panel3.Controls.Add(txtUser2);
            panel3.Controls.Add(lblPassword2);
            panel3.Controls.Add(lblUser2);
            panel3.Location = new Point(0, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(655, 192);
            panel3.TabIndex = 4;
            // 
            // btnLogin2
            // 
            btnLogin2.BackColor = Color.DarkOrange;
            btnLogin2.Location = new Point(50, 164);
            btnLogin2.Name = "btnLogin2";
            btnLogin2.Size = new Size(102, 25);
            btnLogin2.TabIndex = 6;
            btnLogin2.Text = "Login";
            btnLogin2.UseVisualStyleBackColor = false;
            btnLogin2.Click += btnLogin2_Click;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(186, 100);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.Size = new Size(239, 23);
            txtPassword2.TabIndex = 7;
            txtPassword2.TextChanged += txtPassword2_TextChanged;
            // 
            // txtUser2
            // 
            txtUser2.Location = new Point(186, 43);
            txtUser2.Name = "txtUser2";
            txtUser2.Size = new Size(239, 23);
            txtUser2.TabIndex = 6;
            txtUser2.TextChanged += txtUser2_TextChanged;
            // 
            // lblPassword2
            // 
            lblPassword2.AutoSize = true;
            lblPassword2.Font = new Font("Segoe UI", 12F);
            lblPassword2.Location = new Point(66, 98);
            lblPassword2.Name = "lblPassword2";
            lblPassword2.Size = new Size(76, 21);
            lblPassword2.TabIndex = 6;
            lblPassword2.Text = "Password";
            // 
            // lblUser2
            // 
            lblUser2.AutoSize = true;
            lblUser2.Font = new Font("Segoe UI", 12F);
            lblUser2.Location = new Point(61, 41);
            lblUser2.Name = "lblUser2";
            lblUser2.Size = new Size(81, 21);
            lblUser2.TabIndex = 0;
            lblUser2.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 684);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Menu";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblWelcome;
        private Button GetStart;
        private Panel panel1;
        private Panel panel2;
        private Label lblUser1;
        private TextBox txtPassword1;
        private TextBox txtUser1;
        private Label lblPassword;
        private Button btnRegister;
        private Button btnLogin1;
        private Panel panel3;
        private Label lblUser2;
        private Button btnRegister2;
        private Button btnLogin2;
        private TextBox txtPassword2;
        private TextBox txtUser2;
        private Label lblPassword2;
    }
}
