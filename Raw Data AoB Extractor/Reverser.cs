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
    public partial class Reverser : Form
    {
        public Reverser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string delimiters = " ,.:";
            int counter = 0;
            char[] delimiter = delimiters.ToCharArray();
            String final = "";
            String[] split = textBox1.Text.Trim().Split(' ');
            foreach (string s in split)
            {
                counter++;
                final = s + " " + final;
            }
            textBox2.Text = final.Trim();
            textBox4.Text = "" + counter;
            textBox3.Text = counter.ToString("X");
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == null)
                return;// getaobs("button3");
            textBox2.SelectAll();
            Clipboard.SetText(textBox2.Text);
        }

        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox3.Text == null)
                return;// getaobs("button3");
            textBox3.SelectAll();
            Clipboard.SetText(textBox3.Text);
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox4.Text == null)
                return;// getaobs("button3");
            textBox4.SelectAll();
            Clipboard.SetText(textBox4.Text);
        }
    }
}
