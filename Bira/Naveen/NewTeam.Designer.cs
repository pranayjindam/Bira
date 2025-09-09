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
            NewTeamHeadTxt = new Label();
            NewTeamTxt = new Label();
            NewTeamTxtBox = new TextBox();
            NewTeamDesTxt = new Label();
            NewTeamDesTxtBox = new TextBox();
            NewTeamAddBtn = new Button();
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
            NewTeamPanel.Location = new Point(172, 33);
            NewTeamPanel.Name = "NewTeamPanel";
            NewTeamPanel.Size = new Size(550, 480);
            NewTeamPanel.TabIndex = 0;
            // 
            // NewTeamHeadTxt
            // 
            NewTeamHeadTxt.AutoSize = true;
            NewTeamHeadTxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            NewTeamHeadTxt.Location = new Point(188, 28);
            NewTeamHeadTxt.Name = "NewTeamHeadTxt";
            NewTeamHeadTxt.Size = new Size(151, 37);
            NewTeamHeadTxt.TabIndex = 0;
            NewTeamHeadTxt.Text = "New Team";
            // 
            // NewTeamTxt
            // 
            NewTeamTxt.AutoSize = true;
            NewTeamTxt.Font = new Font("Segoe UI", 12F);
            NewTeamTxt.Location = new Point(65, 129);
            NewTeamTxt.Name = "NewTeamTxt";
            NewTeamTxt.Size = new Size(57, 28);
            NewTeamTxt.TabIndex = 1;
            NewTeamTxt.Text = "Team";
            // 
            // NewTeamTxtBox
            // 
            NewTeamTxtBox.Font = new Font("Segoe UI", 12F);
            NewTeamTxtBox.Location = new Point(233, 126);
            NewTeamTxtBox.Name = "NewTeamTxtBox";
            NewTeamTxtBox.PlaceholderText = "Team Name";
            NewTeamTxtBox.Size = new Size(248, 34);
            NewTeamTxtBox.TabIndex = 2;
            // 
            // NewTeamDesTxt
            // 
            NewTeamDesTxt.AutoSize = true;
            NewTeamDesTxt.Font = new Font("Segoe UI", 12F);
            NewTeamDesTxt.Location = new Point(65, 255);
            NewTeamDesTxt.Name = "NewTeamDesTxt";
            NewTeamDesTxt.Size = new Size(112, 28);
            NewTeamDesTxt.TabIndex = 3;
            NewTeamDesTxt.Text = "Description";
            // 
            // NewTeamDesTxtBox
            // 
            NewTeamDesTxtBox.Font = new Font("Segoe UI", 12F);
            NewTeamDesTxtBox.Location = new Point(233, 215);
            NewTeamDesTxtBox.Multiline = true;
            NewTeamDesTxtBox.Name = "NewTeamDesTxtBox";
            NewTeamDesTxtBox.PlaceholderText = "Description";
            NewTeamDesTxtBox.Size = new Size(248, 114);
            NewTeamDesTxtBox.TabIndex = 4;
            // 
            // NewTeamAddBtn
            // 
            NewTeamAddBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            NewTeamAddBtn.Location = new Point(214, 383);
            NewTeamAddBtn.Name = "NewTeamAddBtn";
            NewTeamAddBtn.Size = new Size(126, 47);
            NewTeamAddBtn.TabIndex = 5;
            NewTeamAddBtn.Text = "Add";
            NewTeamAddBtn.UseVisualStyleBackColor = true;
            // 
            // NewTeam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(NewTeamPanel);
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