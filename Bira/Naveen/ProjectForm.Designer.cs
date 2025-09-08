namespace Bira.Naveen
{
    partial class ProjectForm
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
            components = new System.ComponentModel.Container();
            ProjectHeadTxt = new Label();
            ProjectNameTxt = new Label();
            ProjectNameBox = new TextBox();
            StartDateTxt = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            StarttextBox = new TextBox();
            EndDateTxt = new Label();
            EndDateTxtBox = new TextBox();
            DescriptionTxt = new Label();
            ProjectDescriptionBox = new TextBox();
            ProjectSubmitBtn = new Button();
            SuspendLayout();
            // 
            // ProjectHeadTxt
            // 
            ProjectHeadTxt.AutoSize = true;
            ProjectHeadTxt.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            ProjectHeadTxt.Location = new Point(408, 50);
            ProjectHeadTxt.Name = "ProjectHeadTxt";
            ProjectHeadTxt.Size = new Size(121, 37);
            ProjectHeadTxt.TabIndex = 0;
            ProjectHeadTxt.Text = "Projects";
            // 
            // ProjectNameTxt
            // 
            ProjectNameTxt.AutoSize = true;
            ProjectNameTxt.Font = new Font("Segoe UI", 12F);
            ProjectNameTxt.Location = new Point(212, 153);
            ProjectNameTxt.Name = "ProjectNameTxt";
            ProjectNameTxt.Size = new Size(130, 28);
            ProjectNameTxt.TabIndex = 1;
            ProjectNameTxt.Text = "Project Name";
            // 
            // ProjectNameBox
            // 
            ProjectNameBox.Location = new Point(527, 157);
            ProjectNameBox.Name = "ProjectNameBox";
            ProjectNameBox.Size = new Size(259, 27);
            ProjectNameBox.TabIndex = 2;
            ProjectNameBox.TextChanged += ProjectNameBox_TextChanged;
            // 
            // StartDateTxt
            // 
            StartDateTxt.AutoSize = true;
            StartDateTxt.Font = new Font("Segoe UI", 12F);
            StartDateTxt.Location = new Point(212, 263);
            StartDateTxt.Name = "StartDateTxt";
            StartDateTxt.Size = new Size(99, 28);
            StartDateTxt.TabIndex = 3;
            StartDateTxt.Text = "Start Date";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // StarttextBox
            // 
            StarttextBox.Location = new Point(527, 267);
            StarttextBox.Name = "StarttextBox";
            StarttextBox.Size = new Size(259, 27);
            StarttextBox.TabIndex = 5;
            StarttextBox.TextChanged += StarttextBox_TextChanged;
            // 
            // EndDateTxt
            // 
            EndDateTxt.AutoSize = true;
            EndDateTxt.Font = new Font("Segoe UI", 12F);
            EndDateTxt.Location = new Point(212, 368);
            EndDateTxt.Name = "EndDateTxt";
            EndDateTxt.Size = new Size(91, 28);
            EndDateTxt.TabIndex = 6;
            EndDateTxt.Text = "End Date";
            // 
            // EndDateTxtBox
            // 
            EndDateTxtBox.Location = new Point(527, 372);
            EndDateTxtBox.Name = "EndDateTxtBox";
            EndDateTxtBox.Size = new Size(259, 27);
            EndDateTxtBox.TabIndex = 7;
            EndDateTxtBox.TextChanged += EndDateTxtBox_TextChanged;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.AutoSize = true;
            DescriptionTxt.Font = new Font("Segoe UI", 12F);
            DescriptionTxt.Location = new Point(212, 472);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(112, 28);
            DescriptionTxt.TabIndex = 8;
            DescriptionTxt.Text = "Description";
            // 
            // ProjectDescriptionBox
            // 
            ProjectDescriptionBox.Location = new Point(527, 441);
            ProjectDescriptionBox.Multiline = true;
            ProjectDescriptionBox.Name = "ProjectDescriptionBox";
            ProjectDescriptionBox.Size = new Size(259, 110);
            ProjectDescriptionBox.TabIndex = 9;
            ProjectDescriptionBox.TextChanged += ProjectDescriptionBox_TextChanged;
            // 
            // ProjectSubmitBtn
            // 
            ProjectSubmitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProjectSubmitBtn.Location = new Point(408, 597);
            ProjectSubmitBtn.Name = "ProjectSubmitBtn";
            ProjectSubmitBtn.Size = new Size(121, 56);
            ProjectSubmitBtn.TabIndex = 10;
            ProjectSubmitBtn.Text = "Submit";
            ProjectSubmitBtn.UseVisualStyleBackColor = true;
            ProjectSubmitBtn.Click += ProjectSubmitBtn_Click;
            // 
            // ProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 682);
            Controls.Add(ProjectSubmitBtn);
            Controls.Add(ProjectDescriptionBox);
            Controls.Add(DescriptionTxt);
            Controls.Add(EndDateTxtBox);
            Controls.Add(EndDateTxt);
            Controls.Add(StarttextBox);
            Controls.Add(StartDateTxt);
            Controls.Add(ProjectNameBox);
            Controls.Add(ProjectNameTxt);
            Controls.Add(ProjectHeadTxt);
            Name = "ProjectForm";
            Text = "ProjectForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProjectHeadTxt;
        private Label ProjectNameTxt;
        private TextBox ProjectNameBox;
        private Label StartDateTxt;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox StarttextBox;
        private Label EndDateTxt;
        private TextBox EndDateTxtBox;
        private Label DescriptionTxt;
        private TextBox ProjectDescriptionBox;
        private Button ProjectSubmitBtn;
    }
}
