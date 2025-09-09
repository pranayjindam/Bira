namespace Bira
{
    partial class EditProject
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
            components = new System.ComponentModel.Container();
            StartDateTxt = new Label();
            ProjectNameBox = new TextBox();
            ProjectNameTxt = new Label();
            ProjectHeadTxt = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ProjectSubmitBtn = new Button();
            ProjectDescriptionBox = new TextBox();
            DescriptionTxt = new Label();
            EndDateTxtBox = new TextBox();
            EndDateTxt = new Label();
            StarttextBox = new TextBox();
            SuspendLayout();
            // 
            // StartDateTxt
            // 
            StartDateTxt.AutoSize = true;
            StartDateTxt.Font = new Font("Segoe UI", 12F);
            StartDateTxt.Location = new Point(51, 225);
            StartDateTxt.Margin = new Padding(4, 0, 4, 0);
            StartDateTxt.Name = "StartDateTxt";
            StartDateTxt.Size = new Size(119, 32);
            StartDateTxt.TabIndex = 14;
            StartDateTxt.Text = "Start Date";
            // 
            // ProjectNameBox
            // 
            ProjectNameBox.Location = new Point(209, 146);
            ProjectNameBox.Margin = new Padding(4);
            ProjectNameBox.Name = "ProjectNameBox";
            ProjectNameBox.Size = new Size(323, 31);
            ProjectNameBox.TabIndex = 13;
            // 
            // ProjectNameTxt
            // 
            ProjectNameTxt.AutoSize = true;
            ProjectNameTxt.Font = new Font("Segoe UI", 12F);
            ProjectNameTxt.Location = new Point(24, 141);
            ProjectNameTxt.Margin = new Padding(4, 0, 4, 0);
            ProjectNameTxt.Name = "ProjectNameTxt";
            ProjectNameTxt.Size = new Size(158, 32);
            ProjectNameTxt.TabIndex = 12;
            ProjectNameTxt.Text = "Project Name";
            // 
            // ProjectHeadTxt
            // 
            ProjectHeadTxt.AutoSize = true;
            ProjectHeadTxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            ProjectHeadTxt.Location = new Point(178, 37);
            ProjectHeadTxt.Margin = new Padding(4, 0, 4, 0);
            ProjectHeadTxt.Name = "ProjectHeadTxt";
            ProjectHeadTxt.Size = new Size(193, 45);
            ProjectHeadTxt.TabIndex = 11;
            ProjectHeadTxt.Text = "Edit Project";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ProjectSubmitBtn
            // 
            ProjectSubmitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProjectSubmitBtn.Location = new Point(209, 550);
            ProjectSubmitBtn.Margin = new Padding(4);
            ProjectSubmitBtn.Name = "ProjectSubmitBtn";
            ProjectSubmitBtn.Size = new Size(121, 49);
            ProjectSubmitBtn.TabIndex = 20;
            ProjectSubmitBtn.Text = "Submit";
            ProjectSubmitBtn.UseVisualStyleBackColor = true;
            ProjectSubmitBtn.Click += ProjectSubmitBtn_Click;
            // 
            // ProjectDescriptionBox
            // 
            ProjectDescriptionBox.Location = new Point(209, 391);
            ProjectDescriptionBox.Margin = new Padding(4);
            ProjectDescriptionBox.Multiline = true;
            ProjectDescriptionBox.Name = "ProjectDescriptionBox";
            ProjectDescriptionBox.Size = new Size(323, 136);
            ProjectDescriptionBox.TabIndex = 19;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.AutoSize = true;
            DescriptionTxt.Font = new Font("Segoe UI", 12F);
            DescriptionTxt.Location = new Point(26, 378);
            DescriptionTxt.Margin = new Padding(4, 0, 4, 0);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(135, 32);
            DescriptionTxt.TabIndex = 18;
            DescriptionTxt.Text = "Description";
            // 
            // EndDateTxtBox
            // 
            EndDateTxtBox.Location = new Point(209, 306);
            EndDateTxtBox.Margin = new Padding(4);
            EndDateTxtBox.Name = "EndDateTxtBox";
            EndDateTxtBox.Size = new Size(323, 31);
            EndDateTxtBox.TabIndex = 17;
            // 
            // EndDateTxt
            // 
            EndDateTxt.AutoSize = true;
            EndDateTxt.Font = new Font("Segoe UI", 12F);
            EndDateTxt.Location = new Point(61, 305);
            EndDateTxt.Margin = new Padding(4, 0, 4, 0);
            EndDateTxt.Name = "EndDateTxt";
            EndDateTxt.Size = new Size(111, 32);
            EndDateTxt.TabIndex = 16;
            EndDateTxt.Text = "End Date";
            // 
            // StarttextBox
            // 
            StarttextBox.Location = new Point(209, 225);
            StarttextBox.Margin = new Padding(4);
            StarttextBox.Name = "StarttextBox";
            StarttextBox.Size = new Size(323, 31);
            StarttextBox.TabIndex = 15;
            // 
            // EditProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 612);
            Controls.Add(StartDateTxt);
            Controls.Add(ProjectNameBox);
            Controls.Add(ProjectNameTxt);
            Controls.Add(ProjectHeadTxt);
            Controls.Add(ProjectSubmitBtn);
            Controls.Add(ProjectDescriptionBox);
            Controls.Add(DescriptionTxt);
            Controls.Add(EndDateTxtBox);
            Controls.Add(EndDateTxt);
            Controls.Add(StarttextBox);
            Name = "EditProject";
            Text = "EditProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StartDateTxt;
        private TextBox ProjectNameBox;
        private Label ProjectNameTxt;
        private Label ProjectHeadTxt;
        private ContextMenuStrip contextMenuStrip1;
        private Button ProjectSubmitBtn;
        private TextBox ProjectDescriptionBox;
        private Label DescriptionTxt;
        private TextBox EndDateTxtBox;
        private Label EndDateTxt;
        private TextBox StarttextBox;
    }
}