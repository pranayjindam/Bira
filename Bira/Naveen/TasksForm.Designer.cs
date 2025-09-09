namespace Bira.Naveen
{
    partial class TasksForm
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
            TasksFormHeadTxt = new Label();
            TasksPanel = new Panel();
            TasksSubmitBtn = new Button();
            TasksStatusComboBox = new ComboBox();
            TasksStatusTxt = new Label();
            TasksPriorityComboBox = new ComboBox();
            TasksPriorityTxt = new Label();
            TasksDesTxtBox = new TextBox();
            TasksDescriptionTxt = new Label();
            TasksProjectNameComboBox = new ComboBox();
            TasksProNameTxt = new Label();
            TasksNameTxtBox = new TextBox();
            TasksNameTxt = new Label();
            TasksPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TasksFormHeadTxt
            // 
            TasksFormHeadTxt.AutoSize = true;
            TasksFormHeadTxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            TasksFormHeadTxt.Location = new Point(300, 24);
            TasksFormHeadTxt.Name = "TasksFormHeadTxt";
            TasksFormHeadTxt.Size = new Size(85, 37);
            TasksFormHeadTxt.TabIndex = 0;
            TasksFormHeadTxt.Text = "Tasks";
            // 
            // TasksPanel
            // 
            TasksPanel.Controls.Add(TasksSubmitBtn);
            TasksPanel.Controls.Add(TasksStatusComboBox);
            TasksPanel.Controls.Add(TasksStatusTxt);
            TasksPanel.Controls.Add(TasksPriorityComboBox);
            TasksPanel.Controls.Add(TasksPriorityTxt);
            TasksPanel.Controls.Add(TasksDesTxtBox);
            TasksPanel.Controls.Add(TasksDescriptionTxt);
            TasksPanel.Controls.Add(TasksProjectNameComboBox);
            TasksPanel.Controls.Add(TasksProNameTxt);
            TasksPanel.Controls.Add(TasksNameTxtBox);
            TasksPanel.Controls.Add(TasksNameTxt);
            TasksPanel.Controls.Add(TasksFormHeadTxt);
            TasksPanel.Location = new Point(141, 27);
            TasksPanel.Name = "TasksPanel";
            TasksPanel.Size = new Size(717, 639);
            TasksPanel.TabIndex = 1;
            // 
            // TasksSubmitBtn
            // 
            TasksSubmitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TasksSubmitBtn.Location = new Point(273, 569);
            TasksSubmitBtn.Name = "TasksSubmitBtn";
            TasksSubmitBtn.Size = new Size(125, 57);
            TasksSubmitBtn.TabIndex = 10;
            TasksSubmitBtn.Text = "Submit";
            TasksSubmitBtn.UseVisualStyleBackColor = true;
            TasksSubmitBtn.Click += TasksSubmitBtn_Click;
            // 
            // TasksStatusComboBox
            // 
            TasksStatusComboBox.Cursor = Cursors.Hand;
            TasksStatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TasksStatusComboBox.FormattingEnabled = true;
            TasksStatusComboBox.Items.AddRange(new object[] { "To do", "In Progress", "Done" });
            TasksStatusComboBox.Location = new Point(330, 488);
            TasksStatusComboBox.Name = "TasksStatusComboBox";
            TasksStatusComboBox.Size = new Size(300, 28);
            TasksStatusComboBox.TabIndex = 9;
            // 
            // TasksStatusTxt
            // 
            TasksStatusTxt.AutoSize = true;
            TasksStatusTxt.Font = new Font("Segoe UI", 12F);
            TasksStatusTxt.Location = new Point(110, 484);
            TasksStatusTxt.Name = "TasksStatusTxt";
            TasksStatusTxt.Size = new Size(65, 28);
            TasksStatusTxt.TabIndex = 8;
            TasksStatusTxt.Text = "Status";
            // 
            // TasksPriorityComboBox
            // 
            TasksPriorityComboBox.Cursor = Cursors.Hand;
            TasksPriorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TasksPriorityComboBox.FormattingEnabled = true;
            TasksPriorityComboBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            TasksPriorityComboBox.Location = new Point(330, 405);
            TasksPriorityComboBox.Name = "TasksPriorityComboBox";
            TasksPriorityComboBox.Size = new Size(300, 28);
            TasksPriorityComboBox.TabIndex = 7;
            // 
            // TasksPriorityTxt
            // 
            TasksPriorityTxt.AutoSize = true;
            TasksPriorityTxt.Font = new Font("Segoe UI", 12F);
            TasksPriorityTxt.Location = new Point(110, 401);
            TasksPriorityTxt.Name = "TasksPriorityTxt";
            TasksPriorityTxt.Size = new Size(76, 28);
            TasksPriorityTxt.TabIndex = 2;
            TasksPriorityTxt.Text = "Priority";
            // 
            // TasksDesTxtBox
            // 
            TasksDesTxtBox.Font = new Font("Segoe UI", 12F);
            TasksDesTxtBox.Location = new Point(330, 272);
            TasksDesTxtBox.Multiline = true;
            TasksDesTxtBox.Name = "TasksDesTxtBox";
            TasksDesTxtBox.PlaceholderText = "Enter Your Description";
            TasksDesTxtBox.Size = new Size(300, 83);
            TasksDesTxtBox.TabIndex = 6;
            // 
            // TasksDescriptionTxt
            // 
            TasksDescriptionTxt.AutoSize = true;
            TasksDescriptionTxt.Font = new Font("Segoe UI", 12F);
            TasksDescriptionTxt.Location = new Point(110, 294);
            TasksDescriptionTxt.Name = "TasksDescriptionTxt";
            TasksDescriptionTxt.Size = new Size(112, 28);
            TasksDescriptionTxt.TabIndex = 5;
            TasksDescriptionTxt.Text = "Description";
            // 
            // TasksProjectNameComboBox
            // 
            TasksProjectNameComboBox.Cursor = Cursors.Hand;
            TasksProjectNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TasksProjectNameComboBox.FormattingEnabled = true;
            TasksProjectNameComboBox.Items.AddRange(new object[] { "Project-1", "Project-2", "Project-3" });
            TasksProjectNameComboBox.Location = new Point(330, 191);
            TasksProjectNameComboBox.Name = "TasksProjectNameComboBox";
            TasksProjectNameComboBox.Size = new Size(300, 28);
            TasksProjectNameComboBox.TabIndex = 4;
            // 
            // TasksProNameTxt
            // 
            TasksProNameTxt.AutoSize = true;
            TasksProNameTxt.Font = new Font("Segoe UI", 12F);
            TasksProNameTxt.Location = new Point(110, 191);
            TasksProNameTxt.Name = "TasksProNameTxt";
            TasksProNameTxt.Size = new Size(130, 28);
            TasksProNameTxt.TabIndex = 3;
            TasksProNameTxt.Text = "Project Name";
            // 
            // TasksNameTxtBox
            // 
            TasksNameTxtBox.Font = new Font("Segoe UI", 12F);
            TasksNameTxtBox.Location = new Point(330, 114);
            TasksNameTxtBox.Name = "TasksNameTxtBox";
            TasksNameTxtBox.PlaceholderText = "Enter Task Name";
            TasksNameTxtBox.Size = new Size(300, 34);
            TasksNameTxtBox.TabIndex = 2;
            // 
            // TasksNameTxt
            // 
            TasksNameTxt.AutoSize = true;
            TasksNameTxt.Font = new Font("Segoe UI", 12F);
            TasksNameTxt.Location = new Point(110, 120);
            TasksNameTxt.Name = "TasksNameTxt";
            TasksNameTxt.Size = new Size(105, 28);
            TasksNameTxt.TabIndex = 1;
            TasksNameTxt.Text = "Task Name";
            // 
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 703);
            Controls.Add(TasksPanel);
            Name = "TasksForm";
            Text = "TasksForm";
            TasksPanel.ResumeLayout(false);
            TasksPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TasksFormHeadTxt;
        private Panel TasksPanel;
        private Label TasksProNameTxt;
        private TextBox TasksNameTxtBox;
        private Label TasksNameTxt;
        private ComboBox TasksProjectNameComboBox;
        private TextBox TasksDesTxtBox;
        private Label TasksDescriptionTxt;
        private ComboBox TasksPriorityComboBox;
        private Label TasksPriorityTxt;
        private ComboBox TasksStatusComboBox;
        private Label TasksStatusTxt;
        private Button TasksSubmitBtn;
    }
}