using Bira.UI;
using System.Drawing.Drawing2D;
using System.Drawing;

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
            panelPicture = new Panel();
            pictureBox1 = new PictureBox();
            panelmain = new Panel();
            panelSwitchbtn = new Panel();
            panelbg = new Panel();
           
            panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelbg.SuspendLayout();
            SuspendLayout();


            //
            //Loginbtnswitch
            //
            //Loginbtnswitch = UIControls.UIControlFactory.CreateSecondaryButton("Login", backColor: ColorHelper.FromHex("#0077b6"));
            //Loginbtnswitch.Location = new Point(100, 10);
            //panelSwitchbtn.Controls.Add(Loginbtnswitch);
          
            //
            //



            //
            //Signupbtn
            //
            //Signupbtn = UIControls.UIControlFactory.CreateSecondaryButton("Sign Up", backColor: ColorHelper.FromHex("#00b4d8"));
            //Signupbtn.Location = new Point(400, 10);
            //panelSwitchbtn.Controls.Add(Signupbtn);
            
            //



            // 
            // panelPicture
            // 
            panelPicture.BackColor = Color.FromArgb(235, 244, 245);
            panelPicture.Controls.Add(pictureBox1);
            panelPicture.Dock = DockStyle.Left;
            panelPicture.Location = new Point(0, 0);
            panelPicture.Name = "panelPicture";
            panelPicture.Size = new Size(350, 721);
            panelPicture.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 721);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelmain
            // 
            panelmain.Dock = DockStyle.Fill;
            panelmain.Location = new Point(0, 65);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(819, 656);
            panelmain.TabIndex = 9;
            // 
            // panelSwitchbtn
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
            panelbg.Controls.Add(panelmain);
            panelbg.Controls.Add(panelSwitchbtn);
            panelbg.Dock = DockStyle.Fill;
            panelbg.Location = new Point(350, 0);
            panelbg.Name = "panelbg";
            panelbg.Size = new Size(819, 721);
            panelbg.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1169, 721);
            Controls.Add(panelbg);
            Controls.Add(panelPicture);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Login";
            Text = "Bira Login";
            Load += Login_Load;
            panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelbg.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelPicture;
        private PictureBox pictureBox1;
        private Panel panelmain;
        private Button Loginbtn;
        private Button Signupbtn;
        private Panel panelSwitchbtn;
        private Panel panelbg;
        private Button Loginbtnswitch;
    }
}