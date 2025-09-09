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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
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
            ProjectHeadTxt.Location = new Point(135, 22);
            ProjectHeadTxt.Name = "ProjectHeadTxt";
            ProjectHeadTxt.Size = new Size(174, 37);
            ProjectHeadTxt.TabIndex = 0;
            ProjectHeadTxt.Text = "New Project";
            ProjectHeadTxt.Click += ProjectHeadTxt_Click;
            // 
            // ProjectNameTxt
            // 
            ProjectNameTxt.AutoSize = true;
            ProjectNameTxt.Font = new Font("Segoe UI", 12F);
            ProjectNameTxt.Location = new Point(15, 100);
            ProjectNameTxt.Name = "ProjectNameTxt";
            ProjectNameTxt.Size = new Size(130, 28);
            ProjectNameTxt.TabIndex = 1;
            ProjectNameTxt.Text = "Project Name";
            // 
            // ProjectNameBox
            // 
            ProjectNameBox.Location = new Point(163, 104);
            ProjectNameBox.Name = "ProjectNameBox";
            ProjectNameBox.Size = new Size(259, 27);
            ProjectNameBox.TabIndex = 2;
            ProjectNameBox.TextChanged += ProjectNameBox_TextChanged;
            // 
            // StartDateTxt
            // 
            StartDateTxt.AutoSize = true;
            StartDateTxt.Font = new Font("Segoe UI", 12F);
            StartDateTxt.Location = new Point(37, 167);
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
            StarttextBox.Location = new Point(163, 167);
            StarttextBox.Name = "StarttextBox";
            StarttextBox.Size = new Size(259, 27);
            StarttextBox.TabIndex = 5;
            StarttextBox.TextChanged += StarttextBox_TextChanged;
            // 
            // EndDateTxt
            // 
            EndDateTxt.AutoSize = true;
            EndDateTxt.Font = new Font("Segoe UI", 12F);
            EndDateTxt.Location = new Point(45, 231);
            EndDateTxt.Name = "EndDateTxt";
            EndDateTxt.Size = new Size(91, 28);
            EndDateTxt.TabIndex = 6;
            EndDateTxt.Text = "End Date";
            EndDateTxt.Click += EndDateTxt_Click;
            // 
            // EndDateTxtBox
            // 
            EndDateTxtBox.Location = new Point(163, 232);
            EndDateTxtBox.Name = "EndDateTxtBox";
            EndDateTxtBox.Size = new Size(259, 27);
            EndDateTxtBox.TabIndex = 7;
            EndDateTxtBox.TextChanged += EndDateTxtBox_TextChanged;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.AutoSize = true;
            DescriptionTxt.Font = new Font("Segoe UI", 12F);
            DescriptionTxt.Location = new Point(17, 290);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(112, 28);
            DescriptionTxt.TabIndex = 8;
            DescriptionTxt.Text = "Description";
            // 
            // ProjectDescriptionBox
            // 
            ProjectDescriptionBox.Location = new Point(163, 300);
            ProjectDescriptionBox.Multiline = true;
            ProjectDescriptionBox.Name = "ProjectDescriptionBox";
            ProjectDescriptionBox.Size = new Size(259, 110);
            ProjectDescriptionBox.TabIndex = 9;
            ProjectDescriptionBox.TextChanged += ProjectDescriptionBox_TextChanged;
            // 
            // ProjectSubmitBtn
            // 
            ProjectSubmitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProjectSubmitBtn.Location = new Point(163, 427);
            ProjectSubmitBtn.Name = "ProjectSubmitBtn";
            ProjectSubmitBtn.Size = new Size(97, 39);
            ProjectSubmitBtn.TabIndex = 10;
            ProjectSubmitBtn.Text = "Submit";
            ProjectSubmitBtn.UseVisualStyleBackColor = true;
            ProjectSubmitBtn.Click += ProjectSubmitBtn_Click;
            // 
            // ProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(454, 490);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProjectForm";
            Text = "New Project";
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
