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
            pictureBox1 = new PictureBox();
            labellogsignupdesc = new Label();
            linkLabelloginsignup = new LinkLabel();
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
            LoginTxt.Location = new Point(236, 73);
            LoginTxt.Name = "LoginTxt";
            LoginTxt.Size = new Size(110, 46);
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
            UserNameTxt.Location = new Point(88, 174);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(103, 28);
            UserNameTxt.TabIndex = 1;
            UserNameTxt.Text = "UserName";
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.Font = new Font("Segoe UI", 12F);
            UserNameTxtBox.Location = new Point(243, 168);
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.PlaceholderText = "Username";
            UserNameTxtBox.Size = new Size(266, 34);
            UserNameTxtBox.TabIndex = 2;
            UserNameTxtBox.TextChanged += UserNameTxtBox_TextChanged_1;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AutoSize = true;
            PasswordTxt.BackColor = Color.Transparent;
            PasswordTxt.Font = new Font("Segoe UI", 12F);
            PasswordTxt.ForeColor = Color.White;
            PasswordTxt.Location = new Point(88, 230);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(93, 28);
            PasswordTxt.TabIndex = 3;
            PasswordTxt.Text = "Password";
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI", 12F);
            PasswordTxtBox.Location = new Point(243, 230);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PlaceholderText = "password";
            PasswordTxtBox.Size = new Size(266, 34);
            PasswordTxtBox.TabIndex = 4;
            PasswordTxtBox.TextChanged += PasswordTxtBox_TextChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Crimson;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatAppearance.BorderColor = Color.OldLace;
            LoginBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LoginBtn.ForeColor = SystemColors.ButtonHighlight;
            LoginBtn.Location = new Point(236, 324);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(110, 45);
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
            LoginTransparentPanel.Location = new Point(278, 0);
            LoginTransparentPanel.Name = "LoginTransparentPanel";
            LoginTransparentPanel.Size = new Size(582, 489);
            LoginTransparentPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 489);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // labellogsignupdesc
            // 
            labellogsignupdesc.AutoSize = true;
            labellogsignupdesc.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            labellogsignupdesc.ForeColor = SystemColors.ButtonHighlight;
            labellogsignupdesc.Location = new Point(305, 286);
            labellogsignupdesc.Name = "labellogsignupdesc";
            labellogsignupdesc.Size = new Size(157, 19);
            labellogsignupdesc.TabIndex = 6;
            labellogsignupdesc.Text = "Dont have an account ?";
            // 
            // linkLabelloginsignup
            // 
            linkLabelloginsignup.AutoSize = true;
            linkLabelloginsignup.Cursor = Cursors.Hand;
            linkLabelloginsignup.ForeColor = SystemColors.ButtonHighlight;
            linkLabelloginsignup.Location = new Point(468, 286);
            linkLabelloginsignup.Name = "linkLabelloginsignup";
            linkLabelloginsignup.Size = new Size(55, 20);
            linkLabelloginsignup.TabIndex = 7;
            linkLabelloginsignup.TabStop = true;
            linkLabelloginsignup.Text = "Signup";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(855, 488);
            Controls.Add(pictureBox1);
            Controls.Add(LoginTransparentPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
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