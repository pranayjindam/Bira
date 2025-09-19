namespace Bira.Naveen
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginTxt = new Label();
            UserNameTxt = new Label();
            UserNameTxtBox = new TextBox();
            PasswordTxt = new Label();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            LoginTransparentPanel = new Panel();
            linkLabelloginsignup = new LinkLabel();
            labellogsignupdesc = new Label();
            pictureBox1 = new PictureBox();
            LoginTransparentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginTxt
            // 
            LoginTxt.AutoSize = true;
            LoginTxt.BackColor = Color.Transparent;
            LoginTxt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            LoginTxt.ForeColor = Color.White;
            LoginTxt.Location = new Point(295, 91);
            LoginTxt.Margin = new Padding(4, 0, 4, 0);
            LoginTxt.Name = "LoginTxt";
            LoginTxt.Size = new Size(127, 54);
            LoginTxt.TabIndex = 0;
            LoginTxt.Text = "Login";
            LoginTxt.TextAlign = ContentAlignment.BottomRight;
            // 
            // UserNameTxt
            // 
            UserNameTxt.AutoSize = true;
            UserNameTxt.BackColor = Color.Transparent;
            UserNameTxt.Font = new Font("Segoe UI", 12F);
            UserNameTxt.ForeColor = Color.White;
            UserNameTxt.Location = new Point(110, 218);
            UserNameTxt.Margin = new Padding(4, 0, 4, 0);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(125, 32);
            UserNameTxt.TabIndex = 1;
            UserNameTxt.Text = "UserName";
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.Font = new Font("Segoe UI", 12F);
            UserNameTxtBox.Location = new Point(304, 210);
            UserNameTxtBox.Margin = new Padding(4);
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.PlaceholderText = "Username";
            UserNameTxtBox.Size = new Size(332, 39);
            UserNameTxtBox.TabIndex = 2;
            UserNameTxtBox.TextChanged += UserNameTxtBox_TextChanged_1;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AutoSize = true;
            PasswordTxt.BackColor = Color.Transparent;
            PasswordTxt.Font = new Font("Segoe UI", 12F);
            PasswordTxt.ForeColor = Color.White;
            PasswordTxt.Location = new Point(110, 288);
            PasswordTxt.Margin = new Padding(4, 0, 4, 0);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(111, 32);
            PasswordTxt.TabIndex = 3;
            PasswordTxt.Text = "Password";
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI", 12F);
            PasswordTxtBox.Location = new Point(304, 288);
            PasswordTxtBox.Margin = new Padding(4);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PlaceholderText = "password";
            PasswordTxtBox.Size = new Size(332, 39);
            PasswordTxtBox.TabIndex = 4;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Crimson;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderColor = Color.OldLace;
            LoginBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LoginBtn.ForeColor = SystemColors.ButtonHighlight;
            LoginBtn.Location = new Point(295, 405);
            LoginBtn.Margin = new Padding(4);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(138, 56);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginTransparentPanel
            // 
            LoginTransparentPanel.BackColor = Color.Indigo;
            LoginTransparentPanel.Controls.Add(linkLabelloginsignup);
            LoginTransparentPanel.Controls.Add(labellogsignupdesc);
            LoginTransparentPanel.Controls.Add(LoginTxt);
            LoginTransparentPanel.Controls.Add(LoginBtn);
            LoginTransparentPanel.Controls.Add(UserNameTxt);
            LoginTransparentPanel.Controls.Add(PasswordTxt);
            LoginTransparentPanel.Controls.Add(PasswordTxtBox);
            LoginTransparentPanel.Controls.Add(UserNameTxtBox);
            LoginTransparentPanel.Location = new Point(348, 0);
            LoginTransparentPanel.Margin = new Padding(4);
            LoginTransparentPanel.Name = "LoginTransparentPanel";
            LoginTransparentPanel.Size = new Size(728, 611);
            LoginTransparentPanel.TabIndex = 7;
            // 
            // linkLabelloginsignup
            // 
            linkLabelloginsignup.AutoSize = true;
            linkLabelloginsignup.Cursor = Cursors.Hand;
            linkLabelloginsignup.ForeColor = SystemColors.ButtonHighlight;
            linkLabelloginsignup.LinkColor = Color.White;
            linkLabelloginsignup.Location = new Point(585, 358);
            linkLabelloginsignup.Margin = new Padding(4, 0, 4, 0);
            linkLabelloginsignup.Name = "linkLabelloginsignup";
            linkLabelloginsignup.Size = new Size(68, 25);
            linkLabelloginsignup.TabIndex = 7;
            linkLabelloginsignup.TabStop = true;
            linkLabelloginsignup.Text = "Signup";
            linkLabelloginsignup.LinkClicked += linkLabelloginsignup_LinkClicked;
            // 
            // labellogsignupdesc
            // 
            labellogsignupdesc.AutoSize = true;
            labellogsignupdesc.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            labellogsignupdesc.ForeColor = SystemColors.ButtonHighlight;
            labellogsignupdesc.Location = new Point(381, 358);
            labellogsignupdesc.Margin = new Padding(4, 0, 4, 0);
            labellogsignupdesc.Name = "labellogsignupdesc";
            labellogsignupdesc.Size = new Size(174, 21);
            labellogsignupdesc.TabIndex = 6;
            labellogsignupdesc.Text = "Dont have an account ?";
            // 
            // panelSwitchbtn
            panelSwitchbtn = new Panel();
            panelSwitchbtn.BackColor = ColorHelper.FromHex("#b5c6e0");
            panelSwitchbtn.Dock = DockStyle.Top;
            panelSwitchbtn.Height = 65;

            // FlowLayoutPanel inside panelSwitchbtn
            FlowLayoutPanel flowPanel = new FlowLayoutPanel();
            flowPanel.Dock = DockStyle.None;                      // don't stretch
            flowPanel.AutoSize = true;                            // size to content
            flowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowPanel.FlowDirection = FlowDirection.LeftToRight;
            flowPanel.WrapContents = false;
            flowPanel.BackColor = Color.Transparent;

            // Center flowPanel inside parent
            flowPanel.Location = new Point(
                (panelSwitchbtn.Width - (120 * 2 + 20)) / 2,      // center horizontally
                (panelSwitchbtn.Height - 40) / 2                  // center vertically
            );
            flowPanel.Anchor = AnchorStyles.None;

            // Add buttons
            Size btnSize = new Size(120, 40);

            //Loginbtnswitch = UIControls.UIControlFactory.CreateCurvedButton(
            //    "Login",
            //    size: btnSize,
            //    backColor: ColorHelper.FromHex("#0077b6")
            //);

            Signupbtn = UIControls.UIControlFactory.CreateSecondaryButton(
                "Sign Up",
                size: btnSize,
                backColor: ColorHelper.FromHex("#00b4d8")
            );

            // Attach events
            Loginbtnswitch.Click += Loginbtn_Click;
            Signupbtn.Click += Signupbtn_Click;

            // Margins for spacing between them
            Loginbtnswitch.Margin = new Padding(5, 0, 10, 0);
            Signupbtn.Margin = new Padding(10, 0, 5, 0);

            // Add to flow panel
            flowPanel.Controls.Add(Loginbtnswitch);
            flowPanel.Controls.Add(Signupbtn);

            panelSwitchbtn.Controls.Add(flowPanel);

            // Handle resize to keep centered
            panelSwitchbtn.Resize += (s, e) =>
            {
                flowPanel.Location = new Point(
                    (panelSwitchbtn.Width - flowPanel.Width) / 2,
                    (panelSwitchbtn.Height - flowPanel.Height) / 2
                );
            };

            // panelbg
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 611);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1069, 610);
            Controls.Add(pictureBox1);
            Controls.Add(LoginTransparentPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Login";
            Text = "Bira Login";
            Load += Login_Load;
            LoginTransparentPanel.ResumeLayout(false);
            LoginTransparentPanel.PerformLayout();
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
        private Panel LoginTransparentPanel;
        private PictureBox pictureBox1;
        private Label labellogsignupdesc;
        private LinkLabel linkLabelloginsignup;
    }
}