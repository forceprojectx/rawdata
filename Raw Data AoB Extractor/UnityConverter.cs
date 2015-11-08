using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Windows.Forms;

namespace Raw_Data_AoB_Extractor
{
    public partial class UnityConverter : Form
    {
        internal Hashtable codeTable = new Hashtable();

        Form1 parentForm = null;
        public UnityConverter()
        {
            InitializeComponent();
            cb_autoclose.Checked = Properties.Settings.Default.unity_autoclose;
            cb_metadata.Checked = Properties.Settings.Default.unity_keepMetadata;
            cb_resolveBranches.Checked = Properties.Settings.Default.unity_resolveBranches;
            populateTable();
        }

        public UnityConverter(Form1 frm):this()
        {
            parentForm = frm;
        }

        #region hash table codes
        //private void getCodesFromWiki()
        //{
        //    tb_data.Text = "";
        //    string data = string.Empty;
        //    string temp = string.Empty;
        //    HtmlElementCollection table = webBrowser1.Document.GetElementsByTagName("table");
        //    HtmlElementCollection trows = table[0].GetElementsByTagName("tr");
        //    data += trows.Count + Environment.NewLine;
        //    foreach (HtmlElement row in trows)
        //    {
        //        //data += row.InnerText+Environment.NewLine;
        //        HtmlElementCollection tcols = row.GetElementsByTagName("td");
        //        //key, value
        //        if (tcols.Count >= 2)
        //        {
        //            Match m = Regex.Match(tcols[1].InnerText, @"^([\w\.]+)\s*(<.*?(\d+) \()*");
        //            int x = 0;
        //            try
        //            {
        //                temp = m.Groups[3].Value;
        //                if(temp!=null && temp.Length>0)
        //                x = Convert.ToInt32(temp) / 8;                        
        //            }
        //            catch (Exception e)
        //            {
        //                //System.Diagnostics.Debug.WriteLine(e.Message);
        //            }
        //            data += "codeTable.Add(\"" + m.Groups[1].Value + "\", ";
        //            data += "\"" + tcols[0].InnerText.Replace("0x", "") + "|" + x + "\");//"+m.Groups[2].Value;
        //            data += Environment.NewLine;
        //        }
        //    }
        //    tb_data.Text = data;
        //}
        private void populateTable()
        {
            codeTable.Add("nop", "00");
            codeTable.Add("break", "01");
            codeTable.Add("ldarg.0", "02");
            codeTable.Add("ldarg.1", "03");
            codeTable.Add("ldarg.2", "04");
            codeTable.Add("ldarg.3", "05");
            codeTable.Add("ldloc.0", "06");
            codeTable.Add("ldloc.1", "07");
            codeTable.Add("ldloc.2", "08");
            codeTable.Add("ldloc.3", "09");
            codeTable.Add("stloc.0", "0A");
            codeTable.Add("stloc.1", "0B");
            codeTable.Add("stloc.2", "0C");
            codeTable.Add("stloc.3", "0D");
            codeTable.Add("ldarg.s", "0E");
            codeTable.Add("ldarga.s", "0F");
            codeTable.Add("starg.s", "10");
            codeTable.Add("ldloc.s", "11");
            codeTable.Add("ldloca.s", "12");
            codeTable.Add("stloc.s", "13");
            codeTable.Add("ldnull", "14");
            codeTable.Add("ldc.i4.m1", "15");
            codeTable.Add("ldc.i4.M1", "15");
            codeTable.Add("ldc.i4.0", "16");
            codeTable.Add("ldc.i4.1", "17");
            codeTable.Add("ldc.i4.2", "18");
            codeTable.Add("ldc.i4.3", "19");
            codeTable.Add("ldc.i4.4", "1A");
            codeTable.Add("ldc.i4.5", "1B");
            codeTable.Add("ldc.i4.6", "1C");
            codeTable.Add("ldc.i4.7", "1D");
            codeTable.Add("ldc.i4.8", "1E");
            codeTable.Add("ldc.i4.s", "1F");
            codeTable.Add("ldc.i4", "20");
            codeTable.Add("ldc.i8", "21");
            codeTable.Add("ldc.r4", "22");
            codeTable.Add("ldc.r8", "23");
            codeTable.Add("dup", "25");
            codeTable.Add("pop", "26");
            codeTable.Add("jmp", "27");
            codeTable.Add("call", "28");
            codeTable.Add("calli", "29");
            codeTable.Add("ret", "2A");
            codeTable.Add("br.s", "2B");
            codeTable.Add("brfalse.s", "2C");
            codeTable.Add("brnull.s", "2C");
            codeTable.Add("brzero.s", "2C");
            codeTable.Add("brinst.s", "2D");
            codeTable.Add("brtrue.s", "2D");
            codeTable.Add("beq.s", "2E");
            codeTable.Add("bge.s", "2F");
            codeTable.Add("bgt.s", "30");
            codeTable.Add("ble.s", "31");
            codeTable.Add("blt.s", "32");
            codeTable.Add("bne.un.s", "33");
            codeTable.Add("bge.un.s", "34");
            codeTable.Add("bgt.un.s", "35");
            codeTable.Add("ble.un.s", "36");
            codeTable.Add("blt.un.s", "37");
            codeTable.Add("br", "38");
            codeTable.Add("brfalse", "39");
            codeTable.Add("brnull", "39");
            codeTable.Add("brzero", "39");
            codeTable.Add("brinst", "3A");
            codeTable.Add("brtrue", "3A");
            codeTable.Add("beq", "3B");
            codeTable.Add("bge", "3C");
            codeTable.Add("bgt", "3D");
            codeTable.Add("ble", "3E");
            codeTable.Add("blt", "3F");
            codeTable.Add("bne.un", "40");
            codeTable.Add("bge.un", "41");
            codeTable.Add("bgt.un", "42");
            codeTable.Add("ble.un", "43");
            codeTable.Add("blt.un", "44");
            codeTable.Add("switch", "45");
            codeTable.Add("ldind.i1", "46");
            codeTable.Add("ldind.u1", "47");
            codeTable.Add("ldind.i2", "48");
            codeTable.Add("ldind.u2", "49");
            codeTable.Add("ldind.i4", "4A");
            codeTable.Add("ldind.u4", "4B");
            codeTable.Add("idind.u8", "4C");
            codeTable.Add("ldind.i8", "4C");
            codeTable.Add("ldind.i", "4D");
            codeTable.Add("ldind.r4", "4E");
            codeTable.Add("ldind.r8", "4F");
            codeTable.Add("ldind.ref", "50");
            codeTable.Add("stind.ref", "51");
            codeTable.Add("stind.i1", "52");
            codeTable.Add("stind.i2", "53");
            codeTable.Add("stind.i4", "54");
            codeTable.Add("stind.i8", "55");
            codeTable.Add("stind.r4", "56");
            codeTable.Add("stind.r8", "57");
            codeTable.Add("add", "58");
            codeTable.Add("sub", "59");
            codeTable.Add("mul", "5A");
            codeTable.Add("div", "5B");
            codeTable.Add("div.un", "5C");
            codeTable.Add("rem", "5D");
            codeTable.Add("rem.un", "5E");
            codeTable.Add("and", "5F");
            codeTable.Add("or", "60");
            codeTable.Add("xor", "61");
            codeTable.Add("shl", "62");
            codeTable.Add("shr", "63");
            codeTable.Add("shr.un", "64");
            codeTable.Add("neg", "65");
            codeTable.Add("not", "66");
            codeTable.Add("conv.i1", "67");
            codeTable.Add("conv.i2", "68");
            codeTable.Add("conv.i4", "69");
            codeTable.Add("conv.i8", "6A");
            codeTable.Add("conv.r4", "6B");
            codeTable.Add("conv.r8", "6C");
            codeTable.Add("conv.u4", "6D");
            codeTable.Add("conv.u8", "6E");
            codeTable.Add("callvirt", "6F");
            codeTable.Add("cpobj", "70");
            codeTable.Add("ldobj", "71");
            codeTable.Add("ldstr", "72");
            codeTable.Add("newobj", "73");
            codeTable.Add("castclass", "74");
            codeTable.Add("isinst", "75");
            codeTable.Add("conv.r.un", "76");
            codeTable.Add("unbox", "79");
            codeTable.Add("throw", "7A");
            codeTable.Add("ldfld", "7B");
            codeTable.Add("ldflda", "7C");
            codeTable.Add("stfld", "7D");
            codeTable.Add("ldsfld", "7E");
            codeTable.Add("ldsflda", "7F");
            codeTable.Add("stsfld", "80");
            codeTable.Add("stobj", "81");
            codeTable.Add("conv.ovf.i1.un", "82");
            codeTable.Add("conv.ovf.i2.un", "83");
            codeTable.Add("conv.ovf.i4.un", "84");
            codeTable.Add("conv.ovf.i8.un", "85");
            codeTable.Add("conv.ovf.u1.un", "86");
            codeTable.Add("conv.ovf.u2.un", "87");
            codeTable.Add("conv.ovf.u4.un", "88");
            codeTable.Add("conv.ovf.u8.un", "89");
            codeTable.Add("conv.ovf.i.un", "8A");
            codeTable.Add("conv.ovf.u.un", "8B");
            codeTable.Add("box", "8C");
            codeTable.Add("newarr", "8D");
            codeTable.Add("ldlen", "8E");
            codeTable.Add("ldelema", "8F");
            codeTable.Add("ldelem.i1", "90");
            codeTable.Add("ldelem.u1", "91");
            codeTable.Add("ldelem.i2", "92");
            codeTable.Add("ldelem.u2", "93");
            codeTable.Add("ldelem.i4", "94");
            codeTable.Add("ldelem.u4", "95");
            codeTable.Add("ldelem.i8", "96");
            codeTable.Add("ldelem.u8", "96");
            codeTable.Add("ldelem.i", "97");
            codeTable.Add("ldelem.r4", "98");
            codeTable.Add("ldelem.r8", "99");
            codeTable.Add("ldelem.ref", "9A");
            codeTable.Add("stelem.i", "9B");
            codeTable.Add("stelem.i1", "9C");
            codeTable.Add("stelem.i2", "9D");
            codeTable.Add("stelem.i4", "9E");
            codeTable.Add("stelem.i8", "9F");
            codeTable.Add("stelem.r4", "A0");
            codeTable.Add("stelem.r8", "A1");
            codeTable.Add("stelem.ref", "A2");
            codeTable.Add("ldelem", "A3");
            codeTable.Add("stelem", "A4");
            codeTable.Add("unbox.any", "A5");
            codeTable.Add("conv.ovf.i1", "B3");
            codeTable.Add("conv.ovf.u1", "B4");
            codeTable.Add("conv.ovf.i2", "B5");
            codeTable.Add("conv.ovf.u2", "B6");
            codeTable.Add("conv.ovf.i4", "B7");
            codeTable.Add("conv.ovf.u4", "B8");
            codeTable.Add("conv.ovf.i8", "B9");
            codeTable.Add("conv.ovf.u8", "BA");
            codeTable.Add("refanyval", "C2");
            codeTable.Add("ckfinite", "C3");
            codeTable.Add("mkrefany", "C6");
            codeTable.Add("ldtoken", "D0");
            codeTable.Add("conv.u2", "D1");
            codeTable.Add("conv.u1", "D2");
            codeTable.Add("conv.i", "D3");
            codeTable.Add("conv.ovf.i", "D4");
            codeTable.Add("conv.ovf.u", "D5");
            codeTable.Add("add.ovf", "D6");
            codeTable.Add("add.ovf.un", "D7");
            codeTable.Add("mul.ovf.", "D8");
            codeTable.Add("mul.ovf.un", "D9");
            codeTable.Add("sub.ovf", "DA");
            codeTable.Add("sub.ovf.un", "DB");
            codeTable.Add("endfault", "DC");
            codeTable.Add("endfinally", "DC");
            codeTable.Add("leave", "DD");
            codeTable.Add("leave.s", "DE");
            codeTable.Add("stind.i", "DF");
            codeTable.Add("conv.u", "E0");
            codeTable.Add("arglist", "FE 00");
            codeTable.Add("ceq", "FE 01");
            codeTable.Add("cgt", "FE 02");
            codeTable.Add("cgt.un", "FE 03");
            codeTable.Add("clt", "FE 04");
            codeTable.Add("clt.un", "FE 05");
            codeTable.Add("ldftn", "FE 06");
            codeTable.Add("ldvirtftn", "FE 07");
            codeTable.Add("ldarg", "FE 09");
            codeTable.Add("ldarga", "FE 0A");
            codeTable.Add("starg", "FE 0B");
            codeTable.Add("ldloc", "FE 0C");
            codeTable.Add("ldloca", "FE 0D");
            codeTable.Add("stloc", "FE 0E");
            codeTable.Add("localloc", "FE 0F");
            codeTable.Add("endfilter", "FE 11");
            codeTable.Add("unaligned.", "FE 12");
            codeTable.Add("volatile.", "FE 13");
            codeTable.Add("tail.", "FE 14");
            codeTable.Add("initobj", "FE 15");
            codeTable.Add("constrained.", "FE 16");
            codeTable.Add("cpblk", "FE 17");
            codeTable.Add("initblk", "FE 18");
            codeTable.Add("no.", "FE 19");
            codeTable.Add("rethrow", "FE 1A");
            codeTable.Add("sizeof", "FE 1C");
            codeTable.Add("refanytype", "FE 1D");
            codeTable.Add("readonly.", "FE 1E");

        }
        #endregion

