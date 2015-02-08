namespace Raw_Data_AoB_Extractor
{
    partial class cheatTable
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbaob1 = new System.Windows.Forms.TextBox();
            this.tbaob2 = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tbaob1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbaob2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbOutput, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbaob1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbaob1, 2);
            this.tbaob1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbaob1.Location = new System.Drawing.Point(3, 17);
            this.tbaob1.Name = "tbaob1";
            this.tbaob1.Size = new System.Drawing.Size(337, 20);
            this.tbaob1.TabIndex = 0;
            this.tbaob1.TextChanged += new System.EventHandler(this.createOutput);
            // 
            // tbaob2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbaob2, 2);
            this.tbaob2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbaob2.Location = new System.Drawing.Point(3, 63);
            this.tbaob2.Name = "tbaob2";
            this.tbaob2.Size = new System.Drawing.Size(337, 20);
            this.tbaob2.TabIndex = 1;
            this.tbaob2.TextChanged += new System.EventHandler(this.createOutput);
            // 
            // tbOutput
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbOutput, 2);
            this.tbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOutput.Location = new System.Drawing.Point(3, 115);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(337, 144);
            this.tbOutput.TabIndex = 2;
            this.tbOutput.DoubleClick += new System.EventHandler(this.tbOutput_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "AoB to search for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "AoB to replace original";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Output";
            // 
            // cheatTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "cheatTable";
            this.Text = "AoB Swap Cheat Table Generator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbaob1;
        private System.Windows.Forms.TextBox tbaob2;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}