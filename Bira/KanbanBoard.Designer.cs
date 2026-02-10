namespace Bira
{
    partial class KanbanBoard
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
            panelHeader = new Panel();
            buttonRefresh = new Button();
            comboBoxProjectFilter = new ComboBox();
            labelTitle = new Label();
            panelBoard = new Panel();
            panelDone = new Panel();
            flowLayoutPanelDone = new FlowLayoutPanel();
            labelDone = new Label();
            panelInProgress = new Panel();
            flowLayoutPanelInProgress = new FlowLayoutPanel();
            labelInProgress = new Label();
            panelToDo = new Panel();
            flowLayoutPanelToDo = new FlowLayoutPanel();
            labelToDo = new Label();
            panelHeader.SuspendLayout();
            panelBoard.SuspendLayout();
            panelDone.SuspendLayout();
            panelInProgress.SuspendLayout();
            panelToDo.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(buttonRefresh);
            panelHeader.Controls.Add(comboBoxProjectFilter);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20);
            panelHeader.Size = new Size(975, 80);
            panelHeader.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(59, 130, 246);
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(450, 25);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(80, 35);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "🔄 Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // comboBoxProjectFilter
            // 
            comboBoxProjectFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProjectFilter.Font = new Font("Segoe UI", 10F);
            comboBoxProjectFilter.FormattingEnabled = true;
            comboBoxProjectFilter.Location = new Point(250, 30);
            comboBoxProjectFilter.Name = "comboBoxProjectFilter";
            comboBoxProjectFilter.Size = new Size(180, 36);
            comboBoxProjectFilter.TabIndex = 1;
            comboBoxProjectFilter.SelectedIndexChanged += comboBoxProjectFilter_SelectedIndexChanged;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(30, 41, 59);
            labelTitle.Location = new Point(20, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(200, 40);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "📋 Kanban Board";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBoard
            // 
            panelBoard.BackColor = Color.FromArgb(248, 250, 252);
            panelBoard.Controls.Add(panelDone);
            panelBoard.Controls.Add(panelInProgress);
            panelBoard.Controls.Add(panelToDo);
            panelBoard.Dock = DockStyle.Fill;
            panelBoard.Location = new Point(0, 80);
            panelBoard.Name = "panelBoard";
            panelBoard.Padding = new Padding(20);
            panelBoard.Size = new Size(975, 520);
            panelBoard.TabIndex = 1;
            // 
            // panelDone
            // 
            panelDone.BackColor = Color.White;
            panelDone.Controls.Add(flowLayoutPanelDone);
            panelDone.Controls.Add(labelDone);
            panelDone.Dock = DockStyle.Left;
            panelDone.Location = new Point(600, 20);
            panelDone.Margin = new Padding(10);
            panelDone.Name = "panelDone";
            panelDone.Size = new Size(350, 480);
            panelDone.TabIndex = 3;
            // 
            // flowLayoutPanelDone
            // 
            flowLayoutPanelDone.AutoScroll = true;
            flowLayoutPanelDone.BackColor = Color.Transparent;
            flowLayoutPanelDone.Dock = DockStyle.Left;
            flowLayoutPanelDone.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelDone.Location = new Point(0, 40);
            flowLayoutPanelDone.Name = "flowLayoutPanelDone";
            flowLayoutPanelDone.Padding = new Padding(5);
            flowLayoutPanelDone.Size = new Size(350, 440);
            flowLayoutPanelDone.TabIndex = 1;
            flowLayoutPanelDone.WrapContents = false;
            // 
            // labelDone
            // 
            labelDone.BackColor = Color.FromArgb(34, 197, 94);
            labelDone.Dock = DockStyle.Top;
            labelDone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDone.ForeColor = Color.White;
            labelDone.Location = new Point(0, 0);
            labelDone.Name = "labelDone";
            labelDone.Size = new Size(350, 40);
            labelDone.TabIndex = 0;
            labelDone.Text = "Done (0)";
            labelDone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelInProgress
            // 
            panelInProgress.BackColor = Color.White;
            panelInProgress.Controls.Add(flowLayoutPanelInProgress);
            panelInProgress.Controls.Add(labelInProgress);
            panelInProgress.Dock = DockStyle.Left;
            panelInProgress.Location = new Point(310, 20);
            panelInProgress.Margin = new Padding(10);
            panelInProgress.Name = "panelInProgress";
            panelInProgress.Size = new Size(290, 480);
            panelInProgress.TabIndex = 1;
            // 
            // flowLayoutPanelInProgress
            // 
            flowLayoutPanelInProgress.AutoScroll = true;
            flowLayoutPanelInProgress.BackColor = Color.Transparent;
            flowLayoutPanelInProgress.Dock = DockStyle.Left;
            flowLayoutPanelInProgress.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelInProgress.Location = new Point(0, 40);
            flowLayoutPanelInProgress.Name = "flowLayoutPanelInProgress";
            flowLayoutPanelInProgress.Padding = new Padding(5);
            flowLayoutPanelInProgress.Size = new Size(350, 440);
            flowLayoutPanelInProgress.TabIndex = 1;
            flowLayoutPanelInProgress.WrapContents = false;
            // 
            // labelInProgress
            // 
            labelInProgress.BackColor = Color.FromArgb(251, 146, 60);
            labelInProgress.Dock = DockStyle.Top;
            labelInProgress.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelInProgress.ForeColor = Color.White;
            labelInProgress.Location = new Point(0, 0);
            labelInProgress.Name = "labelInProgress";
            labelInProgress.Size = new Size(290, 40);
            labelInProgress.TabIndex = 0;
            labelInProgress.Text = "In Progress (0)";
            labelInProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelToDo
            // 
            panelToDo.BackColor = Color.White;
            panelToDo.Controls.Add(flowLayoutPanelToDo);
            panelToDo.Controls.Add(labelToDo);
            panelToDo.Dock = DockStyle.Left;
            panelToDo.Location = new Point(20, 20);
            panelToDo.Margin = new Padding(10);
            panelToDo.Name = "panelToDo";
            panelToDo.Size = new Size(290, 480);
            panelToDo.TabIndex = 0;
            // 
            // flowLayoutPanelToDo
            // 
            flowLayoutPanelToDo.AutoScroll = true;
            flowLayoutPanelToDo.BackColor = Color.Transparent;
            flowLayoutPanelToDo.Dock = DockStyle.Left;
            flowLayoutPanelToDo.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelToDo.Location = new Point(0, 40);
            flowLayoutPanelToDo.Name = "flowLayoutPanelToDo";
            flowLayoutPanelToDo.Padding = new Padding(5);
            flowLayoutPanelToDo.Size = new Size(350, 440);
            flowLayoutPanelToDo.TabIndex = 1;
            flowLayoutPanelToDo.WrapContents = false;
            // 
            // labelToDo
            // 
            labelToDo.BackColor = Color.FromArgb(239, 68, 68);
            labelToDo.Dock = DockStyle.Top;
            labelToDo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelToDo.ForeColor = Color.White;
            labelToDo.Location = new Point(0, 0);
            labelToDo.Name = "labelToDo";
            labelToDo.Size = new Size(290, 40);
            labelToDo.TabIndex = 0;
            labelToDo.Text = "To Do (0)";
            labelToDo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KanbanBoard
            // 
            ClientSize = new Size(975, 600);
            Controls.Add(panelBoard);
            Controls.Add(panelHeader);
            Name = "KanbanBoard";
            Text = "Kanban Board";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelBoard.ResumeLayout(false);
            panelDone.ResumeLayout(false);
            panelInProgress.ResumeLayout(false);
            panelToDo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private ComboBox comboBoxProjectFilter;
        private Button buttonRefresh;
        private Panel panelBoard;
        private Panel panelToDo;
        private Label labelToDo;
        private FlowLayoutPanel flowLayoutPanelToDo;
        private Panel panelInProgress;
        private Label labelInProgress;
        private FlowLayoutPanel flowLayoutPanelInProgress;
        private Panel panelDone;
        private Label labelDone;
        private FlowLayoutPanel flowLayoutPanelDone;
    }
}