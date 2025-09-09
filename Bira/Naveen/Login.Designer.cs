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
            ForgettonPasswordTxt = new Label();
            LoginTransparentPanel = new Panel();
            LoginTransparentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginTxt
            // 
            LoginTxt.AutoSize = true;
            LoginTxt.BackColor = Color.Transparent;
            LoginTxt.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            LoginTxt.ForeColor = Color.White;
            LoginTxt.Location = new Point(256, 17);
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
            UserNameTxt.Location = new Point(101, 90);
            UserNameTxt.Name = "UserNameTxt";
            UserNameTxt.Size = new Size(103, 28);
            UserNameTxt.TabIndex = 1;
            UserNameTxt.Text = "UserName";
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.Font = new Font("Segoe UI", 12F);
            UserNameTxtBox.Location = new Point(100, 143);
            UserNameTxtBox.Name = "UserNameTxtBox";
            UserNameTxtBox.PlaceholderText = "Username";
            UserNameTxtBox.Size = new Size(390, 34);
            UserNameTxtBox.TabIndex = 2;
            UserNameTxtBox.TextChanged += UserNameTxtBox_TextChanged_1;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AutoSize = true;
            PasswordTxt.BackColor = Color.Transparent;
            PasswordTxt.Font = new Font("Segoe UI", 12F);
            PasswordTxt.ForeColor = Color.White;
            PasswordTxt.Location = new Point(101, 230);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(93, 28);
            PasswordTxt.TabIndex = 3;
            PasswordTxt.Text = "Password";
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Font = new Font("Segoe UI", 12F);
            PasswordTxtBox.Location = new Point(100, 275);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PlaceholderText = "password";
            PasswordTxtBox.Size = new Size(390, 34);
            PasswordTxtBox.TabIndex = 4;
            PasswordTxtBox.TextChanged += PasswordTxtBox_TextChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Transparent;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LoginBtn.ForeColor = Color.Black;
            LoginBtn.Location = new Point(256, 363);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(110, 45);
            LoginBtn.TabIndex = 5;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ForgettonPasswordTxt
            // 
            ForgettonPasswordTxt.AutoSize = true;
            ForgettonPasswordTxt.Cursor = Cursors.Hand;
            ForgettonPasswordTxt.ForeColor = Color.White;
            ForgettonPasswordTxt.Location = new Point(100, 345);
            ForgettonPasswordTxt.Name = "ForgettonPasswordTxt";
            ForgettonPasswordTxt.Size = new Size(135, 20);
            ForgettonPasswordTxt.TabIndex = 6;
            ForgettonPasswordTxt.Text = "ForgettonPassword";
            // 
            // LoginTransparentPanel
            // 
            LoginTransparentPanel.Controls.Add(LoginTxt);
            LoginTransparentPanel.Controls.Add(LoginBtn);
            LoginTransparentPanel.Controls.Add(ForgettonPasswordTxt);
            LoginTransparentPanel.Controls.Add(UserNameTxt);
            LoginTransparentPanel.Controls.Add(PasswordTxt);
            LoginTransparentPanel.Controls.Add(PasswordTxtBox);
            LoginTransparentPanel.Controls.Add(UserNameTxtBox);
            LoginTransparentPanel.Location = new Point(127, 21);
            LoginTransparentPanel.Name = "LoginTransparentPanel";
            LoginTransparentPanel.Size = new Size(616, 427);
            LoginTransparentPanel.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(855, 488);
            Controls.Add(LoginTransparentPanel);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            LoginTransparentPanel.ResumeLayout(false);
            LoginTransparentPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LoginTxt;
        private Label UserNameTxt;
        private TextBox UserNameTxtBox;
        private Label PasswordTxt;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
        private Label ForgettonPasswordTxt;
        private Panel LoginTransparentPanel;
    }
}