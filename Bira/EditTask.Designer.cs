namespace Bira
{
    partial class EditTask
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
            TasksPanel = new Panel();
            panelTaskNameUnderline = new Panel();
            TasksProjectComboBox = new ComboBox();
            TaskStatusComboBox = new ComboBox();
            TasksSubmitBtn = new Button();
            TasksStatusTxt = new Label();
            TasksPriorityComboBox = new ComboBox();
            TasksPriorityTxt = new Label();
            TasksDesTxtBox = new TextBox();
            TasksDescriptionTxt = new Label();
            TasksProNameTxt = new Label();
            TasksNameTxtBox = new TextBox();
            TasksNameTxt = new Label();
            TasksFormHeadTxt = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            TasksPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TasksPanel
            // 
            TasksPanel.Anchor = AnchorStyles.None;
            TasksPanel.BackColor = Color.FromArgb(45, 65, 90);
            TasksPanel.Controls.Add(panelTaskNameUnderline);
            TasksPanel.Controls.Add(TasksProjectComboBox);
            TasksPanel.Controls.Add(TaskStatusComboBox);
            TasksPanel.Controls.Add(TasksSubmitBtn);
            TasksPanel.Controls.Add(TasksStatusTxt);
            TasksPanel.Controls.Add(TasksPriorityComboBox);
            TasksPanel.Controls.Add(TasksPriorityTxt);
            TasksPanel.Controls.Add(TasksDesTxtBox);
            TasksPanel.Controls.Add(TasksDescriptionTxt);
            TasksPanel.Controls.Add(TasksProNameTxt);
            TasksPanel.Controls.Add(TasksNameTxtBox);
            TasksPanel.Controls.Add(TasksNameTxt);
            TasksPanel.Controls.Add(TasksFormHeadTxt);
            TasksPanel.Location = new Point(201, 25);
            TasksPanel.Name = "TasksPanel";
            TasksPanel.Size = new Size(700, 700);
            TasksPanel.TabIndex = 2;
            // 
            // panelTaskNameUnderline
            // 
            panelTaskNameUnderline.BackColor = Color.DeepSkyBlue;
            panelTaskNameUnderline.Location = new Point(80, 180);
            panelTaskNameUnderline.Name = "panelTaskNameUnderline";
            panelTaskNameUnderline.Size = new Size(540, 2);
            panelTaskNameUnderline.TabIndex = 12;
            // 
            // TasksProjectComboBox
            // 
            TasksProjectComboBox.BackColor = Color.FromArgb(50, 50, 65);
            TasksProjectComboBox.Cursor = Cursors.Hand;
            TasksProjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TasksProjectComboBox.FlatStyle = FlatStyle.Flat;
            TasksProjectComboBox.Font = new Font("Segoe UI", 12F);
            TasksProjectComboBox.ForeColor = Color.White;
            TasksProjectComboBox.FormattingEnabled = true;
            TasksProjectComboBox.Location = new Point(80, 215);
            TasksProjectComboBox.Name = "TasksProjectComboBox";
            TasksProjectComboBox.Size = new Size(540, 40);
            TasksProjectComboBox.TabIndex = 2;
            // 
            // TaskStatusComboBox
            // 
            TaskStatusComboBox.BackColor = Color.FromArgb(50, 50, 65);
            TaskStatusComboBox.Cursor = Cursors.Hand;
            TaskStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TaskStatusComboBox.FlatStyle = FlatStyle.Flat;
            TaskStatusComboBox.Font = new Font("Segoe UI", 12F);
            TaskStatusComboBox.ForeColor = Color.White;
            TaskStatusComboBox.FormattingEnabled = true;
            TaskStatusComboBox.Location = new Point(80, 525);
            TaskStatusComboBox.Name = "TaskStatusComboBox";
            TaskStatusComboBox.Size = new Size(540, 40);
            TaskStatusComboBox.TabIndex = 5;
            // 
            // TasksSubmitBtn
            // 
            TasksSubmitBtn.BackColor = Color.FromArgb(0, 98, 152);
            TasksSubmitBtn.Cursor = Cursors.Hand;
            TasksSubmitBtn.FlatAppearance.BorderSize = 0;
            TasksSubmitBtn.FlatStyle = FlatStyle.Flat;
            TasksSubmitBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TasksSubmitBtn.ForeColor = Color.White;
            TasksSubmitBtn.Location = new Point(271, 600);
            TasksSubmitBtn.Name = "TasksSubmitBtn";
            TasksSubmitBtn.Size = new Size(158, 59);
            TasksSubmitBtn.TabIndex = 6;
            TasksSubmitBtn.Text = "Update";
            TasksSubmitBtn.UseVisualStyleBackColor = false;
            TasksSubmitBtn.Click += UpdateButton_Click;
            // 
            // TasksStatusTxt
            // 
            TasksStatusTxt.AutoSize = true;
            TasksStatusTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TasksStatusTxt.ForeColor = Color.LightGray;
            TasksStatusTxt.Location = new Point(75, 490);
            TasksStatusTxt.Name = "TasksStatusTxt";
            TasksStatusTxt.Size = new Size(83, 32);
            TasksStatusTxt.TabIndex = 8;
            TasksStatusTxt.Text = "Status";
            // 
            // TasksPriorityComboBox
            // 
            TasksPriorityComboBox.BackColor = Color.FromArgb(50, 50, 65);
            TasksPriorityComboBox.Cursor = Cursors.Hand;
            TasksPriorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TasksPriorityComboBox.FlatStyle = FlatStyle.Flat;
            TasksPriorityComboBox.Font = new Font("Segoe UI", 12F);
            TasksPriorityComboBox.ForeColor = Color.White;
            TasksPriorityComboBox.FormattingEnabled = true;
            TasksPriorityComboBox.Location = new Point(80, 435);
            TasksPriorityComboBox.Name = "TasksPriorityComboBox";
            TasksPriorityComboBox.Size = new Size(540, 40);
            TasksPriorityComboBox.TabIndex = 4;
            // 
            // TasksPriorityTxt
            // 
            TasksPriorityTxt.AutoSize = true;
            TasksPriorityTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TasksPriorityTxt.ForeColor = Color.LightGray;
            TasksPriorityTxt.Location = new Point(75, 400);
            TasksPriorityTxt.Name = "TasksPriorityTxt";
            TasksPriorityTxt.Size = new Size(100, 32);
            TasksPriorityTxt.TabIndex = 2;
            TasksPriorityTxt.Text = "Priority";
            // 
            // TasksDesTxtBox
            // 
            TasksDesTxtBox.BackColor = Color.FromArgb(50, 50, 65);
            TasksDesTxtBox.BorderStyle = BorderStyle.FixedSingle;
            TasksDesTxtBox.Font = new Font("Segoe UI", 12F);
            TasksDesTxtBox.ForeColor = Color.White;
            TasksDesTxtBox.Location = new Point(80, 305);
            TasksDesTxtBox.Multiline = true;
            TasksDesTxtBox.Name = "TasksDesTxtBox";
            TasksDesTxtBox.Size = new Size(540, 80);
            TasksDesTxtBox.TabIndex = 3;
            // 
            // TasksDescriptionTxt
            // 
            TasksDescriptionTxt.AutoSize = true;
            TasksDescriptionTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TasksDescriptionTxt.ForeColor = Color.LightGray;
            TasksDescriptionTxt.Location = new Point(75, 270);
            TasksDescriptionTxt.Name = "TasksDescriptionTxt";
            TasksDescriptionTxt.Size = new Size(146, 32);
            TasksDescriptionTxt.TabIndex = 5;
            TasksDescriptionTxt.Text = "Description";
            // 
            // TasksProNameTxt
            // 
            TasksProNameTxt.AutoSize = true;
            TasksProNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TasksProNameTxt.ForeColor = Color.LightGray;
            TasksProNameTxt.Location = new Point(75, 185);
            TasksProNameTxt.Name = "TasksProNameTxt";
            TasksProNameTxt.Size = new Size(169, 32);
            TasksProNameTxt.TabIndex = 3;
            TasksProNameTxt.Text = "Project Name";
            // 
            // TasksNameTxtBox
            // 
            TasksNameTxtBox.BackColor = Color.FromArgb(45, 65, 90);
            TasksNameTxtBox.BorderStyle = BorderStyle.None;
            TasksNameTxtBox.Font = new Font("Segoe UI", 12F);
            TasksNameTxtBox.ForeColor = Color.White;
            TasksNameTxtBox.Location = new Point(80, 145);
            TasksNameTxtBox.Name = "TasksNameTxtBox";
            TasksNameTxtBox.Size = new Size(540, 32);
            TasksNameTxtBox.TabIndex = 1;
            // 
            // TasksNameTxt
            // 
            TasksNameTxt.AutoSize = true;
            TasksNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TasksNameTxt.ForeColor = Color.LightGray;
            TasksNameTxt.Location = new Point(75, 110);
            TasksNameTxt.Name = "TasksNameTxt";
            TasksNameTxt.Size = new Size(137, 32);
            TasksNameTxt.TabIndex = 1;
            TasksNameTxt.Text = "Task Name";
            // 
            // TasksFormHeadTxt
            // 
            TasksFormHeadTxt.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            TasksFormHeadTxt.ForeColor = Color.DeepSkyBlue;
            TasksFormHeadTxt.Location = new Point(0, 30);
            TasksFormHeadTxt.Name = "TasksFormHeadTxt";
            TasksFormHeadTxt.Size = new Size(700, 45);
            TasksFormHeadTxt.TabIndex = 0;
            TasksFormHeadTxt.Text = "Edit Task Details";
            TasksFormHeadTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(TasksPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1102, 750);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // EditTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 40, 55);
            ClientSize = new Size(1102, 750);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditTask";
            Text = "EditTask";
            TasksPanel.ResumeLayout(false);
            TasksPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TasksPanel;
        private Button TasksSubmitBtn;
        private Label TasksStatusTxt;
        private ComboBox TasksPriorityComboBox;
        private Label TasksPriorityTxt;
        private TextBox TasksDesTxtBox;
        private Label TasksDescriptionTxt;
        private Label TasksProNameTxt;
        private TextBox TasksNameTxtBox;
        private Label TasksNameTxt;
        private Label TasksFormHeadTxt;
        private ComboBox TasksProjectComboBox;
        private ComboBox TaskStatusComboBox;
        private Panel panelTaskNameUnderline;
        private TableLayoutPanel tableLayoutPanel1;
    }
}