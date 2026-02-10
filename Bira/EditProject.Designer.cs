namespace Bira
{
    partial class EditProject
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
            ProjectHeadTxt = new Label();
            ProjectNameTxt = new Label();
            ProjectNameBox = new TextBox();
            StartDateTxt = new Label();
            EndDateTxt = new Label();
            DescriptionTxt = new Label();
            ProjectDescriptionBox = new TextBox();
            ProjectSubmitBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ProjectPanel = new Panel();
            endDatePicker = new DateTimePicker();
            startDatePicker = new DateTimePicker();
            panelNameUnderline = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ProjectPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ProjectHeadTxt
            // 
            ProjectHeadTxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ProjectHeadTxt.ForeColor = Color.DeepSkyBlue;
            ProjectHeadTxt.Location = new Point(0, 30);
            ProjectHeadTxt.Name = "ProjectHeadTxt";
            ProjectHeadTxt.Size = new Size(700, 45);
            ProjectHeadTxt.TabIndex = 0;
            ProjectHeadTxt.Text = "Edit Project Details";
            ProjectHeadTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProjectNameTxt
            // 
            ProjectNameTxt.AutoSize = true;
            ProjectNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProjectNameTxt.ForeColor = Color.LightGray;
            ProjectNameTxt.Location = new Point(60, 110);
            ProjectNameTxt.Name = "ProjectNameTxt";
            ProjectNameTxt.Size = new Size(169, 32);
            ProjectNameTxt.TabIndex = 1;
            ProjectNameTxt.Text = "Project Name";
            // 
            // ProjectNameBox
            // 
            ProjectNameBox.BackColor = Color.FromArgb(45, 65, 90);
            ProjectNameBox.BorderStyle = BorderStyle.None;
            ProjectNameBox.Font = new Font("Segoe UI", 12F);
            ProjectNameBox.ForeColor = Color.White;
            ProjectNameBox.Location = new Point(60, 145);
            ProjectNameBox.Name = "ProjectNameBox";
            ProjectNameBox.Size = new Size(580, 32);
            ProjectNameBox.TabIndex = 1;
            // 
            // StartDateTxt
            // 
            StartDateTxt.AutoSize = true;
            StartDateTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            StartDateTxt.ForeColor = Color.LightGray;
            StartDateTxt.Location = new Point(60, 210);
            StartDateTxt.Name = "StartDateTxt";
            StartDateTxt.Size = new Size(128, 32);
            StartDateTxt.TabIndex = 3;
            StartDateTxt.Text = "Start Date";
            // 
            // EndDateTxt
            // 
            EndDateTxt.AutoSize = true;
            EndDateTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            EndDateTxt.ForeColor = Color.LightGray;
            EndDateTxt.Location = new Point(381, 210);
            EndDateTxt.Name = "EndDateTxt";
            EndDateTxt.Size = new Size(117, 32);
            EndDateTxt.TabIndex = 6;
            EndDateTxt.Text = "End Date";
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.AutoSize = true;
            DescriptionTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DescriptionTxt.ForeColor = Color.LightGray;
            DescriptionTxt.Location = new Point(60, 310);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(146, 32);
            DescriptionTxt.TabIndex = 8;
            DescriptionTxt.Text = "Description";
            // 
            // ProjectDescriptionBox
            // 
            ProjectDescriptionBox.BackColor = Color.FromArgb(50, 50, 65);
            ProjectDescriptionBox.BorderStyle = BorderStyle.FixedSingle;
            ProjectDescriptionBox.Font = new Font("Segoe UI", 12F);
            ProjectDescriptionBox.ForeColor = Color.White;
            ProjectDescriptionBox.Location = new Point(60, 345);
            ProjectDescriptionBox.Multiline = true;
            ProjectDescriptionBox.Name = "ProjectDescriptionBox";
            ProjectDescriptionBox.Size = new Size(580, 160);
            ProjectDescriptionBox.TabIndex = 4;
            // 
            // ProjectSubmitBtn
            // 
            ProjectSubmitBtn.BackColor = Color.FromArgb(0, 98, 152);
            ProjectSubmitBtn.Cursor = Cursors.Hand;
            ProjectSubmitBtn.FlatAppearance.BorderSize = 0;
            ProjectSubmitBtn.FlatStyle = FlatStyle.Flat;
            ProjectSubmitBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            ProjectSubmitBtn.ForeColor = Color.White;
            ProjectSubmitBtn.Location = new Point(271, 550);
            ProjectSubmitBtn.Name = "ProjectSubmitBtn";
            ProjectSubmitBtn.Size = new Size(158, 59);
            ProjectSubmitBtn.TabIndex = 5;
            ProjectSubmitBtn.Text = "Update";
            ProjectSubmitBtn.UseVisualStyleBackColor = false;
            ProjectSubmitBtn.Click += ProjectSubmitBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ProjectPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1102, 750);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ProjectPanel
            // 
            ProjectPanel.Anchor = AnchorStyles.None;
            ProjectPanel.BackColor = Color.FromArgb(45, 65, 90);
            ProjectPanel.Controls.Add(endDatePicker);
            ProjectPanel.Controls.Add(startDatePicker);
            ProjectPanel.Controls.Add(panelNameUnderline);
            ProjectPanel.Controls.Add(ProjectSubmitBtn);
            ProjectPanel.Controls.Add(ProjectDescriptionBox);
            ProjectPanel.Controls.Add(DescriptionTxt);
            ProjectPanel.Controls.Add(EndDateTxt);
            ProjectPanel.Controls.Add(StartDateTxt);
            ProjectPanel.Controls.Add(ProjectNameBox);
            ProjectPanel.Controls.Add(ProjectNameTxt);
            ProjectPanel.Controls.Add(ProjectHeadTxt);
            ProjectPanel.Location = new Point(201, 45);
            ProjectPanel.Name = "ProjectPanel";
            ProjectPanel.Size = new Size(700, 660);
            ProjectPanel.TabIndex = 0;
            // 
            // endDatePicker
            // 
            endDatePicker.CalendarFont = new Font("Segoe UI", 10F);
            endDatePicker.CalendarForeColor = Color.White;
            endDatePicker.CalendarMonthBackground = Color.FromArgb(45, 65, 90);
            endDatePicker.CalendarTitleBackColor = Color.DeepSkyBlue;
            endDatePicker.CustomFormat = "yyyy-MM-dd";
            endDatePicker.Font = new Font("Segoe UI", 12F);
            endDatePicker.Format = DateTimePickerFormat.Custom;
            endDatePicker.Location = new Point(381, 245);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(259, 39);
            endDatePicker.TabIndex = 3;
            // 
            // startDatePicker
            // 
            startDatePicker.CalendarFont = new Font("Segoe UI", 10F);
            startDatePicker.CalendarForeColor = Color.White;
            startDatePicker.CalendarMonthBackground = Color.FromArgb(45, 65, 90);
            startDatePicker.CalendarTitleBackColor = Color.DeepSkyBlue;
            startDatePicker.CustomFormat = "yyyy-MM-dd";
            startDatePicker.Font = new Font("Segoe UI", 12F);
            startDatePicker.Format = DateTimePickerFormat.Custom;
            startDatePicker.Location = new Point(60, 245);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(259, 39);
            startDatePicker.TabIndex = 2;
            // 
            // panelNameUnderline
            // 
            panelNameUnderline.BackColor = Color.DeepSkyBlue;
            panelNameUnderline.Location = new Point(60, 180);
            panelNameUnderline.Name = "panelNameUnderline";
            panelNameUnderline.Size = new Size(580, 2);
            panelNameUnderline.TabIndex = 11;
            // 
            // EditProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 40, 55);
            ClientSize = new Size(1102, 750);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProject";
            Text = "EditProject";
            tableLayoutPanel1.ResumeLayout(false);
            ProjectPanel.ResumeLayout(false);
            ProjectPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label ProjectHeadTxt;
        private Label ProjectNameTxt;
        private TextBox ProjectNameBox;
        private Label StartDateTxt;
        private Label EndDateTxt;
        private Label DescriptionTxt;
        private TextBox ProjectDescriptionBox;
        private Button ProjectSubmitBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel ProjectPanel;
        private Panel panelNameUnderline;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
    }
}