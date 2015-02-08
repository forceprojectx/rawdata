using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Raw_Data_AoB_Extractor
{
    public partial class UpdateMessageBox : Form
    {
        public UpdateMessageBox()
        {
            InitializeComponent();
        }
        public UpdateMessageBox(string AppTitle, string message)
        {
            InitializeComponent();
            //string[] lines = message.Split(Environment.NewLine.ToCharArray());
            richTextBox1.Text = "";            
            richTextBox1.SelectionFont = new Font("Verdana", 9, FontStyle.Bold);
            richTextBox1.SelectedText = AppTitle + "\n";
            richTextBox1.AppendText(message);         
            
            
            this.ShowIcon = true;
            this.ShowInTaskbar = true;

            //this.WindowState = FormWindowState.Normal;
            //this.TopMost = true;
            //try
            //{
            //    this.Parent=Application.OpenForms[0];
            //}
            //catch (Exception ex)
            //{
            //    //this.WindowState = FormWindowState.Normal;
            //    System.Diagnostics.Debug.WriteLine(ex.Message);
            //    this.TopMost = true;
            //}
            
            //this.Parent = this.TopLevelControl;
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }
        public UpdateMessageBox(string message, Form owner)
        {
            InitializeComponent();
            richTextBox1.Text = message;
            this.Owner = owner;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            Close();
        }

        private void btn_remind7_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;            
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }



    }
}
