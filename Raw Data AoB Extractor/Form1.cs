using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Raw_Data_AoB_Extractor
{
    
    public partial class Form1 : Form
    {
        private int[] IGNORE_OPS = { 0x24, 0x25, 0x0c, 0x0d, 0x0e, 0x0f, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1a };
        private String aobregex = @"^(?:(?:;\s)|(?://)|(?:/))(([a-fA-F0-9?]{2}\s*)+)(.*)";
        private String nopregex = @"(?-m)^([a-fA-F0-9?]{2}\s*)+$";
        public Form1()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine(this.Name);
        }

        #region form event handlers
        private void Form1_Load(object sender, EventArgs e)
        {
            int style = Raw_Data_AoB_Extractor.Properties.Settings.Default.Style;
            switch (style)
            {
                case 0: rb_BBCODE.Checked = true; break;
                case 1: rb_html.Checked = true; break;
                case 2: rb_none.Checked = true; break;
            }
            tb_ByteCodeInput.Font = Raw_Data_AoB_Extractor.Properties.Settings.Default.defaultfont;
            tb_ByteCodeEdit.Font = Raw_Data_AoB_Extractor.Properties.Settings.Default.defaultfont;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rb_BBCODE.Checked)
            {
                Raw_Data_AoB_Extractor.Properties.Settings.Default.Style = 0;
            }
            else if (rb_html.Checked)
            {
                Raw_Data_AoB_Extractor.Properties.Settings.Default.Style = 1;
            }
            else
            {
                Raw_Data_AoB_Extractor.Properties.Settings.Default.Style = 2;
            }
            Raw_Data_AoB_Extractor.Properties.Settings.Default.defaultfont = tb_ByteCodeEdit.Font;
            Raw_Data_AoB_Extractor.Properties.Settings.Default.Save();

        }
        private void tb_ByteCodeInputBox_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                return;
            }
            highlightboxes();
        }

        #region richtextbox2 highlighting listeners       

        private void tb_ByteCodeEditBoxHighlightListener(object sender, EventArgs e)
        {
            if (checkBox1.Checked){highlightboxes(false);}
        }        
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                highlightboxes();
                highlightboxes(false);
            }
            else
            {
                string x = tb_ByteCodeInput.Text;
                tb_ByteCodeInput.Text = string.Empty;
                tb_ByteCodeInput.SelectionColor = Color.Black;
                tb_ByteCodeInput.SelectedText = x;

                x = tb_ByteCodeEdit.Text;
                tb_ByteCodeEdit.Text = string.Empty;
                tb_ByteCodeEdit.SelectionColor = Color.Black;
                tb_ByteCodeEdit.SelectedText = x;

                x = null;
            }
        }

        private void btn_CopyToEditPane_Click(object sender, EventArgs e)
        {
            tb_ByteCodeEdit.Text = tb_ByteCodeInput.Text;
            if (checkBox1.Checked){highlightboxes(false);}
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("sender: " + ((Button)sender).Name);
            getaobs(((Button)sender).Name);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                tb_AoBFinalOutput.Text = "[ENABLE]\nAobscan(_fpx," + tb_AoBOrig.Text 
                    + ")\nlabel(fpx)\nregistersymbol(fpx)\n\n_fpx:\nfpx:\ndb " 
                    + tb_AoBEdited.Text + " \n\n[DISABLE]\nfpx:\ndb " + tb_AoBOrig.Text;
                if (tb_AoBOrig.Text.Trim().Length != tb_AoBEdited.Text.Trim().Length || (tb_AoBEdited.Text == "" || tb_AoBEdited.Text == null || tb_AoBOrig.Text == "" || tb_AoBOrig.Text == null))
                {
                    return;
                }
                tb_AoBFinalOutput.Text = cheatTable.MakeAOBTable(tb_AoBOrig.Text, tb_AoBEdited.Text);
            }
            else
            {
                getforumcode();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_AoBFinalOutput.Text);
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            getforumcode();
        }

        #region menus
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }
        private void checkForNewVersionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Updater updates = new Updater();
                System.Threading.Thread updateChecker = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(updates.threadmain));
                updateChecker.Name = "Update Agent";
                updateChecker.Start(true);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void rootVarAddressToolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rootvar rv = new rootvar();
            rv.Show();
        }
        private void aoBReverserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reverser rv = new Reverser();
            rv.Show();
        }
        private void cheatTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cheatTable ct = new cheatTable();
            ct.Show();
        }
        private void cE4byteCalcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fourbyte b =new fourbyte();
            b.Show();
        }
        private void CeByteExtractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CEAsmConverter ce = new CEAsmConverter(this);
            ce.Show();
        }

        private void iLDASMBytecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnityConverter uc = new UnityConverter(this);
            //uc.ParentForm = this;
            //this.chil
            uc.Show();
        }

        private void submitHackToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KongHack kh = new KongHack(tb_AoBOrig.Text,tb_AoBEdited.Text,tb_AoBTitle.Text);
            kh.ShowDialog();
        }
        private void openWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://konghack.com");
        }

        
        private void fontSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog1 = new FontDialog())
            {
                fontDialog1.ShowColor = false;

                fontDialog1.Font = tb_ByteCodeEdit.Font;                

                if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    tb_ByteCodeEdit.Font = fontDialog1.Font;
                    tb_ByteCodeInput.Font = fontDialog1.Font;
                    
                }
            }
        }

        private void mnemonicConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JavaConverter jc = new JavaConverter(this);
            jc.Show();
        }

        #region context menu options 
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_ByteCodeInput.Text = Clipboard.GetText();
        }
        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tb_ByteCodeEdit.SelectedText = Clipboard.GetText();
            if (checkBox1.Checked){highlightboxes(false);}
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_ByteCodeInput.Focus();
            tb_ByteCodeInput.SelectAll();
        }
        private void SelectionToNOPUnityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BulkModifySelection(sender, "00");
        }
        private void SelectionToNOPFlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BulkModifySelection(sender, "02");
        }
        private void selectionToWildcardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BulkModifySelection(sender, "??");
        }
        private void wildcardALLOperandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("calling bulk modify with operandonly=true");
            BulkModifySelection(sender, "??", true);
        }
        #endregion

        #endregion

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tb_AoBEdited.Text == "" || tb_AoBEdited.Text == null)
            {
                label2.Visible = false;
                tb_AoBEdited.BackColor = Color.White;
                return;
            }
            if (tb_AoBOrig.Text == "" || tb_AoBOrig.Text == null)
                getaobs("button2");
            if (tb_AoBEdited.Text.Length != tb_AoBOrig.Text.Length)
            {
                label2.Text = (tb_AoBEdited.Text.Length > tb_AoBOrig.Text.Length) ? ("Longer by: " + (tb_AoBEdited.Text.Length - tb_AoBOrig.Text.Length)) : ("Shorter by: " + (-1*(tb_AoBEdited.Text.Length - tb_AoBOrig.Text.Length)));
                label2.Visible = true;
                tb_AoBEdited.BackColor = Color.Crimson;
            }
            else
            {
                label2.Visible = false;
                tb_AoBEdited.BackColor = Color.White;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (tb_AoBOrig.Text == "" || tb_AoBOrig.Text == null)
                return;//getaobs("button2");
            label2.Text = "Selected AoB Copied to Clipboard"; label2.Visible = true;
            tb_AoBOrig.SelectAll();
            Clipboard.SetText(tb_AoBOrig.Text);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (tb_AoBEdited.Text == "" || tb_AoBEdited.Text == null)
                return;// getaobs("button3");
            label2.Text = "Selected AoB Copied to Clipboard"; label2.Visible = true;
            tb_AoBEdited.SelectAll();
            Clipboard.SetText(tb_AoBEdited.Text);
        }

        #endregion

        #region aob highlighting
        private const int WM_SETREDRAW      = 0x000B;
        private const int WM_USER           = 0x400;
        private const int EM_GETEVENTMASK   = (WM_USER + 59);
        private const int EM_SETEVENTMASK   = (WM_USER + 69);
        private const int WM_VSCROLL = 0x0115;
        public enum ScrollBarType : uint
        {
            SbHorz = 0,
            SbVert = 1,
            SbCtl = 2,
            SbBoth = 3
        }
        public enum ScrollBarCommands : uint
        {
            SB_THUMBPOSITION = 4
        }



        [DllImport("User32.dll")]
        public extern static int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("user32", CharSet = CharSet.Auto)]
        private extern static IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, IntPtr lParam);
        [DllImport("User32.dll")]
        public extern static int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="HighlightInputBox">TRUE for inputbox, FALSE for editbox</param>
        private void highlightboxes(bool HighlightInputBox=true)
        {
            RichTextBox highlightbox;
            int nPos = 0;
            if (HighlightInputBox)
            {
                tb_ByteCodeInput.TextChanged -= tb_ByteCodeInputBox_TextChanged;
                highlightbox = tb_ByteCodeInput;
            }
            else
            {
                highlightbox = tb_ByteCodeEdit;
            }

            IntPtr eventMask = IntPtr.Zero;
            try
            {
                // Stop redrawing:
                SendMessage(highlightbox.Handle, WM_SETREDRAW, 0, IntPtr.Zero);

                // Stop sending of events:
                eventMask = SendMessage(highlightbox.Handle, EM_GETEVENTMASK, 0, IntPtr.Zero);
                nPos = GetScrollPos(highlightbox.Handle, (int)ScrollBarType.SbVert);
                nPos <<= 16;
                

                // change colors and stuff in the RichTextBox
                Regex r = new Regex("\n");
                String[] lines = r.Split(highlightbox.Text);

                //Console.WriteLine("the text has changed.");
                highlightbox.Text = "";
                Color ErrColor = Color.FromArgb(43, 145, 175);
                Color xcolor = Color.Green;
                foreach (string l in lines)
                {
                    if (l.Length < 2)
                    {
                        continue;
                    }

                    if (Regex.IsMatch(l.Trim(), aobregex))
                    {

                        Match m = Regex.Match(l.Trim(), aobregex);
                        highlightbox.SelectionColor = xcolor;
                        highlightbox.SelectedText = "//" + m.Groups[1].Value;
                        highlightbox.SelectionColor = ErrColor;
                        highlightbox.SelectedText = m.Groups[3].Value + "\n";
                    }
                    else if (l.Contains("ERROR::opcode not found"))
                    {
                        highlightbox.SelectionColor = ErrColor;
                        highlightbox.SelectedText = l.Trim() + "\n";
                    }
                    else
                    {
                        highlightbox.SelectionColor = Color.Black;
                        highlightbox.SelectedText = l.Trim() + "\n";
                    }
                }
                highlightbox.SelectionColor = Color.Black;
                if (HighlightInputBox)
                {
                    tb_ByteCodeInput.TextChanged += tb_ByteCodeInputBox_TextChanged;
                }
                //highlightbox.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in highlighting:: " + e.Message, "Highlighting error");
            }
            finally
            {
                // turn on events
                SendMessage(highlightbox.Handle, EM_SETEVENTMASK, 0, eventMask);
                //reset position
                uint wParam = (uint)ScrollBarCommands.SB_THUMBPOSITION | (uint)nPos;
                SendMessage(highlightbox.Handle, WM_VSCROLL, new IntPtr(wParam), IntPtr.Zero);
                
                // turn on redrawing
                SendMessage(highlightbox.Handle, WM_SETREDRAW, 1, IntPtr.Zero);
            }
            //redraw the screen
            highlightbox.Refresh();
            
            
        }

