namespace Bira.Naveen
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginTxt = new Label();
            UserNameTxt = new Label();
            UserNameTxtBox = new TextBox();
            PasswordTxt = new Label();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            LoginPanel = new Panel();
            labelLoginsub = new Label();
            ShowHidePassword = new PictureBox();
            labellogsignupdesc = new Label();
            linkLabelloginsignup = new LinkLabel();
            panelPasswordUnderline = new Panel();
            panelUserUnderline = new Panel();
            pictureBox1 = new PictureBox();
            LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowHidePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginTxt
            // 
            LoginTxt.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            LoginTxt.ForeColor = Color.DeepSkyBlue;
            LoginTxt.Location = new Point(0, 50);
            LoginTxt.Name = "LoginTxt";
            LoginTxt.Size = new Size(728, 68);
            LoginTxt.TabIndex = 0;
            LoginTxt.Text = "Sign In";
            LoginTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserNameTxt
            // 
            UserNameTxt.AutoSize = true;
            UserNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UserNameTxt.ForeColor = Color.LightGray;
            UserNameTxt.Location = new Point(120, 200);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(128, 32);
            UserNameTxt.TabIndex = 1;
            UserNameTxt.Text = "Username";
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BackColor = Color.FromArgb(4, 40, 55);
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.Font = new Font("Segoe UI", 12F);
            UserNameTxtBox.ForeColor = Color.White;
            UserNameTxtBox.Location = new Point(125, 235);
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.Size = new Size(480, 32);
            UserNameTxtBox.TabIndex = 2;
            UserNameTxtBox.TextChanged += UserNameTxtBox_TextChanged;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AutoSize = true;
            PasswordTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PasswordTxt.ForeColor = Color.LightGray;
            PasswordTxt.Location = new Point(120, 300);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(122, 32);
            PasswordTxt.TabIndex = 3;
            PasswordTxt.Text = "Password";
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.BackColor = Color.FromArgb(4, 40, 55);
            PasswordTxtBox.BorderStyle = BorderStyle.None;
            PasswordTxtBox.Font = new Font("Segoe UI", 12F);
            PasswordTxtBox.ForeColor = Color.White;
            PasswordTxtBox.Location = new Point(125, 335);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(480, 32);
            PasswordTxtBox.TabIndex = 4;
            PasswordTxtBox.TextChanged += PasswordTxtBox_TextChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(0, 98, 152);
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderSize = 0;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(285, 420);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(158, 59);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(labelLoginsub);
            LoginPanel.Controls.Add(ShowHidePassword);
            LoginPanel.Controls.Add(labellogsignupdesc);
            LoginPanel.Controls.Add(linkLabelloginsignup);
            LoginPanel.Controls.Add(panelPasswordUnderline);
            LoginPanel.Controls.Add(panelUserUnderline);
            LoginPanel.Controls.Add(LoginTxt);
            LoginPanel.Controls.Add(LoginBtn);
            LoginPanel.Controls.Add(UserNameTxt);
            LoginPanel.Controls.Add(PasswordTxt);
            LoginPanel.Controls.Add(PasswordTxtBox);
            LoginPanel.Controls.Add(UserNameTxtBox);
            LoginPanel.Dock = DockStyle.Right;
            LoginPanel.Location = new Point(341, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(728, 610);
            LoginPanel.TabIndex = 7;
            // 
            // labelLoginsub
            // 
            labelLoginsub.Font = new Font("Segoe UI", 10F);
            labelLoginsub.ForeColor = Color.FromArgb(224, 224, 224);
            labelLoginsub.Location = new Point(120, 143);
            labelLoginsub.Name = "labelLoginsub";
            labelLoginsub.Size = new Size(480, 39);
            labelLoginsub.TabIndex = 11;
            labelLoginsub.Text = "Welcome back! please enter your details";
            // 
            // ShowHidePassword
            // 
            ShowHidePassword.BackColor = Color.Transparent;
            ShowHidePassword.Location = new Point(564, 333);
            ShowHidePassword.Name = "ShowHidePassword";
            ShowHidePassword.Size = new Size(41, 36);
            ShowHidePassword.SizeMode = PictureBoxSizeMode.Zoom;
            ShowHidePassword.TabIndex = 10;
            ShowHidePassword.TabStop = false;
            ShowHidePassword.Click += ShowHidePassword_Click;
            // 
            // labellogsignupdesc
            // 
            labellogsignupdesc.AutoSize = true;
            labellogsignupdesc.Font = new Font("Segoe UI", 10F);
            labellogsignupdesc.ForeColor = Color.LightGray;
            labellogsignupdesc.Location = new Point(216, 510);
            labellogsignupdesc.Name = "labellogsignupdesc";
            labellogsignupdesc.Size = new Size(216, 28);
            labellogsignupdesc.TabIndex = 6;
            labellogsignupdesc.Text = "Don't have an account?";
            // 
            // linkLabelloginsignup
            // 
            linkLabelloginsignup.AutoSize = true;
            linkLabelloginsignup.Font = new Font("Segoe UI", 10F);
            linkLabelloginsignup.LinkColor = Color.DeepSkyBlue;
            linkLabelloginsignup.Location = new Point(430, 510);
            linkLabelloginsignup.Name = "linkLabelloginsignup";
            linkLabelloginsignup.Size = new Size(82, 28);
            linkLabelloginsignup.TabIndex = 7;
            linkLabelloginsignup.TabStop = true;
            linkLabelloginsignup.Text = "Sign Up";
            linkLabelloginsignup.LinkClicked += linkLabelloginsignup_LinkClicked;
            // 
            // panelPasswordUnderline
            // 
            panelPasswordUnderline.BackColor = Color.Gray;
            panelPasswordUnderline.Location = new Point(125, 370);
            panelPasswordUnderline.Name = "panelPasswordUnderline";
            panelPasswordUnderline.Size = new Size(480, 2);
            panelPasswordUnderline.TabIndex = 9;
            // 
            // panelUserUnderline
            // 
            panelUserUnderline.BackColor = Color.Gray;
            panelUserUnderline.Location = new Point(125, 270);
            panelUserUnderline.Name = "panelUserUnderline";
            panelUserUnderline.Size = new Size(480, 2);
            panelUserUnderline.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 610);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 40, 55);
            ClientSize = new Size(1069, 610);
            Controls.Add(pictureBox1);
            Controls.Add(LoginPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bira Login";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShowHidePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label LoginTxt;
        private Label UserNameTxt;
        private TextBox UserNameTxtBox;
        private Label PasswordTxt;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
        private Panel LoginPanel;
        private PictureBox pictureBox1;
        private Label labellogsignupdesc;
        private LinkLabel linkLabelloginsignup;
        private Panel panelUserUnderline;
        private Panel panelPasswordUnderline;
        private PictureBox ShowHidePassword;
        private Label labelLoginsub;
    }
}