        #region process ILDASM data

        //remove the newline after commas
        private void PREprocessILDASM()
        {
            string data = string.Empty;
            string temp=string.Empty;
            for (int i = 0; i < tb_data.Lines.Length; i++)
            {
                temp = tb_data.Lines[i].Trim();
                
                if (temp == string.Empty) continue;
                if (temp[temp.Length-1]==',')
                {

                    data += temp;
                    continue;
                }
                else
                {
                    data += temp + Environment.NewLine;
                }
            }
            tb_data.Text = data;
            data = null;

        }
        private void processILDASM(bool keepMetaData=true)
        {
            PREprocessILDASM();
            //get lengths of instructions to determine wildcard lengths
            List<int> il = new List<int>();
            GetInstructionLengths(ref il);

            string data = string.Empty;
            //string ptrn = @"IL_([a-zA-Z\d]{4}):\s+(?/\*\s+([\w\d\.]+)";

            //-------------group 1 is OPERATION NUMBER, group 2 is the proper bytes, group 3 is the instruction name
            string ptrn = @"L_([a-fA-F\d]{4}):(\s+/\*.+\*/)*\s+([\w\d\.]+)\s*(.*)";
            Match m;//,m2;
            int positionCurrent=1,positionPrevious=0,linecount=0, instructionLengthCorrection=0;
            string instruction = string.Empty, ExplicitBytes=string.Empty;
            foreach(string line in tb_data.Lines)
            {
                
                if (Regex.IsMatch(line, ptrn))
                {
                    
                    m = Regex.Match(line, ptrn);
                    positionCurrent = Convert.ToInt32(m.Groups[1].Value, 16);

                    //see if instruction is in the table, if not add error instead
                    if (codeTable.ContainsKey(m.Groups[3].Value))
                    {
                        instruction = (string)codeTable[m.Groups[3].Value];
                        if (instruction.Length > 2)
                        {
                            instructionLengthCorrection = (int)(instruction.Length / 2) - 1;
                        }
                        else
                        {
                            instructionLengthCorrection = 0;
                        }
                        //add bytecode
                        data += "//" + instruction;
                        //add possible explicit (nonwildcard) bytes
                        ExplicitBytes = "  " + m.Groups[2].Value.Replace(" ", "") + Environment.NewLine;
                    }
                    else
                    {
                        data += "**ERROR::opcode not found";
                        continue;
                    }



                    //add wildcards for instructions longer than 1 byte
                    if (linecount < il.Count - 1)
                    {
                        for (int i = 1; (i < (il[linecount + 1] - instructionLengthCorrection - il[linecount])) /*&& i < 50*/; i++)
                        {
                            data += " ??";
                        }
                        data += ExplicitBytes;
                        ExplicitBytes = string.Empty;
                    }
                    else
                    {
                        data += ExplicitBytes;
                        ExplicitBytes = string.Empty;
                    }

                    //add line of p-code
                    /*if (positionPrevious == 0) data += Environment.NewLine;*/
                    if (keepMetaData)
                    {
                        data += String.Format("IL_{0,4}: {1,-10}{2}", m.Groups[1].Value, m.Groups[3].Value, m.Groups[4].Value.Replace('/',':')) + Environment.NewLine;
                    }
                    else
                    {
                        data += String.Format("IL_{0,4}: {1,-8}", m.Groups[1].Value, m.Groups[3].Value) + Environment.NewLine;
                    }
                    //set previousposition to currentposition
                    positionPrevious = positionCurrent;

                   
                    linecount++;
                }
                else
                {
                    //this line doesnt have an opcode in it, so skip it
                    data += /*Environment.NewLine+*/ line.Replace('/','#') + Environment.NewLine;
                }
                
            }//end forloop

            //clear the instruction list
            il.Clear();
            //add the last line of pcode to data
            data += tb_data.Lines[tb_data.Lines.Length - 1];


            if (cb_autoclose.Checked == true)
            {
                //copy data to main form and close conversion window
                if (parentForm != null)
                {
                    ((Form1)parentForm).tb_ByteCodeInput.Text = data;
                    this.Close();
                }
            }
            else
            {
                //set the tb_data text to data
                tb_data.Text = data;
            }
        }

