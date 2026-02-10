namespace Bira
{
    partial class EditTeam
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
            panelNameUnderline = new Panel();
            labelNonTeamMembers = new Label();
            labelTeamMembers = new Label();
            panelNonTeamMembers = new FlowLayoutPanel();
            panelTeamMembers = new FlowLayoutPanel();
            EditTeamAddBtn = new Button();
            EditTeamDesTxtBox = new TextBox();
            NewTeamDesTxt = new Label();
            EditTeamTxtBox = new TextBox();
            NewTeamTxt = new Label();
            EditTeamHeadTxt = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            NewTeamPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // NewTeamPanel
            // 
            NewTeamPanel.Anchor = AnchorStyles.None;
            NewTeamPanel.BackColor = Color.FromArgb(45, 65, 90);
            NewTeamPanel.Controls.Add(panelNameUnderline);
            NewTeamPanel.Controls.Add(labelNonTeamMembers);
            NewTeamPanel.Controls.Add(labelTeamMembers);
            NewTeamPanel.Controls.Add(panelNonTeamMembers);
            NewTeamPanel.Controls.Add(panelTeamMembers);
            NewTeamPanel.Controls.Add(EditTeamAddBtn);
            NewTeamPanel.Controls.Add(EditTeamDesTxtBox);
            NewTeamPanel.Controls.Add(NewTeamDesTxt);
            NewTeamPanel.Controls.Add(EditTeamTxtBox);
            NewTeamPanel.Controls.Add(NewTeamTxt);
            NewTeamPanel.Controls.Add(EditTeamHeadTxt);
            NewTeamPanel.Location = new Point(139, 25);
            NewTeamPanel.Name = "NewTeamPanel";
            NewTeamPanel.Size = new Size(1000, 800);
            NewTeamPanel.TabIndex = 1;
            // 
            // panelNameUnderline
            // 
            panelNameUnderline.BackColor = Color.DeepSkyBlue;
            panelNameUnderline.Location = new Point(80, 160);
            panelNameUnderline.Name = "panelNameUnderline";
            panelNameUnderline.Size = new Size(840, 2);
            panelNameUnderline.TabIndex = 10;
            // 
            // labelNonTeamMembers
            // 
            labelNonTeamMembers.AutoSize = true;
            labelNonTeamMembers.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelNonTeamMembers.ForeColor = Color.LightGray;
            labelNonTeamMembers.Location = new Point(550, 290);
            labelNonTeamMembers.Name = "labelNonTeamMembers";
            labelNonTeamMembers.Size = new Size(137, 38);
            labelNonTeamMembers.TabIndex = 9;
            labelNonTeamMembers.Text = "Add User";
            // 
            // labelTeamMembers
            // 
            labelTeamMembers.AutoSize = true;
            labelTeamMembers.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTeamMembers.ForeColor = Color.LightGray;
            labelTeamMembers.Location = new Point(80, 290);
            labelTeamMembers.Name = "labelTeamMembers";
            labelTeamMembers.Size = new Size(193, 38);
            labelTeamMembers.TabIndex = 8;
            labelTeamMembers.Text = "Current Team";
            // 
            // panelNonTeamMembers
            // 
            panelNonTeamMembers.AutoScroll = true;
            panelNonTeamMembers.BackColor = Color.FromArgb(4, 40, 55);
            panelNonTeamMembers.FlowDirection = FlowDirection.TopDown;
            panelNonTeamMembers.Location = new Point(550, 330);
            panelNonTeamMembers.Name = "panelNonTeamMembers";
            panelNonTeamMembers.Padding = new Padding(5);
            panelNonTeamMembers.Size = new Size(370, 350);
            panelNonTeamMembers.TabIndex = 7;
            panelNonTeamMembers.WrapContents = false;
            // 
            // panelTeamMembers
            // 
            panelTeamMembers.AutoScroll = true;
            panelTeamMembers.BackColor = Color.FromArgb(4, 40, 55);
            panelTeamMembers.FlowDirection = FlowDirection.TopDown;
            panelTeamMembers.Location = new Point(80, 330);
            panelTeamMembers.Name = "panelTeamMembers";
            panelTeamMembers.Padding = new Padding(5);
            panelTeamMembers.Size = new Size(370, 350);
            panelTeamMembers.TabIndex = 6;
            panelTeamMembers.WrapContents = false;
            // 
            // EditTeamAddBtn
            // 
            EditTeamAddBtn.BackColor = Color.FromArgb(0, 98, 152);
            EditTeamAddBtn.Cursor = Cursors.Hand;
            EditTeamAddBtn.FlatAppearance.BorderSize = 0;
            EditTeamAddBtn.FlatStyle = FlatStyle.Flat;
            EditTeamAddBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            EditTeamAddBtn.ForeColor = Color.White;
            EditTeamAddBtn.Location = new Point(421, 710);
            EditTeamAddBtn.Name = "EditTeamAddBtn";
            EditTeamAddBtn.Size = new Size(158, 59);
            EditTeamAddBtn.TabIndex = 5;
            EditTeamAddBtn.Text = "Save";
            EditTeamAddBtn.UseVisualStyleBackColor = false;
            EditTeamAddBtn.Click += SaveButton_Click;
            // 
            // EditTeamDesTxtBox
            // 
            EditTeamDesTxtBox.BackColor = Color.FromArgb(50, 50, 65);
            EditTeamDesTxtBox.BorderStyle = BorderStyle.FixedSingle;
            EditTeamDesTxtBox.Font = new Font("Segoe UI", 12F);
            EditTeamDesTxtBox.ForeColor = Color.White;
            EditTeamDesTxtBox.Location = new Point(80, 205);
            EditTeamDesTxtBox.Name = "EditTeamDesTxtBox";
            EditTeamDesTxtBox.Size = new Size(840, 39);
            EditTeamDesTxtBox.TabIndex = 4;
            // 
            // NewTeamDesTxt
            // 
            NewTeamDesTxt.AutoSize = true;
            NewTeamDesTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NewTeamDesTxt.ForeColor = Color.LightGray;
            NewTeamDesTxt.Location = new Point(80, 170);
            NewTeamDesTxt.Name = "NewTeamDesTxt";
            NewTeamDesTxt.Size = new Size(134, 32);
            NewTeamDesTxt.TabIndex = 3;
            NewTeamDesTxt.Text = "Team Lead";
            // 
            // EditTeamTxtBox
            // 
            EditTeamTxtBox.BackColor = Color.FromArgb(45, 65, 90);
            EditTeamTxtBox.BorderStyle = BorderStyle.None;
            EditTeamTxtBox.Font = new Font("Segoe UI", 12F);
            EditTeamTxtBox.ForeColor = Color.White;
            EditTeamTxtBox.Location = new Point(80, 125);
            EditTeamTxtBox.Name = "EditTeamTxtBox";
            EditTeamTxtBox.Size = new Size(840, 32);
            EditTeamTxtBox.TabIndex = 2;
            // 
            // NewTeamTxt
            // 
            NewTeamTxt.AutoSize = true;
            NewTeamTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            NewTeamTxt.ForeColor = Color.LightGray;
            NewTeamTxt.Location = new Point(80, 90);
            NewTeamTxt.Name = "NewTeamTxt";
            NewTeamTxt.Size = new Size(148, 32);
            NewTeamTxt.TabIndex = 1;
            NewTeamTxt.Text = "Team Name";
            // 
            // EditTeamHeadTxt
            // 
            EditTeamHeadTxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            EditTeamHeadTxt.ForeColor = Color.DeepSkyBlue;
            EditTeamHeadTxt.Location = new Point(0, 25);
            EditTeamHeadTxt.Name = "EditTeamHeadTxt";
            EditTeamHeadTxt.Size = new Size(1000, 45);
            EditTeamHeadTxt.TabIndex = 0;
            EditTeamHeadTxt.Text = "Edit Team";
            EditTeamHeadTxt.TextAlign = ContentAlignment.MiddleCenter;
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
            tableLayoutPanel1.Size = new Size(1278, 850);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // EditTeam
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 40, 55);
            ClientSize = new Size(1278, 850);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditTeam";
            Text = "Edit Team";
            NewTeamPanel.ResumeLayout(false);
            NewTeamPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel NewTeamPanel;
        private Button EditTeamAddBtn;
        private TextBox EditTeamDesTxtBox;
        private Label NewTeamDesTxt;
        private TextBox EditTeamTxtBox;
        private Label NewTeamTxt;
        private Label EditTeamHeadTxt;
        private FlowLayoutPanel panelNonTeamMembers;
        private FlowLayoutPanel panelTeamMembers;
        private Label labelNonTeamMembers;
        private Label labelTeamMembers;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelNameUnderline;
    }
}