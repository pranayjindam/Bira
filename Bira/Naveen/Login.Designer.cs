using Bira.UI;

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
            panelPicture = new Panel();
            pictureBox1 = new PictureBox();
            LoginTransparentPanel.SuspendLayout();
            panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginTxt
            // 
            LoginTxt = UIControls.UIControlFactory.CreateLabelHeader("Login");
            LoginTxt.Location = new Point(295, 91);
            LoginTxt.TabIndex = 2;
            // 
            // UserNameTxt
            // 
            UserNameTxt = UIControls.UIControlFactory.CreateTextLabel("User Name");
            UserNameTxt.Location = new Point(110, 218);
            UserNameTxt.TabIndex = 4;
            // 
            // UserNameTxtBox
            // 
            UserNameTxtBox =InputControls.InputControlFactory.CreateTextInput(placeholder:"username");
            UserNameTxtBox.Location = new Point(304, 210);
            UserNameTxtBox.TabIndex = 7;
            UserNameTxtBox.TextChanged += UserNameTxtBox_TextChanged_1;
            // 
            // PasswordTxt
            // 
            PasswordTxt = UIControls.UIControlFactory.CreateTextLabel("Password");
            PasswordTxt.Location = new Point(110, 288);
            PasswordTxt.TabIndex = 5;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox = InputControls.InputControlFactory.CreateTextInput(placeholder:"password", isPassword:true);
            PasswordTxtBox.Location = new Point(304, 288);
            PasswordTxtBox.TabIndex = 6;
            // 
            // LoginBtn
            // 
            LoginBtn = UIControls.UIControlFactory.CreatePrimaryButton("Login");
            LoginBtn.Location = new Point(347, 425);
            LoginBtn.TabIndex = 3;
            // 

            // linkLabelloginsignup
            // 
            linkLabelloginsignup = UIControls.UIControlFactory.CreateLinkLabel("Sign Up");
            linkLabelloginsignup.Location = new Point(585, 358);
            linkLabelloginsignup.TabIndex = 0;
            linkLabelloginsignup.LinkClicked += linkLabelloginsignup_LinkClicked;
            // 
            // labellogsignupdesc
            // 
            labellogsignupdesc = UIControls.UIControlFactory.CreateTextLabel("Don't have an account?");
            labellogsignupdesc.Location = new Point(381, 358);
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
            LoginTransparentPanel.Controls.Add(PasswordTxtBox);
            LoginTransparentPanel.Controls.Add(UserNameTxtBox);
            LoginTransparentPanel.Location = new Point(348, 0);
            LoginTransparentPanel.Margin = new Padding(4);
            LoginTransparentPanel.Name = "LoginTransparentPanel";
            LoginTransparentPanel.Size = new Size(728, 611);
            LoginTransparentPanel.TabIndex = 7;
            // 
          
            // panelPicture
            // 
            panelPicture.BackColor = ColorHelper.FromHex("#ebf4f5");
            panelPicture.Controls.Add(pictureBox1);
            panelPicture.Dock = DockStyle.Left;
            panelPicture.Location = new Point(0, 0);
            panelPicture.Name = "panelPicture";
            panelPicture.Size = new Size(350, 610);
            panelPicture.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 610);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1069, 610);
            Controls.Add(panelPicture);
            Controls.Add(LoginTransparentPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Login";
            Text = "Bira Login";
            LoginTransparentPanel.ResumeLayout(false);
            LoginTransparentPanel.PerformLayout();
            panelPicture.ResumeLayout(false);
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
        private Label labellogsignupdesc;
        private LinkLabel linkLabelloginsignup;
        private Panel panelPicture;
        private PictureBox pictureBox1;
    }
}