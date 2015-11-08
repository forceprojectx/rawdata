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
    public partial class CEAsmConverter : Form
    {
        private string ptrn_CE_address_opcode = @"\s-\s([\sa-fA-F0-9]+)";

        Form1 parentForm = null;

        public CEAsmConverter()
        {
            InitializeComponent();
        }

        public CEAsmConverter(Form1 frm)
            : this()
        {
            
            parentForm = frm;
            cb_autoclose.Checked = Properties.Settings.Default.unity_autoclose;
           
        }

        /// <summary>
        /// generates instructions
        /// </summary>
        private void generateInstructions()
        {
            StringBuilder sb= new StringBuilder();
            bool error = false;

            foreach (string l in tb_data.Lines)
            {
                if (string.IsNullOrWhiteSpace(l)) { continue; }
                if (Regex.IsMatch(l, ptrn_CE_address_opcode))
                {
                    Match m = Regex.Match(l, ptrn_CE_address_opcode);

                    sb.Append("//");
                    sb.AppendLine(Misc.Helpers.HexToSpacedHex(m.Groups[1].Value));
                }
                sb.AppendLine(l);
            }

            if (!error)
            {
                if (cb_autoclose.Checked == true)
                {
                    //copy data to main form and close conversion window
                    ((Form1)parentForm).tb_ByteCodeInput.Text = sb.ToString();
                    this.Close();
                }
                else
                {
                    //set the tb_data text to data
                    tb_data.Text = sb.ToString();
                }
            }
            
        }

        /// <summary>
        /// handle generate instructions button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            generateInstructions();
        }


        /// <summary>
        /// display a sample
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sample_Click(object sender, EventArgs e)
        {
            tb_data.Text = @"001CA564 - 6A 6D - push 6D
001CA566 - 8B CE  - mov ecx,esi
001CA568 - 89 86 581B0000  - mov [esi+00001B58],eax <<
001CA56E - E8 0D980000 - call isaac-ng.epoxy_handle_external_wglMakeCurrent+102D40
001CA573 - 84 C0  - test al,al

EAX=00000001
EBX=00000158
ECX=117D1128
EDX=11418960
ESI=117D1128
EDI=00000000
ESP=0078F498
EBP=0078F4AC
EIP=001CA56E
";
        }
    }
}
