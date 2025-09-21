namespace Bira.Naveen
{
    partial class Signup
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            SignUpTxt = new Label();
            FirstNameTxt = new Label();
            SignupFirstNameTxtBox = new TextBox();
            LastNameTxt = new Label();
            SignupLastNameTxtBox = new TextBox();
            EmailTxt = new Label();
            SignupEmailTxtBox = new TextBox();
            PasswordTxt = new Label();
            SignupPasswordTxtBox = new TextBox();
            ConfirmPasswordTxt = new Label();
            SignupConfirmPasswordTxtBox = new TextBox();
            SignUpBtn = new Button();
            HaveAccTxt = new Label();
            toolTip1 = new ToolTip(components);
            SignupPanel = new Panel();
            linkLabelsignuplogin = new LinkLabel();
            panelConfirmPasswordUnderline = new Panel();
            panelPasswordUnderline = new Panel();
            panelEmailUnderline = new Panel();
            panelLastNameUnderline = new Panel();
            panelFirstNameUnderline = new Panel();
            pictureBox1 = new PictureBox();
            SignupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SignUpTxt
            // 
            SignUpTxt.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            SignUpTxt.ForeColor = System.Drawing.Color.DeepSkyBlue;
            SignUpTxt.Location = new System.Drawing.Point(0, 50);
            SignUpTxt.Name = "SignUpTxt";
            SignUpTxt.Size = new System.Drawing.Size(728, 54);
            SignUpTxt.TabIndex = 0;
            SignUpTxt.Text = "Create Account";
            SignUpTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.AutoSize = true;
            FirstNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FirstNameTxt.ForeColor = System.Drawing.Color.LightGray;
            FirstNameTxt.Location = new System.Drawing.Point(120, 130);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new System.Drawing.Size(138, 32);
            FirstNameTxt.TabIndex = 1;
            FirstNameTxt.Text = "First Name";
            // 
            // SignupFirstNameTxtBox
            // 
            SignupFirstNameTxtBox.BackColor = System.Drawing.Color.FromArgb(4, 40, 55);
            SignupFirstNameTxtBox.BorderStyle = BorderStyle.None;
            SignupFirstNameTxtBox.Font = new Font("Segoe UI", 12F);
            SignupFirstNameTxtBox.ForeColor = System.Drawing.Color.White;
            SignupFirstNameTxtBox.Location = new System.Drawing.Point(125, 165);
            SignupFirstNameTxtBox.Name = "SignupFirstNameTxtBox";
            SignupFirstNameTxtBox.Size = new System.Drawing.Size(220, 32);
            SignupFirstNameTxtBox.TabIndex = 1;
            SignupFirstNameTxtBox.TextChanged += SignupFirstNameTxtBox_TextChanged;
            // 
            // LastNameTxt
            // 
            LastNameTxt.AutoSize = true;
            LastNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LastNameTxt.ForeColor = System.Drawing.Color.LightGray;
            LastNameTxt.Location = new System.Drawing.Point(380, 130);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new System.Drawing.Size(134, 32);
            LastNameTxt.TabIndex = 3;
            LastNameTxt.Text = "Last Name";
            // 
            // SignupLastNameTxtBox
            // 
            SignupLastNameTxtBox.BackColor = System.Drawing.Color.FromArgb(4, 40, 55);
            SignupLastNameTxtBox.BorderStyle = BorderStyle.None;
            SignupLastNameTxtBox.Font = new Font("Segoe UI", 12F);
            SignupLastNameTxtBox.ForeColor = System.Drawing.Color.White;
            SignupLastNameTxtBox.Location = new System.Drawing.Point(385, 165);
            SignupLastNameTxtBox.Name = "SignupLastNameTxtBox";
            SignupLastNameTxtBox.Size = new System.Drawing.Size(220, 32);
            SignupLastNameTxtBox.TabIndex = 2;
            SignupLastNameTxtBox.TextChanged += SignupLastNameTxtBox_TextChanged;
            // 
            // EmailTxt
            // 
            EmailTxt.AutoSize = true;
            EmailTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EmailTxt.ForeColor = System.Drawing.Color.LightGray;
            EmailTxt.Location = new System.Drawing.Point(120, 230);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new System.Drawing.Size(75, 32);
            EmailTxt.TabIndex = 5;
            EmailTxt.Text = "Email";
            // 
            // SignupEmailTxtBox
            // 
            SignupEmailTxtBox.BackColor = System.Drawing.Color.FromArgb(4, 40, 55);
            SignupEmailTxtBox.BorderStyle = BorderStyle.None;
            SignupEmailTxtBox.Font = new Font("Segoe UI", 12F);
            SignupEmailTxtBox.ForeColor = System.Drawing.Color.White;
            SignupEmailTxtBox.Location = new System.Drawing.Point(125, 265);
            SignupEmailTxtBox.Name = "SignupEmailTxtBox";
            SignupEmailTxtBox.Size = new System.Drawing.Size(480, 32);
            SignupEmailTxtBox.TabIndex = 3;
            SignupEmailTxtBox.TextChanged += SignupEmailTxtBox_TextChanged;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AutoSize = true;
            PasswordTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PasswordTxt.ForeColor = System.Drawing.Color.LightGray;
            PasswordTxt.Location = new System.Drawing.Point(120, 330);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new System.Drawing.Size(122, 32);
            PasswordTxt.TabIndex = 7;
            PasswordTxt.Text = "Password";
            // 
            // SignupPasswordTxtBox
            // 
            SignupPasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(4, 40, 55);
            SignupPasswordTxtBox.BorderStyle = BorderStyle.None;
            SignupPasswordTxtBox.Font = new Font("Segoe UI", 12F);
            SignupPasswordTxtBox.ForeColor = System.Drawing.Color.White;
            SignupPasswordTxtBox.Location = new System.Drawing.Point(125, 365);
            SignupPasswordTxtBox.Name = "SignupPasswordTxtBox";
            SignupPasswordTxtBox.Size = new System.Drawing.Size(480, 32);
            SignupPasswordTxtBox.TabIndex = 4;
            SignupPasswordTxtBox.TextChanged += SignupPasswordTxtBox_TextChanged;
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.AutoSize = true;
            ConfirmPasswordTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ConfirmPasswordTxt.ForeColor = System.Drawing.Color.LightGray;
            ConfirmPasswordTxt.Location = new System.Drawing.Point(120, 430);
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.Size = new System.Drawing.Size(225, 32);
            ConfirmPasswordTxt.TabIndex = 10;
            ConfirmPasswordTxt.Text = "Confirm Password";
            // 
            // SignupConfirmPasswordTxtBox
            // 
            SignupConfirmPasswordTxtBox.BackColor = System.Drawing.Color.FromArgb(4, 40, 55);
            SignupConfirmPasswordTxtBox.BorderStyle = BorderStyle.None;
            SignupConfirmPasswordTxtBox.Font = new Font("Segoe UI", 12F);
            SignupConfirmPasswordTxtBox.ForeColor = System.Drawing.Color.White;
            SignupConfirmPasswordTxtBox.Location = new System.Drawing.Point(125, 465);
            SignupConfirmPasswordTxtBox.Name = "SignupConfirmPasswordTxtBox";
            SignupConfirmPasswordTxtBox.Size = new System.Drawing.Size(480, 32);
            SignupConfirmPasswordTxtBox.TabIndex = 5;
            SignupConfirmPasswordTxtBox.TextChanged += SignupConfirmPasswordTxtBox_TextChanged;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = System.Drawing.Color.FromArgb(0, 98, 152);
            SignUpBtn.Cursor = Cursors.Hand;
            SignUpBtn.FlatAppearance.BorderSize = 0;
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            SignUpBtn.ForeColor = System.Drawing.Color.White;
            SignUpBtn.Location = new System.Drawing.Point(285, 540);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new System.Drawing.Size(158, 59);
            SignUpBtn.TabIndex = 6;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // HaveAccTxt
            // 
            HaveAccTxt.AutoSize = true;
            HaveAccTxt.Font = new Font("Segoe UI", 10F);
            HaveAccTxt.ForeColor = System.Drawing.Color.LightGray;
            HaveAccTxt.Location = new System.Drawing.Point(216, 620);
            HaveAccTxt.Name = "HaveAccTxt";
            HaveAccTxt.Size = new System.Drawing.Size(234, 28);
            HaveAccTxt.TabIndex = 13;
            HaveAccTxt.Text = "Already have an account?";
            // 
            // SignupPanel
            // 
            SignupPanel.Controls.Add(linkLabelsignuplogin);
            SignupPanel.Controls.Add(panelConfirmPasswordUnderline);
            SignupPanel.Controls.Add(panelPasswordUnderline);
            SignupPanel.Controls.Add(panelEmailUnderline);
            SignupPanel.Controls.Add(panelLastNameUnderline);
            SignupPanel.Controls.Add(panelFirstNameUnderline);
            SignupPanel.Controls.Add(SignUpTxt);
            SignupPanel.Controls.Add(SignUpBtn);
            SignupPanel.Controls.Add(FirstNameTxt);
            SignupPanel.Controls.Add(HaveAccTxt);
            SignupPanel.Controls.Add(SignupFirstNameTxtBox);
            SignupPanel.Controls.Add(LastNameTxt);
            SignupPanel.Controls.Add(SignupConfirmPasswordTxtBox);
            SignupPanel.Controls.Add(SignupLastNameTxtBox);
            SignupPanel.Controls.Add(ConfirmPasswordTxt);
            SignupPanel.Controls.Add(EmailTxt);
            SignupPanel.Controls.Add(SignupPasswordTxtBox);
            SignupPanel.Controls.Add(SignupEmailTxtBox);
            SignupPanel.Controls.Add(PasswordTxt);
            SignupPanel.Dock = DockStyle.Right;
            SignupPanel.Location = new System.Drawing.Point(341, 0);
            SignupPanel.Name = "SignupPanel";
            SignupPanel.Size = new System.Drawing.Size(728, 720);
            SignupPanel.TabIndex = 15;
            // 
            // linkLabelsignuplogin
            // 
            linkLabelsignuplogin.AutoSize = true;
            linkLabelsignuplogin.Font = new Font("Segoe UI", 10F);
            linkLabelsignuplogin.LinkColor = System.Drawing.Color.DeepSkyBlue;
            linkLabelsignuplogin.Location = new System.Drawing.Point(445, 620);
            linkLabelsignuplogin.Name = "linkLabelsignuplogin";
            linkLabelsignuplogin.Size = new System.Drawing.Size(60, 28);
            linkLabelsignuplogin.TabIndex = 7;
            linkLabelsignuplogin.TabStop = true;
            linkLabelsignuplogin.Text = "Login";
            linkLabelsignuplogin.LinkClicked += linkLabelsignuplogin_LinkClicked;
            // 
            // panelConfirmPasswordUnderline
            // 
            panelConfirmPasswordUnderline.BackColor = System.Drawing.Color.Gray;
            panelConfirmPasswordUnderline.Location = new System.Drawing.Point(125, 500);
            panelConfirmPasswordUnderline.Name = "panelConfirmPasswordUnderline";
            panelConfirmPasswordUnderline.Size = new System.Drawing.Size(480, 2);
            panelConfirmPasswordUnderline.TabIndex = 18;
            // 
            // panelPasswordUnderline
            // 
            panelPasswordUnderline.BackColor = System.Drawing.Color.Gray;
            panelPasswordUnderline.Location = new System.Drawing.Point(125, 400);
            panelPasswordUnderline.Name = "panelPasswordUnderline";
            panelPasswordUnderline.Size = new System.Drawing.Size(480, 2);
            panelPasswordUnderline.TabIndex = 17;
            // 
            // panelEmailUnderline
            // 
            panelEmailUnderline.BackColor = System.Drawing.Color.Gray;
            panelEmailUnderline.Location = new System.Drawing.Point(125, 300);
            panelEmailUnderline.Name = "panelEmailUnderline";
            panelEmailUnderline.Size = new System.Drawing.Size(480, 2);
            panelEmailUnderline.TabIndex = 16;
            // 
            // panelLastNameUnderline
            // 
            panelLastNameUnderline.BackColor = System.Drawing.Color.Gray;
            panelLastNameUnderline.Location = new System.Drawing.Point(385, 200);
            panelLastNameUnderline.Name = "panelLastNameUnderline";
            panelLastNameUnderline.Size = new System.Drawing.Size(220, 2);
            panelLastNameUnderline.TabIndex = 15;
            // 
            // panelFirstNameUnderline
            // 
            panelFirstNameUnderline.BackColor = System.Drawing.Color.Gray;
            panelFirstNameUnderline.Location = new System.Drawing.Point(125, 200);
            panelFirstNameUnderline.Name = "panelFirstNameUnderline";
            panelFirstNameUnderline.Size = new System.Drawing.Size(220, 2);
            panelFirstNameUnderline.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(350, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(4, 40, 55);
            ClientSize = new System.Drawing.Size(1069, 720);
            Controls.Add(pictureBox1);
            Controls.Add(SignupPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            SignupPanel.ResumeLayout(false);
            SignupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label SignUpTxt;
        private Label FirstNameTxt;
        private TextBox SignupFirstNameTxtBox;
        private Label LastNameTxt;
        private TextBox SignupLastNameTxtBox;
        private Label EmailTxt;
        private TextBox SignupEmailTxtBox;
        private Label PasswordTxt;
        private TextBox SignupPasswordTxtBox;
        private Label ConfirmPasswordTxt;
        private TextBox SignupConfirmPasswordTxtBox;
        private Button SignUpBtn;
        private Label HaveAccTxt;
        private ToolTip toolTip1;
        private Panel SignupPanel;
        private PictureBox pictureBox1;
        private LinkLabel linkLabelsignuplogin;
        private Panel panelFirstNameUnderline;
        private Panel panelLastNameUnderline;
        private Panel panelEmailUnderline;
        private Panel panelPasswordUnderline;
        private Panel panelConfirmPasswordUnderline;
    }
}