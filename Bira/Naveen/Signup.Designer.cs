using Bira.UI;

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
            SignupTransparentPanel = new Panel();
            linkLabelsignuplogin = new LinkLabel();
            pictureBox1 = new PictureBox();
            SignupTransparentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SignUpTxt
            // 
            SignUpTxt.AutoSize = true;
            SignUpTxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            SignUpTxt.ForeColor = Color.White;
            SignUpTxt.Location = new Point(305, 18);
            SignUpTxt.Margin = new Padding(4, 0, 4, 0);
            SignUpTxt.Name = "SignUpTxt";
            SignUpTxt.Size = new Size(129, 45);
            SignUpTxt.TabIndex = 0;
            SignUpTxt.Text = "SignUp";
            // 
            // FirstNameTxt
            // 
            FirstNameTxt = UIControls.UIControlFactory.CreateTextLabel("First Name");
            FirstNameTxt.Location = new Point(22, 126);
            
            // 
            // SignupFirstNameTxtBox
            // 
            SignupFirstNameTxtBox = InputControls.InputControlFactory.CreateTextInput(placeholder: "Enter your first name");
            SignupFirstNameTxtBox.Location = new Point(268, 115);
            // 
            // LastNameTxt
            // 
            LastNameTxt = UIControls.UIControlFactory.CreateTextLabel("Last Name");
            LastNameTxt.Location = new Point(22, 211);
            // 
            // SignupLastNameTxtBox
            // 
            SignupLastNameTxtBox = InputControls.InputControlFactory.CreateTextInput(placeholder: "Enter your last name");
            SignupLastNameTxtBox.Location = new Point(268, 200);
            // 
            // EmailTxt
            // 
            EmailTxt = UIControls.UIControlFactory.CreateTextLabel("Email");
            EmailTxt.Location = new Point(22, 298);
            // 
            // SignupEmailTxtBox
            // 
            SignupEmailTxtBox = InputControls.InputControlFactory.CreateTextInput(placeholder: "Enter your email");
            SignupEmailTxtBox.Location = new Point(268, 286);
            // 
            // PasswordTxt
            // 
            PasswordTxt = UIControls.UIControlFactory.CreateTextLabel("Password");
            PasswordTxt.Location = new Point(22, 391);
            // 
            // SignupPasswordTxtBox
            // 
            SignupPasswordTxtBox = InputControls.InputControlFactory.CreateTextInput(placeholder: "Enter your password");
            SignupPasswordTxtBox.Location = new Point(268, 380);
            SignupPasswordTxtBox.TextChanged += SignupPasswordTxt_TextChanged;
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt = UIControls.UIControlFactory.CreateTextLabel("Confirm Password");
            ConfirmPasswordTxt.Location = new Point(11, 485);
            // 
            // SignupConfirmPasswordTxtBox
            // 
            SignupConfirmPasswordTxtBox = InputControls.InputControlFactory.CreateTextInput(placeholder: "Confirm your password");
            SignupConfirmPasswordTxtBox.Location = new Point(268, 474);
            SignupConfirmPasswordTxtBox.TabIndex = 11;
            SignupConfirmPasswordTxtBox.TextChanged += SignupConfirmPasswordTxt_TextChanged;
            // 
            // SignUpBtn
            // 
            SignUpBtn = UIControls.UIControlFactory.CreatePrimaryButton("Sign Up"); 
            SignUpBtn.Location = new Point(305, 603);
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // HaveAccTxt
            // 
            HaveAccTxt = UIControls.UIControlFactory.CreateTextLabel("Already have an account?");
            HaveAccTxt.Location = new Point(449, 549);
            HaveAccTxt.TabIndex = 13;
            // SignupTransparentPanel
            // 
            SignupTransparentPanel.BackColor = Color.DarkTurquoise;
            SignupTransparentPanel.Controls.Add(linkLabelsignuplogin);
            SignupTransparentPanel.Controls.Add(SignUpTxt);
            SignupTransparentPanel.Controls.Add(SignUpBtn);
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
            SignupTransparentPanel.Location = new Point(356, 8);
            SignupTransparentPanel.Margin = new Padding(4);
            SignupTransparentPanel.Name = "SignupTransparentPanel";
            SignupTransparentPanel.Size = new Size(834, 868);
            SignupTransparentPanel.TabIndex = 15;
            SignupTransparentPanel.Paint += SignupTransparentPanel_Paint;
            // 
            // linkLabelsignuplogin
            // 
            linkLabelsignuplogin.AutoSize = true;
            linkLabelsignuplogin.Font = new Font("Segoe UI", 10F);
            linkLabelsignuplogin.LinkColor = Color.Blue;
            linkLabelsignuplogin.Location = new Point(699, 549);
            linkLabelsignuplogin.Margin = new Padding(4, 0, 4, 0);
            linkLabelsignuplogin.Name = "linkLabelsignuplogin";
            linkLabelsignuplogin.Size = new Size(57, 28);
            linkLabelsignuplogin.TabIndex = 14;
            linkLabelsignuplogin.TabStop = true;
            linkLabelsignuplogin.Text = "login";
            linkLabelsignuplogin.LinkClicked += linkLabelsignuplogin_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 721);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1188, 720);
            Controls.Add(pictureBox1);
            Controls.Add(SignupTransparentPanel);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Signup";
            Text = "Sign Up";
            SignupTransparentPanel.ResumeLayout(false);
            SignupTransparentPanel.PerformLayout();
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
        private Panel SignupTransparentPanel;
        private PictureBox pictureBox1;
        private LinkLabel linkLabelsignuplogin;
    }
}
