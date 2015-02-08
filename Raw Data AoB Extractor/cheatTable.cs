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
    public partial class cheatTable : Form
    {


        public cheatTable()
        {
            InitializeComponent();
        }

        private void tbOutput_DoubleClick(object sender, EventArgs e)
        {
            if (tbOutput.Text == "" || tbOutput.Text == null)
                return;//getaobs("button2");
            tbOutput.SelectAll();
            Clipboard.SetText(tbOutput.Text);
        }

        private void createOutput(object sender, EventArgs e)
        {
            if (tbaob1.Text.Trim().Length != tbaob2.Text.Trim().Length || (tbaob2.Text == "" || tbaob2.Text == null || tbaob1.Text == "" || tbaob1.Text == null))
            {
                return;
            }
            tbOutput.Text = MakeAOBTable(tbaob1.Text, tbaob2.Text);

        }

        public static string MakeAOBTable(string search, string replace)
        {
            if (!replace.Contains("?"))
            {
                return "[ENABLE]" + Environment.NewLine + "Aobscan(_fpx," + search + ")" +  Environment.NewLine + "" + Environment.NewLine 
                    + "_fpx:" + Environment.NewLine + "db " + replace + " " + Environment.NewLine + "" + Environment.NewLine + "[DISABLE]" ;
            }
            else
            {
                //strip out any ??
                String nopregex = @"(?-m)^([a-fA-F0-9?]{2}\s*)+$";

                string ret = "[ENABLE]" + Environment.NewLine + "Aobscan(_fpx," + search + ")" + Environment.NewLine;
                try
                {
                    CaptureCollection bytes = Regex.Matches(replace.Trim(), nopregex)[0].Groups[1].Captures;
                    bool isWild = true;
                    for (int i = 0; i < bytes.Count; i++)
                    {
                        string b = bytes[i].Value.Trim();
                        System.Diagnostics.Debug.WriteLine(string.Format("byte {0}:: |{1}|", i, b));
                        if (b.Equals("??"))
                        {
                            if (isWild)
                            {
                                continue;
                            }
                            else
                            {
                                //wildcard byte
                                isWild = true;
                                continue;
                            }
                        }
                        else
                        {
                            //not a wildcard byte...
                            if (isWild)
                            {
                                //we need to start a new myvar+count label
                                isWild = false;
                                ret += Environment.NewLine + ((i == 0) ? "_fpx:" : String.Format("_fpx+{0:X}:", i))
                                    + Environment.NewLine + "db ";
                                ret += b;
                            }
                            else
                            {
                                //just need to add the byte
                                ret += " " + b;
                            }
                        }
                    }

                    /*
                     * 
                     * now we do the 
                     * DISABLE
                     * 
                     */
                    if (!search.Contains("?"))
                    {
                        ret += Environment.NewLine + "" + Environment.NewLine + "[DISABLE]";
                    }
                    else
                    {
                        ret += Environment.NewLine + "" + Environment.NewLine + "[DISABLE]";                        
                    }

                    return ret;
                }
                catch (Exception e)
                {
                    return "error::" + e.Message;
                }
            }
        }

    }
}