        private void processILDASMWithBranchResolution(bool keepMetaData = true)
        {
            PREprocessILDASM();
            //get lengths of instructions to determine wildcard lengths
            List<int> il = new List<int>();
            GetInstructionLengths(ref il);

            string data = string.Empty;
            //string ptrn = @"IL_([a-zA-Z\d]{4}):\s+(?/\*\s+([\w\d\.]+)";

            //-------------group 1 is OPERATION NUMBER, group 2 is the proper bytes, group 3 is the instruction name
            string ptrn = @"L_([a-fA-F\d]{4}):(\s+/\*.+\*/)*\s+([\w\d\.]+)\s*(.*)";
            string ptrn_branchTarget = @"L_([a-fA-F\d]{4})";
            Match m;//,m2;
            int positionCurrent = 1, positionPrevious = 0, linecount = 0, instructionLengthCorrection = 0;
            string instruction = string.Empty, ExplicitBytes = string.Empty;
            bool isbranch = false;

            foreach (string line in tb_data.Lines)
            {

                if (Regex.IsMatch(line, ptrn))
                {

                    m = Regex.Match(line, ptrn);
                    positionCurrent = Convert.ToInt32(m.Groups[1].Value, 16);

                    //see if instruction is in the table, if not add error instead
                    if (codeTable.ContainsKey(m.Groups[3].Value))
                    {
                        instruction = (string)codeTable[m.Groups[3].Value];
                        if (instruction.Length > 2)
                        {
                            instructionLengthCorrection = (int)(instruction.Length / 2) - 1;
                        }
                        else
                        {
                            instructionLengthCorrection = 0;
                            //check if this is a branch command
                            uint opcodeINTVAL = Convert.ToUInt32(instruction, 16);
                            if (opcodeINTVAL > 0x37 && opcodeINTVAL < 0x45)
                            {
                                //attempt to resolve branch statement....                                
                                if (Regex.IsMatch(m.Groups[4].Value, ptrn_branchTarget))
                                {
                                    isbranch = true; //so we dont print  wild cards
                                    int branchTo = Convert.ToInt32(Regex.Match(m.Groups[4].Value,ptrn_branchTarget).Groups[1].Value, 16);
                                    int branchValue = branchTo - (il[linecount] + 5);//+5 because instruction length
                                    instruction = instruction + " " + BitConverter.ToString(BitConverter.GetBytes(branchValue)).Replace('-', ' ');

                                }
                                else
                                {
                                    isbranch = false;//branch resolution failed, need to print wildcards
                                }
                            }
                            else
                            {
                                isbranch = false;
                            }
                        }
                        //add bytecode
                        data += "//" + instruction;
                        //add possible explicit (nonwildcard) bytes
                        ExplicitBytes = "  " + m.Groups[2].Value.Replace(" ", "") + Environment.NewLine;
                    }
                    else
                    {
                        data += "**ERROR::opcode not found";
                        continue;
                    }



                    //add wildcards for instructions longer than 1 byte
                    if (linecount < il.Count - 1 && !isbranch)
                    {
                        for (int i = 1; (i < (il[linecount + 1] - instructionLengthCorrection - il[linecount])) /*&& i < 50*/; i++)
                        {
                            data += " ??";
                        }
                        data += ExplicitBytes;
                        ExplicitBytes = string.Empty;
                    }
                    else
                    {
                        data += ExplicitBytes;
                        ExplicitBytes = string.Empty;
                    }

                    //add line of p-code
                    /*if (positionPrevious == 0) data += Environment.NewLine;*/
                    if (keepMetaData)
                    {
                        data += String.Format("IL_{0,4}: {1,-10}{2}", m.Groups[1].Value, m.Groups[3].Value, m.Groups[4].Value.Replace('/', ':')) + Environment.NewLine;
                    }
                    else
                    {
                        data += String.Format("IL_{0,4}: {1,-8}", m.Groups[1].Value, m.Groups[3].Value) + Environment.NewLine;
                    }
                    //set previousposition to currentposition
                    positionPrevious = positionCurrent;


                    linecount++;
                }
                else
                {
                    //this line doesnt have an opcode in it, so skip it
                    data += /*Environment.NewLine+*/ line.Replace('/', '#') + Environment.NewLine;
                }

            }//end forloop

            //clear the instruction list
            il.Clear();
            //add the last line of pcode to data
            data += tb_data.Lines[tb_data.Lines.Length - 1];


            if (cb_autoclose.Checked == true)
            {
                //copy data to main form and close conversion window
                if (parentForm != null)
                {
                    ((Form1)parentForm).tb_ByteCodeInput.Text = data;
                    this.Close();
                }
            }
            else
            {
                //set the tb_data text to data
                tb_data.Text = data;
            }
        }//end process ildasm with branch resolution

