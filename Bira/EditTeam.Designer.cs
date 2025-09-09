namespace Bira
{
    partial class EditTeam
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
            EditTeamAddBtn = new Button();
            EditTeamTxtBox = new TextBox();
            NewTeamTxt = new Label();
            EditTeamHeadTxt = new Label();
            NewTeamDesTxt = new Label();
            EditTeamDesTxtBox = new TextBox();
            NewTeamPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NewTeamPanel
            // 
            NewTeamPanel.Controls.Add(EditTeamAddBtn);
            NewTeamPanel.Controls.Add(EditTeamDesTxtBox);
            NewTeamPanel.Controls.Add(NewTeamDesTxt);
            NewTeamPanel.Controls.Add(EditTeamTxtBox);
            NewTeamPanel.Controls.Add(NewTeamTxt);
            NewTeamPanel.Controls.Add(EditTeamHeadTxt);
            NewTeamPanel.Dock = DockStyle.Fill;
            NewTeamPanel.Location = new Point(0, 0);
            NewTeamPanel.Margin = new Padding(5);
            NewTeamPanel.Name = "NewTeamPanel";
            NewTeamPanel.Size = new Size(1278, 864);
            NewTeamPanel.TabIndex = 1;
            NewTeamPanel.Paint += NewTeamPanel_Paint;
            // 
            // EditTeamAddBtn
            // 
            EditTeamAddBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            EditTeamAddBtn.Location = new Point(674, 754);
            EditTeamAddBtn.Margin = new Padding(5);
            EditTeamAddBtn.Name = "EditTeamAddBtn";
            EditTeamAddBtn.Size = new Size(205, 74);
            EditTeamAddBtn.TabIndex = 5;
            EditTeamAddBtn.Text = "Save Changes";
            EditTeamAddBtn.UseVisualStyleBackColor = true;
            EditTeamAddBtn.Click += NewTeamAddBtn_Click;
            // 
            // EditTeamTxtBox
            // 
            EditTeamTxtBox.Font = new Font("Segoe UI", 12F);
            EditTeamTxtBox.Location = new Point(367, 119);
            EditTeamTxtBox.Margin = new Padding(5);
            EditTeamTxtBox.Name = "EditTeamTxtBox";
            EditTeamTxtBox.PlaceholderText = "Team Name";
            EditTeamTxtBox.Size = new Size(393, 39);
            EditTeamTxtBox.TabIndex = 2;
            EditTeamTxtBox.TextChanged += EditTeamTxtBox_TextChanged;
            // 
            // NewTeamTxt
            // 
            NewTeamTxt.AutoSize = true;
            NewTeamTxt.Font = new Font("Segoe UI", 12F);
            NewTeamTxt.Location = new Point(112, 123);
            NewTeamTxt.Margin = new Padding(5, 0, 5, 0);
            NewTeamTxt.Name = "NewTeamTxt";
            NewTeamTxt.Size = new Size(142, 32);
            NewTeamTxt.TabIndex = 1;
            NewTeamTxt.Text = "Team Name";
            NewTeamTxt.Click += NewTeamTxt_Click;
            // 
            // EditTeamHeadTxt
            // 
            EditTeamHeadTxt.AutoSize = true;
            EditTeamHeadTxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            EditTeamHeadTxt.Location = new Point(309, 9);
            EditTeamHeadTxt.Margin = new Padding(5, 0, 5, 0);
            EditTeamHeadTxt.Name = "EditTeamHeadTxt";
            EditTeamHeadTxt.Size = new Size(166, 45);
            EditTeamHeadTxt.TabIndex = 0;
            EditTeamHeadTxt.Text = "Edit Team";
            // 
            // NewTeamDesTxt
            // 
            NewTeamDesTxt.AutoSize = true;
            NewTeamDesTxt.Font = new Font("Segoe UI", 12F);
            NewTeamDesTxt.Location = new Point(112, 258);
            NewTeamDesTxt.Margin = new Padding(5, 0, 5, 0);
            NewTeamDesTxt.Name = "NewTeamDesTxt";
            NewTeamDesTxt.Size = new Size(135, 32);
            NewTeamDesTxt.TabIndex = 3;
            NewTeamDesTxt.Text = "Description";
            NewTeamDesTxt.Click += NewTeamDesTxt_Click;
            // 
            // EditTeamDesTxtBox
            // 
            EditTeamDesTxtBox.Font = new Font("Segoe UI", 12F);
            EditTeamDesTxtBox.Location = new Point(367, 217);
            EditTeamDesTxtBox.Margin = new Padding(5);
            EditTeamDesTxtBox.Multiline = true;
            EditTeamDesTxtBox.Name = "EditTeamDesTxtBox";
            EditTeamDesTxtBox.PlaceholderText = "Description";
            EditTeamDesTxtBox.Size = new Size(393, 131);
            EditTeamDesTxtBox.TabIndex = 4;
            EditTeamDesTxtBox.TextChanged += EditTeamDesTxtBox_TextChanged;
            // 
            // EditTeam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 864);
            Controls.Add(NewTeamPanel);
            Margin = new Padding(4);
            Name = "EditTeam";
            Text = "Edit Team";
            Load += EditTeam_Load;
            NewTeamPanel.ResumeLayout(false);
            NewTeamPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        // CORRECTED: Field names now match the ones used in InitializeComponent.
        private System.Windows.Forms.Panel NewTeamPanel;
        private System.Windows.Forms.Button EditTeamAddBtn;
        private System.Windows.Forms.TextBox EditTeamTxtBox;
        private System.Windows.Forms.Label NewTeamTxt;
        private System.Windows.Forms.Label EditTeamHeadTxt;

        // ADDED: Empty event handlers to prevent compilation errors.
        private void NewTeamPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e) { /* TODO: Implement logic */ }
        private void NewTeamAddBtn_Click(object sender, System.EventArgs e) { /* TODO: Implement logic */ }
        private void EditTeamDesTxtBox_TextChanged(object sender, System.EventArgs e) { /* TODO: Implement logic */ }
        private void NewTeamDesTxt_Click(object sender, System.EventArgs e) { /* TODO: Implement logic */ }
        private void EditTeamTxtBox_TextChanged(object sender, System.EventArgs e) { /* TODO: Implement logic */ }
        private void NewTeamTxt_Click(object sender, System.EventArgs e) { /* TODO: Implement logic */ }
        private TextBox EditTeamDesTxtBox;
        private Label NewTeamDesTxt;
        //  private void NewTeamHeadTxt_Click(object sender, System.EventArgs e) { /* TODO: Implement logic */ }
    }
}
