using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Raw_Data_AoB_Extractor
{
    public partial class rootvar : Form
    {
        public rootvar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String p = @"[a-fA-F0-9]{8}";
            if (!Regex.IsMatch(textBox1.Text,p))
            {
                textBox1.BackColor = Color.Crimson;
            }
            else
            {
                textBox1.BackColor = Color.White;
                textBox2.Text = "" + textBox1.Text[6] + textBox1.Text[7] + textBox1.Text[4] + textBox1.Text[5] + textBox1.Text[2] + textBox1.Text[3] + textBox1.Text[0] + textBox1.Text[1];
                textBox3.Text= (Int32.Parse(textBox1.Text, System.Globalization.NumberStyles.HexNumber)-7).ToString("X8");

            }

        }


    }
}