#endregion

        #region Aob textbox updates

        private string getaobs(string sender, Boolean fromSelection=false)
        {
            
            Regex r = new Regex("\n");
            String[] lines;
            if (sender == "button2")
            {
                if (!fromSelection)
                {
                    lines = r.Split(tb_ByteCodeInput.Text);
                }
                else
                {
                    lines = r.Split(tb_ByteCodeInput.SelectedText);
                }
            }
            else
            {
                if (!fromSelection)
                {
                    lines = r.Split(tb_ByteCodeEdit.Text);
                }
                else
                {
                    lines = r.Split(tb_ByteCodeEdit.SelectedText);
                }
            }
            String aob = "";

            foreach (string l in lines)
            {
                    if (Regex.IsMatch(l.Trim(), aobregex))
                        aob += Regex.Replace(l.Trim(), aobregex, "$1").Trim() + " ";
            }
            if(fromSelection)
            {
                return Regex.Replace(aob,@"\s+"," ");
            }
            if (sender == "button2")
                tb_AoBOrig.Text = Regex.Replace(aob,@"\s+"," ");
            else
                tb_AoBEdited.Text = Regex.Replace(aob, @"\s+", " ");

            if (tb_AoBEdited.Text.Length != tb_AoBOrig.Text.Length)
            {
                int countOrig = (tb_AoBOrig.Text.Length >= 2) ? Regex.Matches(tb_AoBOrig.Text, nopregex)[0].Groups[1].Captures.Count : 0;
                int countEdit = (tb_AoBEdited.Text.Length >= 2) ? Regex.Matches(tb_AoBEdited.Text, nopregex)[0].Groups[1].Captures.Count : 0;
                label2.Text = (tb_AoBEdited.Text.Length > tb_AoBOrig.Text.Length) ? ("Longer by: " + (countEdit - countOrig)) : ("Shorter by: " + (-1 * (countEdit - countOrig)));
                label2.Visible = true;
                tb_AoBEdited.BackColor = Color.Crimson;
            }
            return string.Empty;
        }

       

        private void getforumcode()
        {
            String fc = "";
            if (rb_BBCODE.Checked)
                fc += "[b]" + tb_AoBTitle.Text + "[/b]" + Environment.NewLine;
            else if(rb_html.Checked)
                fc += "<strong>" + tb_AoBTitle.Text + "</strong><br />" + Environment.NewLine;
            else
                fc += tb_AoBTitle.Text + Environment.NewLine;
            if (tb_AoBOrig.Text == "" || tb_AoBOrig.Text == null)
            {
                getaobs("button2");
            }
            if (tb_AoBEdited.Text == "" || tb_AoBEdited.Text == null)
            {
                getaobs("button3");
            }
            if (rb_html.Checked)
            {
                fc += tb_AoBOrig.Text + "<br />" + Environment.NewLine;
                fc += tb_AoBEdited.Text + "<br />";
            }
            else
            {
                fc += tb_AoBOrig.Text + Environment.NewLine;
                fc += tb_AoBEdited.Text;
            }

            tb_AoBFinalOutput.Text = fc;
        }


        #endregion

        #region Nop/wildcard Selection context and code
        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (tb_ByteCodeEdit.SelectedText.Length < 2)
            {
                MenuStrip_EditPane.Items[0].Enabled = false;
                MenuStrip_EditPane.Items[1].Enabled = false;
            }
            else
            {
                MenuStrip_EditPane.Items[0].Enabled = true;
                MenuStrip_EditPane.Items[1].Enabled = true;
            }
        }
        private void MenuStrip_InputPane_Opening(object sender, CancelEventArgs e)
        {
            if (tb_ByteCodeInput.SelectedText.Length < 2)
            {
                MenuStrip_InputPane.Items[1].Enabled = false;
            }
            else
            {
                MenuStrip_InputPane.Items[1].Enabled = true;
            }
        }
        

        private void BulkModifySelection(object sender, string mod, bool operandOnly=false)
        {
            IntPtr eventMask = IntPtr.Zero;
            Regex rr = new Regex(@"\n");
            string[] lines;
            RichTextBox modbox;
            bool ignore_op = false;
            if (((ToolStripMenuItem)sender).Name.ToString().Contains("Input"))
            {
                modbox = tb_ByteCodeInput;
            }
            else
            {
                modbox = tb_ByteCodeEdit;
            }
            try
            {
                modbox.UseWaitCursor = true;

                // Stop redrawing:
                SendMessage(modbox.Handle, WM_SETREDRAW, 0, IntPtr.Zero);

                // Stop sending of events:
                eventMask = SendMessage(modbox.Handle, EM_GETEVENTMASK, 0, IntPtr.Zero);

                if (true == operandOnly)
                {
                    lines = modbox.Lines;
                }
                else
                {
                    lines = rr.Split(modbox.SelectedText);
                }
                String nop = "";
                foreach (string l in lines)
                {
                    string s = l.Trim();
                    if (!Regex.IsMatch(s, aobregex) && !Regex.IsMatch(s, nopregex))
                    {
                        if (nop.Length > 0)
                            nop += Environment.NewLine;
                        nop += s + Environment.NewLine;
                        continue;
                    }

                    Regex r = new Regex(@"\s");
                    String[] bytes = r.Split(s);
                    for (int i=0;i<bytes.Length;i++)
                    {
                        System.Diagnostics.Debug.WriteLine("got here");
                        if (bytes[i].Length < 2)
                        {                            
                            continue;
                        }
                        if (Regex.IsMatch(bytes[i].Trim(), aobregex))
                        {
                            if (nop.Length > 0)
                                nop += Environment.NewLine;
                            if (operandOnly == false)
                            {
                                nop += "//" + mod + " ";
                            }
                            else
                            {
                                nop += bytes[i]+" ";
                                System.Diagnostics.Debug.WriteLine(bytes[i].Substring(2));
                                ignore_op = IGNORE_OPS.Contains(Convert.ToInt32(bytes[i].Substring(2),16));
                            }
                        }
                        else if (Regex.IsMatch(bytes[i].Trim(), nopregex))
                        {
                            //dont replace if its an ignored operation
                            if (true == operandOnly && ignore_op)
                            {
                                nop += bytes[i] + " ";
                            }
                            else
                            {
                                nop += mod + " ";
                            }
                        }
                        else
                        {
                            nop += Environment.NewLine + bytes[i].Trim();
                        }
                    }
                }

                if (true == operandOnly)
                {
                    modbox.Text = nop;
                }
                else
                {
                    modbox.SelectedText = nop;
                }
                


            }
            catch (Exception e)
            {
                MessageBox.Show("Error Modifying selection:: " + e.Message, "modification error");
            }
            finally
            {
                // turn on events
                SendMessage(modbox.Handle, EM_SETEVENTMASK, 0, eventMask);

                // turn on redrawing
                SendMessage(modbox.Handle, WM_SETREDRAW, 1, IntPtr.Zero);

                modbox.UseWaitCursor = false;
            }
            if (modbox.Name.Contains("Input"))
            {
                //modbox.TextChanged -= tb_ByteCodeInputBox_TextChanged;

                //modbox.TextChanged += tb_ByteCodeInputBox_TextChanged;
                if (checkBox1.Checked)
                {
                    highlightboxes();
                }
            }
            else
            {
                if (checkBox1.Checked)
                {
                    highlightboxes(false);
                }
            }
        }

        private void tb_ByteCode_SelectionChanged(object sender, EventArgs e)
        {
            string aob=string.Empty;

            if (((RichTextBox)sender).Name.Contains("Input"))
            {
                aob = getaobs("button2", true);
            }
            else
            {
                aob = getaobs("button3", true);
            }
            if (aob.Length >= 2)
            {
                int aobcount = Regex.Matches(aob, nopregex)[0].Groups[1].Captures.Count;
                selectedBytesToolStripMenuItem.Text = string.Format("Selected 0x{0:X} ({0}) octets", aobcount);
                selectedBytesToolStripMenuItem.Visible = true;
            }
            else
            {
                selectedBytesToolStripMenuItem.Visible = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        

        


        
        

        
        //end selection to wildcard

        
        #endregion


    }
}
