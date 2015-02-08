namespace Raw_Data_AoB_Extractor
{
    partial class UnityConverter
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_resolveBranches = new System.Windows.Forms.CheckBox();
            this.cb_autoclose = new System.Windows.Forms.CheckBox();
            this.cb_metadata = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_data, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 277);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(420, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate Instructions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_data
            // 
            this.tb_data.ContextMenuStrip = this.contextMenuStrip1;
            this.tb_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_data.Location = new System.Drawing.Point(3, 3);
            this.tb_data.Multiline = true;
            this.tb_data.Name = "tb_data";
            this.tableLayoutPanel1.SetRowSpan(this.tb_data, 3);
            this.tb_data.Size = new System.Drawing.Size(411, 271);
            this.tb_data.TabIndex = 3;
            this.tb_data.WordWrap = false;
            this.tb_data.DoubleClick += new System.EventHandler(this.tb_data_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(420, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Copy Code To Editor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_resolveBranches);
            this.groupBox1.Controls.Add(this.cb_autoclose);
            this.groupBox1.Controls.Add(this.cb_metadata);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(420, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(104, 122);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // cb_resolveBranches
            // 
            this.cb_resolveBranches.AutoSize = true;
            this.cb_resolveBranches.Location = new System.Drawing.Point(0, 84);
            this.cb_resolveBranches.Name = "cb_resolveBranches";
            this.cb_resolveBranches.Size = new System.Drawing.Size(114, 30);
            this.cb_resolveBranches.TabIndex = 8;
            this.cb_resolveBranches.Text = "Attempt to resolve \r\nbranches";
            this.cb_resolveBranches.UseVisualStyleBackColor = true;
            // 
            // cb_autoclose
            // 
            this.cb_autoclose.AutoSize = true;
            this.cb_autoclose.Checked = true;
            this.cb_autoclose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_autoclose.Location = new System.Drawing.Point(1, 16);
            this.cb_autoclose.Margin = new System.Windows.Forms.Padding(0);
            this.cb_autoclose.Name = "cb_autoclose";
            this.cb_autoclose.Size = new System.Drawing.Size(103, 30);
            this.cb_autoclose.TabIndex = 7;
            this.cb_autoclose.Text = "Autoclose after\r\ngenerating code";
            this.cb_autoclose.UseVisualStyleBackColor = true;
            // 
            // cb_metadata
            // 
            this.cb_metadata.AutoSize = true;
            this.cb_metadata.Checked = true;
            this.cb_metadata.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_metadata.Location = new System.Drawing.Point(1, 51);
            this.cb_metadata.Margin = new System.Windows.Forms.Padding(0);
            this.cb_metadata.Name = "cb_metadata";
            this.cb_metadata.Size = new System.Drawing.Size(103, 30);
            this.cb_metadata.TabIndex = 6;
            this.cb_metadata.Text = "Keep Instruction\r\nMetadata";
            this.cb_metadata.UseVisualStyleBackColor = true;
            // 
            // UnityConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 277);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UnityConverter";
            this.Text = "UnityConverter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UnityConverter_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_autoclose;
        private System.Windows.Forms.CheckBox cb_metadata;
        private System.Windows.Forms.CheckBox cb_resolveBranches;
    }
}