namespace Bira.Naveen
{
    partial class NewTeam
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
            NewTeamPanel = new Panel();
            NewTeamAddBtn = new Button();
            NewTeamTxtBox = new TextBox();
            NewTeamTxt = new Label();
            NewTeamHeadTxt = new Label();
            NewTeamDesTxt = new Label();
            NewTeamDesTxtBox = new TextBox();
            NewTeamPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NewTeamPanel
            // 
            NewTeamPanel.Controls.Add(NewTeamAddBtn);
            NewTeamPanel.Controls.Add(NewTeamDesTxtBox);
            NewTeamPanel.Controls.Add(NewTeamDesTxt);
            NewTeamPanel.Controls.Add(NewTeamTxtBox);
            NewTeamPanel.Controls.Add(NewTeamTxt);
            NewTeamPanel.Controls.Add(NewTeamHeadTxt);
            NewTeamPanel.Location = new Point(215, 41);
            NewTeamPanel.Margin = new Padding(4);
            NewTeamPanel.Name = "NewTeamPanel";
            NewTeamPanel.Size = new Size(688, 600);
            NewTeamPanel.TabIndex = 0;
            // 
            // NewTeamAddBtn
            // 
            NewTeamAddBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            NewTeamAddBtn.Location = new Point(268, 479);
            NewTeamAddBtn.Margin = new Padding(4);
            NewTeamAddBtn.Name = "NewTeamAddBtn";
            NewTeamAddBtn.Size = new Size(158, 59);
            NewTeamAddBtn.TabIndex = 5;
            NewTeamAddBtn.Text = "Add";
            NewTeamAddBtn.UseVisualStyleBackColor = true;
            NewTeamAddBtn.Click += NewTeamAddBtn_Click_1;
            // 
            // NewTeamTxtBox
            // 
            NewTeamTxtBox.Font = new Font("Segoe UI", 12F);
            NewTeamTxtBox.Location = new Point(291, 158);
            NewTeamTxtBox.Margin = new Padding(4);
            NewTeamTxtBox.Name = "NewTeamTxtBox";
            NewTeamTxtBox.PlaceholderText = "Team Name";
            NewTeamTxtBox.Size = new Size(309, 39);
            NewTeamTxtBox.TabIndex = 2;
            // 
            // NewTeamTxt
            // 
            NewTeamTxt.AutoSize = true;
            NewTeamTxt.Font = new Font("Segoe UI", 12F);
            NewTeamTxt.Location = new Point(81, 161);
            NewTeamTxt.Margin = new Padding(4, 0, 4, 0);
            NewTeamTxt.Name = "NewTeamTxt";
            NewTeamTxt.Size = new Size(71, 32);
            NewTeamTxt.TabIndex = 1;
            NewTeamTxt.Text = "Team";
            // 
            // NewTeamHeadTxt
            // 
            NewTeamHeadTxt.AutoSize = true;
            NewTeamHeadTxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            NewTeamHeadTxt.Location = new Point(235, 35);
            NewTeamHeadTxt.Margin = new Padding(4, 0, 4, 0);
            NewTeamHeadTxt.Name = "NewTeamHeadTxt";
            NewTeamHeadTxt.Size = new Size(176, 45);
            NewTeamHeadTxt.TabIndex = 0;
            NewTeamHeadTxt.Text = "New Team";
            // 
            // NewTeamDesTxt
            // 
            NewTeamDesTxt.AutoSize = true;
            NewTeamDesTxt.Font = new Font("Segoe UI", 12F);
            NewTeamDesTxt.Location = new Point(81, 319);
            NewTeamDesTxt.Margin = new Padding(4, 0, 4, 0);
            NewTeamDesTxt.Name = "NewTeamDesTxt";
            NewTeamDesTxt.Size = new Size(135, 32);
            NewTeamDesTxt.TabIndex = 3;
            NewTeamDesTxt.Text = "Description";
            // 
            // NewTeamDesTxtBox
            // 
            NewTeamDesTxtBox.Font = new Font("Segoe UI", 12F);
            NewTeamDesTxtBox.Location = new Point(291, 269);
            NewTeamDesTxtBox.Margin = new Padding(4);
            NewTeamDesTxtBox.Multiline = true;
            NewTeamDesTxtBox.Name = "NewTeamDesTxtBox";
            NewTeamDesTxtBox.PlaceholderText = "Description";
            NewTeamDesTxtBox.Size = new Size(309, 142);
            NewTeamDesTxtBox.TabIndex = 4;
            // 
            // NewTeam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 691);
            Controls.Add(NewTeamPanel);
            Margin = new Padding(4);
            Name = "NewTeam";
            Text = "NewTeam";
            NewTeamPanel.ResumeLayout(false);
            NewTeamPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel NewTeamPanel;
        private Label NewTeamHeadTxt;
        private TextBox NewTeamTxtBox;
        private Label NewTeamTxt;
        private Button NewTeamAddBtn;
        private TextBox NewTeamDesTxtBox;
        private Label NewTeamDesTxt;
    }
}