namespace Bira
{
    partial class EditTask
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
            TasksPanel = new Panel();
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
            TaskStatusComboBox = new ComboBox();
            TasksProjectComboBox = new ComboBox();
            TasksPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TasksPanel
            // 
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
            TasksPanel.Location = new Point(166, 40);
            TasksPanel.Margin = new Padding(4);
            TasksPanel.Name = "TasksPanel";
            TasksPanel.Size = new Size(896, 799);
            TasksPanel.TabIndex = 2;
            // 
            // TasksSubmitBtn
            // 
            TasksSubmitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TasksSubmitBtn.Location = new Point(341, 711);
            TasksSubmitBtn.Margin = new Padding(4);
            TasksSubmitBtn.Name = "TasksSubmitBtn";
            TasksSubmitBtn.Size = new Size(156, 71);
            TasksSubmitBtn.TabIndex = 10;
            TasksSubmitBtn.Text = "Submit";
            TasksSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // TasksStatusTxt
            // 
            TasksStatusTxt.AutoSize = true;
            TasksStatusTxt.Font = new Font("Segoe UI", 12F);
            TasksStatusTxt.Location = new Point(138, 605);
            TasksStatusTxt.Margin = new Padding(4, 0, 4, 0);
            TasksStatusTxt.Name = "TasksStatusTxt";
            TasksStatusTxt.Size = new Size(78, 32);
            TasksStatusTxt.TabIndex = 8;
            TasksStatusTxt.Text = "Status";
            // 
            // TasksPriorityComboBox
            // 
            TasksPriorityComboBox.Cursor = Cursors.Hand;
            TasksPriorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TasksPriorityComboBox.FormattingEnabled = true;
            TasksPriorityComboBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            TasksPriorityComboBox.Location = new Point(412, 506);
            TasksPriorityComboBox.Margin = new Padding(4);
            TasksPriorityComboBox.Name = "TasksPriorityComboBox";
            TasksPriorityComboBox.Size = new Size(374, 33);
            TasksPriorityComboBox.TabIndex = 7;
            // 
            // TasksPriorityTxt
            // 
            TasksPriorityTxt.AutoSize = true;
            TasksPriorityTxt.Font = new Font("Segoe UI", 12F);
            TasksPriorityTxt.Location = new Point(138, 501);
            TasksPriorityTxt.Margin = new Padding(4, 0, 4, 0);
            TasksPriorityTxt.Name = "TasksPriorityTxt";
            TasksPriorityTxt.Size = new Size(89, 32);
            TasksPriorityTxt.TabIndex = 2;
            TasksPriorityTxt.Text = "Priority";
            // 
            // TasksDesTxtBox
            // 
            TasksDesTxtBox.Font = new Font("Segoe UI", 12F);
            TasksDesTxtBox.Location = new Point(412, 340);
            TasksDesTxtBox.Margin = new Padding(4);
            TasksDesTxtBox.Multiline = true;
            TasksDesTxtBox.Name = "TasksDesTxtBox";
            TasksDesTxtBox.PlaceholderText = "Enter Your Description";
            TasksDesTxtBox.Size = new Size(374, 103);
            TasksDesTxtBox.TabIndex = 6;
            // 
            // TasksDescriptionTxt
            // 
            TasksDescriptionTxt.AutoSize = true;
            TasksDescriptionTxt.Font = new Font("Segoe UI", 12F);
            TasksDescriptionTxt.Location = new Point(138, 368);
            TasksDescriptionTxt.Margin = new Padding(4, 0, 4, 0);
            TasksDescriptionTxt.Name = "TasksDescriptionTxt";
            TasksDescriptionTxt.Size = new Size(135, 32);
            TasksDescriptionTxt.TabIndex = 5;
            TasksDescriptionTxt.Text = "Description";
            // 
            // TasksProNameTxt
            // 
            TasksProNameTxt.AutoSize = true;
            TasksProNameTxt.Font = new Font("Segoe UI", 12F);
            TasksProNameTxt.Location = new Point(138, 239);
            TasksProNameTxt.Margin = new Padding(4, 0, 4, 0);
            TasksProNameTxt.Name = "TasksProNameTxt";
            TasksProNameTxt.Size = new Size(158, 32);
            TasksProNameTxt.TabIndex = 3;
            TasksProNameTxt.Text = "Project Name";
            // 
            // TasksNameTxtBox
            // 
            TasksNameTxtBox.Font = new Font("Segoe UI", 12F);
            TasksNameTxtBox.Location = new Point(412, 142);
            TasksNameTxtBox.Margin = new Padding(4);
            TasksNameTxtBox.Name = "TasksNameTxtBox";
            TasksNameTxtBox.PlaceholderText = "Enter Task Name";
            TasksNameTxtBox.Size = new Size(374, 39);
            TasksNameTxtBox.TabIndex = 2;
            // 
            // TasksNameTxt
            // 
            TasksNameTxt.AutoSize = true;
            TasksNameTxt.Font = new Font("Segoe UI", 12F);
            TasksNameTxt.Location = new Point(138, 150);
            TasksNameTxt.Margin = new Padding(4, 0, 4, 0);
            TasksNameTxt.Name = "TasksNameTxt";
            TasksNameTxt.Size = new Size(129, 32);
            TasksNameTxt.TabIndex = 1;
            TasksNameTxt.Text = "Task Name";
            // 
            // TasksFormHeadTxt
            // 
            TasksFormHeadTxt.AutoSize = true;
            TasksFormHeadTxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            TasksFormHeadTxt.Location = new Point(375, 30);
            TasksFormHeadTxt.Margin = new Padding(4, 0, 4, 0);
            TasksFormHeadTxt.Name = "TasksFormHeadTxt";
            TasksFormHeadTxt.Size = new Size(99, 45);
            TasksFormHeadTxt.TabIndex = 0;
            TasksFormHeadTxt.Text = "Tasks";
            // 
            // TaskStatusComboBox
            // 
            TaskStatusComboBox.Cursor = Cursors.Hand;
            TaskStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TaskStatusComboBox.FormattingEnabled = true;
            TaskStatusComboBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            TaskStatusComboBox.Location = new Point(412, 608);
            TaskStatusComboBox.Margin = new Padding(4);
            TaskStatusComboBox.Name = "TaskStatusComboBox";
            TaskStatusComboBox.Size = new Size(374, 33);
            TaskStatusComboBox.TabIndex = 11;
            // 
            // TasksProjectComboBox
            // 
            TasksProjectComboBox.Cursor = Cursors.Hand;
            TasksProjectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TasksProjectComboBox.FormattingEnabled = true;
            TasksProjectComboBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            TasksProjectComboBox.Location = new Point(412, 242);
            TasksProjectComboBox.Margin = new Padding(4);
            TasksProjectComboBox.Name = "TasksProjectComboBox";
            TasksProjectComboBox.Size = new Size(374, 33);
            TasksProjectComboBox.TabIndex = 12;
            // 
            // EditTask
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 879);
            Controls.Add(TasksPanel);
            Name = "EditTask";
            Text = "EditTask";
            Load += EditTask_Load;
            TasksPanel.ResumeLayout(false);
            TasksPanel.PerformLayout();
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
    }
}