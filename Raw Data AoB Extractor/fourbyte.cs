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
    public partial class fourbyte : Form
    {
        private ByteConverter _converter;
        public fourbyte()
        {
            InitializeComponent();            
        }
        private void fourbyte_Load(object sender, EventArgs e)
        {
            _converter = new ByteConverter();
            textBox1.DataBindings.Add("Text", _converter, "four_byte", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text", _converter, "four_byte_X8", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox3.DataBindings.Add("Text", _converter, "four_byte_X8_P6", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox4.DataBindings.Add("Text", _converter, "Hex",true, DataSourceUpdateMode.OnPropertyChanged,0,"X");
            textBox5.DataBindings.Add("Text", _converter, "U30", true, DataSourceUpdateMode.OnPropertyChanged,0,"X");
            tb_floatHex.DataBindings.Add("Text", _converter, "ieee754x32", true, DataSourceUpdateMode.OnPropertyChanged, 0, "X");
            tb_doubleHex.DataBindings.Add("Text", _converter, "ieee754x64", true, DataSourceUpdateMode.OnPropertyChanged, 0, "X");
            tb_unityFloat.DataBindings.Add("Text", _converter, "unityIeee754x32", true, DataSourceUpdateMode.OnPropertyChanged, 0, "X");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            
            //if (Regex.IsMatch(textBox1.Text, @"^-*\d+$"))
            //{
            //    textBox1.BackColor = Color.White;
            //    textBox2.Text = "" + (int.Parse(textBox1.Text) * 8);
            //    textBox3.Text = "" + ((int.Parse(textBox1.Text) * 8) + 6);
            //    textBox4.Text = int.Parse(textBox1.Text).ToString("X");
            //    convertU30();
            //}
            //else
            //{
            //    textBox1.BackColor = Color.Red;
            //}
    
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            label4.Text = "4Byte*1 Copied to Clipboard";
            label4.Visible = true;
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
            label4.Text = "4Byte*8 Copied to Clipboard";
            label4.Visible = true;
        }

        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
            label4.Text = "4Byte*8+6 Copied to Clipboard";
            label4.Visible = true;
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox4.Text);
            label4.Text = "0x16 Copied to Clipboard";
            label4.Visible = true;
        }

        private void textBox5_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox5.Text);
            label4.Text = "u30 Copied to Clipboard";
            label4.Visible = true;
        }
        private void tb_floatHex_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_floatHex.Text);
            label4.Text = "IEEE 754 32 bit Copied to Clipboard";
            label4.Visible = true;
        }

        private void tb_unityFloat_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_unityFloat.Text);
            tb_unityFloat.SelectAll();
            label4.Text = "Unity float Copied to Clipboard";
            label4.Visible = true;
        }

        private void tb_doubleHex_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_doubleHex.Text);
            label4.Text = "IEEE 754 64 bit Copied to Clipboard";
            label4.Visible = true;
        }
        private void convertU30()
        {
            if (int.Parse(textBox1.Text) < 1)
                return;
            //string bin = int.Parse(textBox1.Text).ToString("2");
            string bin = (Convert.ToString(int.Parse(textBox1.Text), 2));
            string swappedbin = "";
            Console.WriteLine(bin);
            while (bin.Length > 0)
            {
                if (bin.Length > 7)
                {
                    swappedbin += "1" + bin.Substring(bin.Length - 7);
                    bin = bin.Substring(0, bin.Length - 7);
                }
                else
                {
                    while (bin.Length < 8)
                        bin = "0" + bin;
                    swappedbin += bin;
                    bin = "";
                }
            }
            Console.WriteLine(swappedbin);

            textBox5.Text = Convert.ToInt32(swappedbin, 2).ToString("X");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Validating box 1");
            //if (textBox1.Text != "")
            //{
            //    try
            //    {
            //        Convert.ToInt32(textBox1.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Invalid Entry, Must be Numeric", "Error");
            //    }
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Nothing entered in myTextBox", "Error");
            //}
            //e.Cancel = true;
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine("Validating box 2");
            //if (textBox1.Text != "")
            //{
            //    try
            //    {
            //        Convert.ToInt32(textBox1.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Invalid Entry, Must be Numeric", "Error");
            //    }
            //    return;
            //}
            //else
            //{
            //    MessageBox.Show("Nothing entered in myTextBox", "Error");
            //}
            //e.Cancel = true;
        }

        

        



               
    }
}
