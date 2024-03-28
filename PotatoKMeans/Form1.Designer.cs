namespace PotatoKMeans
{
    partial class Form1
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stepBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            clusterGroupBox = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            clustersNo = new NumericUpDown();
            FinishBtn = new Button();
            resetBtn = new Button();
            groupBox3 = new GroupBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            fileLabel = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            loadFileBtn = new Button();
            selectDataBtn = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            AutoScaleBtn = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            groupBox2 = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            button1 = new Button();
            label2 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            StatusLabel = new ToolStripStatusLabel();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            clusterGroupBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clustersNo).BeginInit();
            groupBox3.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            SuspendLayout();
            // 
            // stepBtn
            // 
            stepBtn.FlatStyle = FlatStyle.System;
            stepBtn.Location = new Point(3, 43);
            stepBtn.Name = "stepBtn";
            stepBtn.Size = new Size(90, 40);
            stepBtn.TabIndex = 1;
            stepBtn.Text = "Step";
            stepBtn.UseVisualStyleBackColor = false;
            stepBtn.Click += StepBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 208F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(641, 398);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(clusterGroupBox, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(399, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 183F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.Size = new Size(202, 392);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // clusterGroupBox
            // 
            clusterGroupBox.Controls.Add(tableLayoutPanel3);
            clusterGroupBox.Dock = DockStyle.Top;
            clusterGroupBox.Enabled = false;
            clusterGroupBox.Location = new Point(3, 186);
            clusterGroupBox.MaximumSize = new Size(212, 0);
            clusterGroupBox.Name = "clusterGroupBox";
            clusterGroupBox.Size = new Size(196, 202);
            clusterGroupBox.TabIndex = 4;
            clusterGroupBox.TabStop = false;
            clusterGroupBox.Text = "Cluster Control";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.63636F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.363636F));
            tableLayoutPanel3.Controls.Add(stepBtn, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(clustersNo, 1, 0);
            tableLayoutPanel3.Controls.Add(FinishBtn, 0, 2);
            tableLayoutPanel3.Controls.Add(resetBtn, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel3.Size = new Size(190, 180);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 40);
            label1.TabIndex = 2;
            label1.Text = "Number of clusters:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clustersNo
            // 
            clustersNo.Anchor = AnchorStyles.Right;
            clustersNo.Location = new Point(125, 8);
            clustersNo.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            clustersNo.Name = "clustersNo";
            clustersNo.Size = new Size(62, 23);
            clustersNo.TabIndex = 2;
            clustersNo.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // FinishBtn
            // 
            FinishBtn.FlatStyle = FlatStyle.System;
            FinishBtn.Location = new Point(3, 89);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(90, 40);
            FinishBtn.TabIndex = 3;
            FinishBtn.Text = "Finish";
            FinishBtn.UseVisualStyleBackColor = false;
            FinishBtn.Click += FinishBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.FlatStyle = FlatStyle.System;
            resetBtn.Location = new Point(3, 135);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(90, 40);
            resetBtn.TabIndex = 4;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel9);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(3, 30);
            groupBox3.Margin = new Padding(3, 30, 3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(196, 150);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Data Control";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(fileLabel, 0, 0);
            tableLayoutPanel9.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 19);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(190, 128);
            tableLayoutPanel9.TabIndex = 1;
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.BackColor = Color.White;
            fileLabel.BorderStyle = BorderStyle.FixedSingle;
            fileLabel.Dock = DockStyle.Fill;
            fileLabel.Location = new Point(4, 5);
            fileLabel.Margin = new Padding(4, 5, 4, 5);
            fileLabel.MaximumSize = new Size(300, 400);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(182, 19);
            fileLabel.TabIndex = 1;
            fileLabel.Text = "Select text file with data";
            fileLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.05263F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.94737F));
            tableLayoutPanel8.Controls.Add(loadFileBtn, 0, 0);
            tableLayoutPanel8.Controls.Add(selectDataBtn, 0, 1);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 29);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel8.Size = new Size(190, 99);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // loadFileBtn
            // 
            loadFileBtn.FlatStyle = FlatStyle.System;
            loadFileBtn.Location = new Point(3, 3);
            loadFileBtn.Name = "loadFileBtn";
            loadFileBtn.Size = new Size(90, 40);
            loadFileBtn.TabIndex = 0;
            loadFileBtn.Text = "Load File";
            loadFileBtn.UseVisualStyleBackColor = true;
            loadFileBtn.Click += loadFileBtn_Click;
            // 
            // selectDataBtn
            // 
            selectDataBtn.Enabled = false;
            selectDataBtn.FlatStyle = FlatStyle.System;
            selectDataBtn.Location = new Point(3, 50);
            selectDataBtn.Name = "selectDataBtn";
            selectDataBtn.Size = new Size(90, 40);
            selectDataBtn.TabIndex = 1;
            selectDataBtn.Text = "Select Data";
            selectDataBtn.UseVisualStyleBackColor = true;
            selectDataBtn.Click += selectDataBtn_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel11, 0, 1);
            tableLayoutPanel4.Controls.Add(formsPlot1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.Size = new Size(390, 392);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 121F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 272F));
            tableLayoutPanel11.Controls.Add(AutoScaleBtn, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 362);
            tableLayoutPanel11.Margin = new Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(390, 30);
            tableLayoutPanel11.TabIndex = 5;
            // 
            // AutoScaleBtn
            // 
            AutoScaleBtn.FlatStyle = FlatStyle.System;
            AutoScaleBtn.Location = new Point(40, 3);
            AutoScaleBtn.Margin = new Padding(40, 3, 3, 3);
            AutoScaleBtn.Name = "AutoScaleBtn";
            AutoScaleBtn.Size = new Size(75, 23);
            AutoScaleBtn.TabIndex = 1;
            AutoScaleBtn.Text = "Reset Scale";
            AutoScaleBtn.UseVisualStyleBackColor = true;
            AutoScaleBtn.Click += AutoScaleBtn_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(3, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(384, 356);
            formsPlot1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.63636F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.363636F));
            tableLayoutPanel5.Controls.Add(button1, 0, 1);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(90, 40);
            button1.TabIndex = 1;
            button1.Text = "Step";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 40);
            label2.TabIndex = 2;
            label2.Text = "Number of clusters:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.Fill;
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, StatusLabel });
            statusStrip1.Location = new Point(0, 404);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(647, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(42, 21);
            toolStripStatusLabel1.Text = "Status:";
            // 
            // StatusLabel
            // 
            StatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(590, 21);
            StatusLabel.Spring = true;
            StatusLabel.Text = "STATUS!!!!!";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(statusStrip1, 0, 1);
            tableLayoutPanel10.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(0, 0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel10.Size = new Size(647, 430);
            tableLayoutPanel10.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(647, 430);
            Controls.Add(tableLayoutPanel10);
            MinimumSize = new Size(663, 469);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "K-Means Clustering";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            clusterGroupBox.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clustersNo).EndInit();
            groupBox3.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button stepBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private NumericUpDown clustersNo;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private Button AutoScaleBtn;
        private Button FinishBtn;
        private GroupBox clusterGroupBox;
        private Button resetBtn;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button1;
        private Label label2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label3;
        private Label fileLabel;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private Button loadFileBtn;
        private Button selectDataBtn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel StatusLabel;
        private OpenFileDialog openFileDialog1;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
    }
}