        private void GetInstructionLengths(ref List<int> il)
        {
            //-------------group 1 is OPERATION NUMBER, group 2 is the proper bytes, group 3 is the instruction name
            string ptrn = @"L_([a-fA-F\d]{4}):(\s+/\*.+\*/)*\s+([\w\d\.]+)\s*(.*)";
            Match m;//,m2;
            foreach (string line in tb_data.Lines)
            {
                if (Regex.IsMatch(line, ptrn))
                {
                    m = Regex.Match(line, ptrn);
                    il.Add( Convert.ToInt32(m.Groups[1].Value, 16));
                }                
            }//end forloop
        }
        #endregion

        #region buttons n such
        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_data.TextLength < 2)
                return;
            if (cb_resolveBranches.Checked)
            {
                processILDASMWithBranchResolution(cb_metadata.Checked);
            }
            else
            {
                processILDASM(cb_metadata.Checked);
            }
            //getCodesFromWiki();
        }

        private void tb_data_DoubleClick(object sender, EventArgs e)
        {
            tb_data.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (parentForm != null)
            {
                ((Form1)parentForm).tb_ByteCodeInput.Text = tb_data.Text;
            }
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                tb_data.Text = Clipboard.GetText();
            }
            catch (Exception err)
            {
                System.Diagnostics.Debug.WriteLine(err.Message);
            }
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_data.Focus();
            tb_data.SelectAll();
        }
        #endregion

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //getCodesFromWiki();
        }

        private void UnityConverter_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("saving settings");
            Properties.Settings.Default.unity_resolveBranches = cb_resolveBranches.Checked;
            Properties.Settings.Default.unity_keepMetadata = cb_metadata.Checked;
            Properties.Settings.Default.unity_autoclose = cb_autoclose.Checked;
            Properties.Settings.Default.Save();

        }

        

        
    }
}
