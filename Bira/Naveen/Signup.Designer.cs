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
            SignInAccTxt = new Label();
            toolTip1 = new ToolTip(components);
            SignupTransparentPanel = new Panel();
            SignupTransparentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SignUpTxt
            // 
            SignUpTxt.AutoSize = true;
            SignUpTxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            SignUpTxt.ForeColor = Color.White;
            SignUpTxt.Location = new Point(259, 35);
            SignUpTxt.Name = "SignUpTxt";
            SignUpTxt.Size = new Size(110, 37);
            SignUpTxt.TabIndex = 0;
            SignUpTxt.Text = "SignUp";
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.AutoSize = true;
            FirstNameTxt.Font = new Font("Segoe UI", 12F);
            FirstNameTxt.ForeColor = Color.White;
            FirstNameTxt.Location = new Point(54, 101);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.Size = new Size(106, 28);
            FirstNameTxt.TabIndex = 1;
            FirstNameTxt.Text = "First Name";
            // 
            // SignupFirstNameTxtBox
            // 
            SignupFirstNameTxtBox.Font = new Font("Segoe UI", 12F);
            SignupFirstNameTxtBox.Location = new Point(244, 98);
            SignupFirstNameTxtBox.Name = "SignupFirstNameTxtBox";
            SignupFirstNameTxtBox.PlaceholderText = "Enter your first name";
            SignupFirstNameTxtBox.Size = new Size(391, 34);
            SignupFirstNameTxtBox.TabIndex = 2;
            // 
            // LastNameTxt
            // 
            LastNameTxt.AutoSize = true;
            LastNameTxt.Font = new Font("Segoe UI", 12F);
            LastNameTxt.ForeColor = Color.White;
            LastNameTxt.Location = new Point(54, 169);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(103, 28);
            LastNameTxt.TabIndex = 3;
            LastNameTxt.Text = "Last Name";
            // 
            // SignupLastNameTxtBox
            // 
            SignupLastNameTxtBox.Font = new Font("Segoe UI", 12F);
            SignupLastNameTxtBox.Location = new Point(244, 166);
            SignupLastNameTxtBox.Name = "SignupLastNameTxtBox";
            SignupLastNameTxtBox.PlaceholderText = "Enter your last name";
            SignupLastNameTxtBox.Size = new Size(391, 34);
            SignupLastNameTxtBox.TabIndex = 4;
            // 
            // EmailTxt
            // 
            EmailTxt.AutoSize = true;
            EmailTxt.Font = new Font("Segoe UI", 12F);
            EmailTxt.ForeColor = Color.White;
            EmailTxt.Location = new Point(54, 238);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(59, 28);
            EmailTxt.TabIndex = 5;
            EmailTxt.Text = "Email";
            // 
            // SignupEmailTxtBox
            // 
            SignupEmailTxtBox.Font = new Font("Segoe UI", 12F);
            SignupEmailTxtBox.Location = new Point(244, 235);
            SignupEmailTxtBox.Name = "SignupEmailTxtBox";
            SignupEmailTxtBox.PlaceholderText = "Enter your email";
            SignupEmailTxtBox.Size = new Size(391, 34);
            SignupEmailTxtBox.TabIndex = 6;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AutoSize = true;
            PasswordTxt.Font = new Font("Segoe UI", 12F);
            PasswordTxt.ForeColor = Color.White;
            PasswordTxt.Location = new Point(54, 313);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(93, 28);
            PasswordTxt.TabIndex = 7;
            PasswordTxt.Text = "Password";
            // 
            // SignupPasswordTxtBox
            // 
            SignupPasswordTxtBox.Font = new Font("Segoe UI", 12F);
            SignupPasswordTxtBox.Location = new Point(244, 310);
            SignupPasswordTxtBox.Name = "SignupPasswordTxtBox";
            SignupPasswordTxtBox.PlaceholderText = "Enter your password";
            SignupPasswordTxtBox.Size = new Size(391, 34);
            SignupPasswordTxtBox.TabIndex = 9;
            SignupPasswordTxtBox.TextChanged += SignupPasswordTxt_TextChanged;
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.AutoSize = true;
            ConfirmPasswordTxt.Font = new Font("Segoe UI", 12F);
            ConfirmPasswordTxt.ForeColor = Color.White;
            ConfirmPasswordTxt.Location = new Point(45, 388);
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.Size = new Size(168, 28);
            ConfirmPasswordTxt.TabIndex = 10;
            ConfirmPasswordTxt.Text = "Confirm Password";
            // 
            // SignupConfirmPasswordTxtBox
            // 
            SignupConfirmPasswordTxtBox.Font = new Font("Segoe UI", 12F);
            SignupConfirmPasswordTxtBox.Location = new Point(244, 385);
            SignupConfirmPasswordTxtBox.Name = "SignupConfirmPasswordTxtBox";
            SignupConfirmPasswordTxtBox.PlaceholderText = "Confirm your password";
            SignupConfirmPasswordTxtBox.Size = new Size(391, 34);
            SignupConfirmPasswordTxtBox.TabIndex = 11;
            SignupConfirmPasswordTxtBox.TextChanged += SignupConfirmPasswordTxt_TextChanged;
            // 
            // SignUpBtn
            // 
            SignUpBtn.Font = new Font("Segoe UI", 16F);
            SignUpBtn.Location = new Point(217, 569);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(162, 61);
            SignUpBtn.TabIndex = 12;
            SignUpBtn.Text = "Sign Up";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // HaveAccTxt
            // 
            HaveAccTxt.AutoSize = true;
            HaveAccTxt.ForeColor = Color.White;
            HaveAccTxt.Location = new Point(397, 474);
            HaveAccTxt.Name = "HaveAccTxt";
            HaveAccTxt.Size = new Size(178, 20);
            HaveAccTxt.TabIndex = 13;
            HaveAccTxt.Text = "Already have an account?";
            // 
            // SignInAccTxt
            // 
            SignInAccTxt.AutoSize = true;
            SignInAccTxt.Cursor = Cursors.Hand;
            SignInAccTxt.Font = new Font("Segoe UI", 10F);
            SignInAccTxt.ForeColor = Color.White;
            SignInAccTxt.Location = new Point(572, 471);
            SignInAccTxt.Name = "SignInAccTxt";
            SignInAccTxt.Size = new Size(63, 23);
            SignInAccTxt.TabIndex = 14;
            SignInAccTxt.Text = "Sign In";
            SignInAccTxt.Click += SignInAccTxt_Click;
            // 
            // SignupTransparentPanel
            // 
            SignupTransparentPanel.Controls.Add(SignUpTxt);
            SignupTransparentPanel.Controls.Add(SignUpBtn);
            SignupTransparentPanel.Controls.Add(SignInAccTxt);
            SignupTransparentPanel.Controls.Add(FirstNameTxt);
            SignupTransparentPanel.Controls.Add(HaveAccTxt);
            SignupTransparentPanel.Controls.Add(SignupFirstNameTxtBox);
            SignupTransparentPanel.Controls.Add(LastNameTxt);
            SignupTransparentPanel.Controls.Add(SignupConfirmPasswordTxtBox);
            SignupTransparentPanel.Controls.Add(SignupLastNameTxtBox);
            SignupTransparentPanel.Controls.Add(ConfirmPasswordTxt);
            SignupTransparentPanel.Controls.Add(EmailTxt);
            SignupTransparentPanel.Controls.Add(SignupPasswordTxtBox);
            SignupTransparentPanel.Controls.Add(SignupEmailTxtBox);
            SignupTransparentPanel.Controls.Add(PasswordTxt);
            SignupTransparentPanel.Location = new Point(159, 48);
            SignupTransparentPanel.Name = "SignupTransparentPanel";
            SignupTransparentPanel.Size = new Size(667, 694);
            SignupTransparentPanel.TabIndex = 15;
            SignupTransparentPanel.Paint += SignupTransparentPanel_Paint;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(982, 803);
            Controls.Add(SignupTransparentPanel);
            Name = "Signup";
            Text = "Sign Up";
            SignupTransparentPanel.ResumeLayout(false);
            SignupTransparentPanel.PerformLayout();
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
        private Label SignInAccTxt;
        private ToolTip toolTip1;
        private Panel SignupTransparentPanel;
    }
}
