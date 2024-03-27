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
            stepBtn.Location = new Point(4, 64);
            stepBtn.Margin = new Padding(4, 4, 4, 4);
            stepBtn.Name = "stepBtn";
            stepBtn.Size = new Size(135, 60);
            stepBtn.TabIndex = 1;
            stepBtn.Text = "Step";
            stepBtn.UseVisualStyleBackColor = false;
            stepBtn.Click += StepBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 312F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 4);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(966, 597);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(clusterGroupBox, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(602, 4);
            tableLayoutPanel2.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.8866539F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.1133461F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(304, 589);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // clusterGroupBox
            // 
            clusterGroupBox.Controls.Add(tableLayoutPanel3);
            clusterGroupBox.Dock = DockStyle.Fill;
            clusterGroupBox.Enabled = false;
            clusterGroupBox.Location = new Point(4, 274);
            clusterGroupBox.Margin = new Padding(4, 4, 4, 4);
            clusterGroupBox.MaximumSize = new Size(318, 0);
            clusterGroupBox.Name = "clusterGroupBox";
            clusterGroupBox.Padding = new Padding(4, 4, 4, 4);
            clusterGroupBox.Size = new Size(296, 311);
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
            tableLayoutPanel3.Location = new Point(4, 28);
            tableLayoutPanel3.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel3.Size = new Size(288, 270);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 60);
            label1.TabIndex = 2;
            label1.Text = "Number of clusters:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // clustersNo
            // 
            clustersNo.Anchor = AnchorStyles.Right;
            clustersNo.Location = new Point(191, 14);
            clustersNo.Margin = new Padding(4, 4, 4, 4);
            clustersNo.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            clustersNo.Name = "clustersNo";
            clustersNo.Size = new Size(93, 31);
            clustersNo.TabIndex = 2;
            clustersNo.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // FinishBtn
            // 
            FinishBtn.FlatStyle = FlatStyle.System;
            FinishBtn.Location = new Point(4, 133);
            FinishBtn.Margin = new Padding(4, 4, 4, 4);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(135, 60);
            FinishBtn.TabIndex = 3;
            FinishBtn.Text = "Finish";
            FinishBtn.UseVisualStyleBackColor = false;
            FinishBtn.Click += FinishBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.FlatStyle = FlatStyle.System;
            resetBtn.Location = new Point(4, 202);
            resetBtn.Margin = new Padding(4, 4, 4, 4);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(135, 60);
            resetBtn.TabIndex = 4;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel9);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(4, 45);
            groupBox3.Margin = new Padding(4, 45, 4, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 4, 4, 4);
            groupBox3.Size = new Size(296, 221);
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
            tableLayoutPanel9.Location = new Point(4, 28);
            tableLayoutPanel9.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(288, 189);
            tableLayoutPanel9.TabIndex = 1;
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.BackColor = Color.White;
            fileLabel.BorderStyle = BorderStyle.FixedSingle;
            fileLabel.Dock = DockStyle.Fill;
            fileLabel.Location = new Point(6, 8);
            fileLabel.Margin = new Padding(6, 8, 6, 8);
            fileLabel.MaximumSize = new Size(449, 0);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(276, 28);
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
            tableLayoutPanel8.Location = new Point(0, 44);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 4;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel8.Size = new Size(288, 145);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // loadFileBtn
            // 
            loadFileBtn.FlatStyle = FlatStyle.System;
            loadFileBtn.Location = new Point(4, 4);
            loadFileBtn.Margin = new Padding(4, 4, 4, 4);
            loadFileBtn.Name = "loadFileBtn";
            loadFileBtn.Size = new Size(135, 60);
            loadFileBtn.TabIndex = 0;
            loadFileBtn.Text = "Load File";
            loadFileBtn.UseVisualStyleBackColor = true;
            loadFileBtn.Click += loadFileBtn_Click;
            // 
            // selectDataBtn
            // 
            selectDataBtn.Enabled = false;
            selectDataBtn.FlatStyle = FlatStyle.System;
            selectDataBtn.Location = new Point(4, 74);
            selectDataBtn.Margin = new Padding(4, 4, 4, 4);
            selectDataBtn.Name = "selectDataBtn";
            selectDataBtn.Size = new Size(135, 60);
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
            tableLayoutPanel4.Location = new Point(4, 4);
            tableLayoutPanel4.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.Size = new Size(590, 589);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 182F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 406F));
            tableLayoutPanel11.Controls.Add(AutoScaleBtn, 0, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 544);
            tableLayoutPanel11.Margin = new Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(590, 45);
            tableLayoutPanel11.TabIndex = 5;
            // 
            // AutoScaleBtn
            // 
            AutoScaleBtn.FlatStyle = FlatStyle.System;
            AutoScaleBtn.Location = new Point(60, 4);
            AutoScaleBtn.Margin = new Padding(60, 4, 4, 4);
            AutoScaleBtn.Name = "AutoScaleBtn";
            AutoScaleBtn.Size = new Size(112, 34);
            AutoScaleBtn.TabIndex = 1;
            AutoScaleBtn.Text = "Reset Scale";
            AutoScaleBtn.UseVisualStyleBackColor = true;
            AutoScaleBtn.Click += AutoScaleBtn_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(4, 4);
            formsPlot1.Margin = new Padding(4, 4, 4, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(582, 536);
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
            statusStrip1.Location = new Point(0, 605);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 21, 0);
            statusStrip1.Size = new Size(974, 39);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(64, 32);
            toolStripStatusLabel1.Text = "Status:";
            // 
            // StatusLabel
            // 
            StatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(887, 32);
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
            tableLayoutPanel10.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100.000008F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel10.Size = new Size(974, 644);
            tableLayoutPanel10.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(974, 644);
            Controls.Add(tableLayoutPanel10);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(986, 674);
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
