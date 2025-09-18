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
            SignupTransparentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SignUpTxt
            // 
            SignUpTxt = UIControls.UIControlFactory.CreateLabelHeader("Sign Up");
            SignUpTxt.Location = new Point(305, 20); // centered
            // 
            // FirstNameTxt
            //
            FirstNameTxt = UIControls.UIControlFactory.CreateTextLabel("First Name");
            FirstNameTxt.Location = new Point(200, 100); 
            // 
            // SignupFirstNameTxtBox
            // 
            SignupFirstNameTxtBox = InputControls.InputControlFactory.CreateTextInput(size:new Size(220,31),placeholder:"Enter Your First Name");
            SignupFirstNameTxtBox.Location = new Point(400, 100);
            SignupFirstNameTxtBox.Name = "SignupFirstNameTxtBox";
            // 
            // LastNameTxt
            // 
            LastNameTxt = UIControls.UIControlFactory.CreateTextLabel("Last Name");
            LastNameTxt.Location = new Point(200, 160);
            // 
            // SignupLastNameTxtBox
            // 
            SignupLastNameTxtBox = InputControls.InputControlFactory.CreateTextInput(size: new Size(220, 31), placeholder: "Enter Your Last Name");
            SignupLastNameTxtBox.Location = new Point(400, 160);
            SignupLastNameTxtBox.Name = "SignupLastNameTxtBox";
            // 
            // EmailTxt
            // 
            EmailTxt = UIControls.UIControlFactory.CreateTextLabel("EMail");
            EmailTxt.Location = new Point(200, 220);
            // 
            // SignupEmailTxtBox
            // 
            SignupEmailTxtBox = InputControls.InputControlFactory.CreateTextInput(size: new Size(220, 31), placeholder: "Enter Your Email");
            SignupEmailTxtBox.Location = new Point(400, 220);
            SignupEmailTxtBox.Name = "SignupEmailTxtBox";
            // 
            // PasswordTxt
            // 
            PasswordTxt = UIControls.UIControlFactory.CreateTextLabel("Password");
            PasswordTxt.Location = new Point(200, 280);
           
            // 
            // SignupPasswordTxtBox
            // 
            SignupPasswordTxtBox = InputControls.InputControlFactory.CreateTextInput(size: new Size(220, 31), placeholder: "Enter Your Password", isPassword: true);
            SignupPasswordTxtBox.Location = new Point(400, 280);
            SignupPasswordTxtBox.Name = "SignupPasswordTxtBox";
            SignupPasswordTxtBox.TextChanged += SignupPasswordTxt_TextChanged;
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt = UIControls.UIControlFactory.CreateTextLabel("Confirm Password");
            ConfirmPasswordTxt.Location = new Point(200, 340);
            // 
            // SignupConfirmPasswordTxtBox
            // 
            SignupConfirmPasswordTxtBox = InputControls.InputControlFactory.CreateTextInput(size: new Size(220, 31), placeholder: "Re-enter Your Password", isPassword: true);
            SignupConfirmPasswordTxtBox.Location = new Point(400, 340);
            SignupConfirmPasswordTxtBox.Name = "SignupConfirmPasswordTxtBox";
            SignupConfirmPasswordTxtBox.TextChanged += SignupConfirmPasswordTxt_TextChanged;
            // 
            // SignUpBtn
            // 
            SignUpBtn = UIControls.UIControlFactory.CreatePrimaryButton("Sign Up", backColor: ColorHelper.FromHex("#00b4d8"));
            SignUpBtn.Location = new Point(320, 420);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // HaveAccTxt
            // 
            HaveAccTxt = UIControls.UIControlFactory.CreateTextLabel("have an account?");
            HaveAccTxt.Location = new Point(260, 480);
            // 
            // SignupTransparentPanel
            // 
            SignupTransparentPanel.BackColor = ColorHelper.FromHex("#edede9");
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
            SignupTransparentPanel.Dock = DockStyle.Fill;
            SignupTransparentPanel.Location = new Point(0, 0);
            SignupTransparentPanel.Margin = new Padding(4);
            SignupTransparentPanel.Name = "SignupTransparentPanel";
            SignupTransparentPanel.Size = new Size(706, 555);
            SignupTransparentPanel.TabIndex = 15;
           // SignupTransparentPanel.Paint += SignupTransparentPanel_Paint;
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
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(819, 596);
            Controls.Add(SignupTransparentPanel);
            Margin = new Padding(4);
            MaximizeBox = false;
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
        private ToolTip toolTip1;
        private Panel SignupTransparentPanel;
        private LinkLabel linkLabelsignuplogin;
    }
}
