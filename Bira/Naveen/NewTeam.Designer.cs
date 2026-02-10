namespace Bira.Naveen
{
    partial class NewTeam
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
            NewTeamPanel = new Panel();
            panelTeamNameUnderline = new Panel();
            NewTeamAddBtn = new Button();
            NewTeamDesTxtBox = new TextBox();
            NewTeamDesTxt = new Label();
            NewTeamTxtBox = new TextBox();
            NewTeamTxt = new Label();
            NewTeamHeadTxt = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            NewTeamPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // NewTeamPanel
            // 
            NewTeamPanel.Anchor = AnchorStyles.None;
            NewTeamPanel.BackColor = Color.FromArgb(45, 65, 90);
            NewTeamPanel.Controls.Add(panelTeamNameUnderline);
            NewTeamPanel.Controls.Add(NewTeamAddBtn);
            NewTeamPanel.Controls.Add(NewTeamDesTxtBox);
            NewTeamPanel.Controls.Add(NewTeamDesTxt);
            NewTeamPanel.Controls.Add(NewTeamTxtBox);
            NewTeamPanel.Controls.Add(NewTeamTxt);
            NewTeamPanel.Controls.Add(NewTeamHeadTxt);
            NewTeamPanel.Location = new Point(207, 45);
            NewTeamPanel.Margin = new Padding(4);
            NewTeamPanel.Name = "NewTeamPanel";
            NewTeamPanel.Size = new Size(688, 600);
            NewTeamPanel.TabIndex = 0;
            // 
            // panelTeamNameUnderline
            // 
            panelTeamNameUnderline.BackColor = Color.DeepSkyBlue;
            panelTeamNameUnderline.Location = new Point(81, 196);
            panelTeamNameUnderline.Name = "panelTeamNameUnderline";
            panelTeamNameUnderline.Size = new Size(527, 2);
            panelTeamNameUnderline.TabIndex = 6;
            // 
            // NewTeamAddBtn
            // 
            NewTeamAddBtn.BackColor = Color.FromArgb(0, 98, 152);
            NewTeamAddBtn.Cursor = Cursors.Hand;
            NewTeamAddBtn.FlatAppearance.BorderSize = 0;
            NewTeamAddBtn.FlatStyle = FlatStyle.Flat;
            NewTeamAddBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            NewTeamAddBtn.ForeColor = Color.White;
            NewTeamAddBtn.Location = new Point(265, 490);
            NewTeamAddBtn.Margin = new Padding(4);
            NewTeamAddBtn.Name = "NewTeamAddBtn";
            NewTeamAddBtn.Size = new Size(158, 59);
            NewTeamAddBtn.TabIndex = 3;
            NewTeamAddBtn.Text = "Add Team";
            NewTeamAddBtn.UseVisualStyleBackColor = false;
            NewTeamAddBtn.Click += NewTeamAddBtn_Click;
            // 
            // NewTeamDesTxtBox
            // 
            NewTeamDesTxtBox.BackColor = Color.FromArgb(50, 50, 65);
            NewTeamDesTxtBox.BorderStyle = BorderStyle.FixedSingle;
            NewTeamDesTxtBox.Font = new Font("Segoe UI", 12F);
            NewTeamDesTxtBox.ForeColor = Color.White;
            NewTeamDesTxtBox.Location = new Point(81, 280);
            NewTeamDesTxtBox.Margin = new Padding(4);
            NewTeamDesTxtBox.Multiline = true;
            NewTeamDesTxtBox.Name = "NewTeamDesTxtBox";
            NewTeamDesTxtBox.Size = new Size(527, 160);
            NewTeamDesTxtBox.TabIndex = 2;
            // 
            // NewTeamDesTxt
            // 
            NewTeamDesTxt.AutoSize = true;
            NewTeamDesTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NewTeamDesTxt.ForeColor = Color.LightGray;
            NewTeamDesTxt.Location = new Point(81, 244);
            NewTeamDesTxt.Margin = new Padding(4, 0, 4, 0);
            NewTeamDesTxt.Name = "NewTeamDesTxt";
            NewTeamDesTxt.Size = new Size(146, 32);
            NewTeamDesTxt.TabIndex = 3;
            NewTeamDesTxt.Text = "Description";
            // 
            // NewTeamTxtBox
            // 
            NewTeamTxtBox.BackColor = Color.FromArgb(45, 65, 90);
            NewTeamTxtBox.BorderStyle = BorderStyle.None;
            NewTeamTxtBox.Font = new Font("Segoe UI", 12F);
            NewTeamTxtBox.ForeColor = Color.White;
            NewTeamTxtBox.Location = new Point(81, 161);
            NewTeamTxtBox.Margin = new Padding(4);
            NewTeamTxtBox.Name = "NewTeamTxtBox";
            NewTeamTxtBox.Size = new Size(527, 32);
            NewTeamTxtBox.TabIndex = 1;
            // 
            // NewTeamTxt
            // 
            NewTeamTxt.AutoSize = true;
            NewTeamTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NewTeamTxt.ForeColor = Color.LightGray;
            NewTeamTxt.Location = new Point(81, 125);
            NewTeamTxt.Margin = new Padding(4, 0, 4, 0);
            NewTeamTxt.Name = "NewTeamTxt";
            NewTeamTxt.Size = new Size(148, 32);
            NewTeamTxt.TabIndex = 1;
            NewTeamTxt.Text = "Team Name";
            // 
            // NewTeamHeadTxt
            // 
            NewTeamHeadTxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            NewTeamHeadTxt.ForeColor = Color.DeepSkyBlue;
            NewTeamHeadTxt.Location = new Point(4, 35);
            NewTeamHeadTxt.Margin = new Padding(4, 0, 4, 0);
            NewTeamHeadTxt.Name = "NewTeamHeadTxt";
            NewTeamHeadTxt.Size = new Size(680, 55);
            NewTeamHeadTxt.TabIndex = 0;
            NewTeamHeadTxt.Text = "Create a New Team";
            NewTeamHeadTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(NewTeamPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1102, 691);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // NewTeam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 40, 55);
            ClientSize = new Size(1102, 691);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "NewTeam";
            Text = "NewTeam";
            NewTeamPanel.ResumeLayout(false);
            NewTeamPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
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
        private Panel panelTeamNameUnderline;
        private TableLayoutPanel tableLayoutPanel1;
    }
}