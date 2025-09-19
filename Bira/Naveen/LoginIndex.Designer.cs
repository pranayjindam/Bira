using Bira.UI;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace Bira.Naveen
{
    partial class LoginIndex
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
            PasswordPanel = new Panel();
            UserNamePanel = new Panel();
            LoginTransparentPanel = new Panel();
            PasswordIcon = new PictureBox();
            EmailIcon = new PictureBox();
            linkLabelloginsignup = new LinkLabel();
            labellogsignupdesc = new Label();
            LoginTransparentPanel.SuspendLayout();
           
            SuspendLayout();
            // 
            // LoginTxt
            // 
            LoginTxt = UIControls.UIControlFactory.CreateLabelHeader("Login");
            LoginTxt.Location = new Point(310, 60);
            LoginTxt.TabIndex = 2;
            // 
            //// UserNameTxt
            //// 
            //UserNameTxt = UIControls.UIControlFactory.CreateTextLabel("User Name");
            //UserNameTxt.Location = new Point(110, 218);
            //UserNameTxt.TabIndex = 4;
            // 
            // UserNameTxtBox
            // 
            //UserNameTxtBox = InputControls.InputControlFactory.CreateTextInput(placeholder: "username");
            //UserNameTxtBox.Location = new Point(304, 210);
            //UserNameTxtBox.TabIndex = 7;
           
            // 
            //// PasswordTxt
            //// 
            //PasswordTxt = UIControls.UIControlFactory.CreateTextLabel("Password");
            //PasswordTxt.Location = new Point(110, 288);
            //PasswordTxt.TabIndex = 5;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox = InputControls.InputControlFactory.CreateTextInput(placeholder: "password", isPassword: true);
            PasswordTxtBox.Location = new Point(304, 288);
            PasswordTxtBox.TabIndex = 6;
            // 
            // LoginBtn
            // 
            //LoginBtn = UIControls.UIControlFactory.CreatePrimaryButton("Login");
            //LoginBtn.Location = new Point(347, 425);
            //LoginBtn.TabIndex = 3;

            LoginBtn.BackColor = ColorHelper.FromHex("#7FFFD4");
            LoginBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(290, 300);
            LoginBtn.Size = new Size(150, 55);
            LoginBtn.Text = "Login";
            LoginBtn.FlatStyle = FlatStyle.Flat; // Important: remove default borders
            LoginBtn.FlatAppearance.BorderSize = 0; // No border
            LoginBtn.UseVisualStyleBackColor = false;


            // Make Button Curved (Paint Event)
            LoginBtn.Paint += (s, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 50; // FULL PILL SHAPE
                    Rectangle rect = LoginBtn.ClientRectangle;

                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    LoginBtn.Region = new Region(path);
                }
            };

            //
            //PasswordPanel
            //
            PasswordPanel.BackColor = Color.White;
            PasswordPanel.Location = new Point(110, 220);
            PasswordPanel.Size = new Size(500, 50);
            PasswordPanel.Padding = new Padding(8, 5, 8, 5);
            PasswordPanel.Paint += (s, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 45;
                    Rectangle rect = PasswordPanel.ClientRectangle;
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    PasswordPanel.Region = new Region(path);
                }
            };
            //
            //UserNamePanel
            //
            UserNamePanel.BackColor = Color.White;
            UserNamePanel.Location = new Point(110, 150);
            UserNamePanel.Size = new Size(500, 50);
            UserNamePanel.Padding = new Padding(8, 5, 8, 5);
            UserNamePanel.Paint += (s, e) =>
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    int radius = 45;
                    Rectangle rect = UserNamePanel.ClientRectangle;
                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();
                    UserNamePanel.Region = new Region(path);
                }
            };
            //

            //
            //
            //
            // 
            // PasswordIcon
            // 

            PasswordIcon.Image = Properties.Resources.password_icon; // Make sure you have this in Resources
            PasswordIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            PasswordIcon.Location = new Point(10, 10);
            PasswordIcon.Size = new Size(28, 28);

            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.BorderStyle = BorderStyle.None;
            PasswordTxtBox.Font = new Font("Segoe UI", 12F);
            PasswordTxtBox.Location = new Point(50, 12);
            PasswordTxtBox.Size = new Size(430, 32);
            PasswordTxtBox.PlaceholderText = "Password";
            PasswordTxtBox.UseSystemPasswordChar = true;
            PasswordTxtBox.Margin = new (10, 10, 10, 10);

            PasswordPanel.Controls.Add(PasswordIcon);
            PasswordPanel.Controls.Add(PasswordTxtBox);
            //

            // 
            // EmailIcon
            // 
            EmailIcon.Image = Properties.Resources.email_icon; // Make sure you have this in Resources
            EmailIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            EmailIcon.Location = new Point(10, 10);
            EmailIcon.Size = new Size(28, 28);

            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox.BorderStyle = BorderStyle.None;
            UserNameTxtBox.Font = new Font("Segoe UI", 12F);
            UserNameTxtBox.Location = new Point(50, 12);
            UserNameTxtBox.Size = new Size(430, 32);
            UserNameTxtBox.PlaceholderText = "Email";
            UserNameTxtBox.Margin = new (10, 10, 10, 10);

            UserNamePanel.Controls.Add(EmailIcon);
            UserNamePanel.Controls.Add(UserNameTxtBox);

            //


            // linkLabelloginsignup
            // 
            linkLabelloginsignup = UIControls.UIControlFactory.CreateLinkLabel("Sign Up");
            linkLabelloginsignup.Location = new Point(500, 380);
            linkLabelloginsignup.TabIndex = 0;
            linkLabelloginsignup.LinkClicked += linkLabelloginsignup_LinkClicked;
            // labellogsignupdesc
            // 
            labellogsignupdesc = UIControls.UIControlFactory.CreateTextLabel("Don't have an account?");
            labellogsignupdesc.Location = new Point(300, 380);
            labellogsignupdesc.TabIndex = 1;
            // 
            // LoginTransparentPanel
            // 
            LoginTransparentPanel.BackColor = ColorHelper.FromHex("#b5c6e0");
            LoginTransparentPanel.Controls.Add(linkLabelloginsignup);
            LoginTransparentPanel.Controls.Add(labellogsignupdesc);
            LoginTransparentPanel.Controls.Add(LoginTxt);
            LoginTransparentPanel.Controls.Add(LoginBtn);
           
            LoginTransparentPanel.Controls.Add(UserNameTxt);
            LoginTransparentPanel.Controls.Add(PasswordTxt);
           // LoginTransparentPanel.Controls.Add(PasswordTxtBox);
          //  LoginTransparentPanel.Controls.Add(UserNameTxtBox);
            LoginTransparentPanel.Controls.Add(PasswordPanel);
            LoginTransparentPanel.Controls.Add(UserNamePanel);
            // LoginTransparentPanel.Location = new Point(348, 0);
            LoginTransparentPanel.Margin = new Padding(4);
            LoginTransparentPanel.Name = "LoginTransparentPanel";
           // LoginTransparentPanel.Size = new Size(728, 611);
           LoginTransparentPanel.Dock = DockStyle.Fill;
            LoginTransparentPanel.TabIndex = 7;
            // 

         
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(728, 611);
         
            Controls.Add(LoginTransparentPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Login";
            Text = "Bira Login";
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
        private Panel LoginTransparentPanel;
        private PictureBox PasswordIcon;
        private PictureBox EmailIcon;
        private Panel PasswordPanel;
        private Panel UserNamePanel;
        private Label labellogsignupdesc;
        private LinkLabel linkLabelloginsignup;
       
      
    }
}