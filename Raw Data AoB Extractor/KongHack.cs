using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Web;

namespace Raw_Data_AoB_Extractor
{
    public partial class KongHack : Form
    {
        const string searchURL = "http://konghack.com/games/game_search_json.php?request_type=advanced&term=";
        const string loginURL = "http://konghack.com/login_resp.php";
        //game_id=988277&hack_service=K&hack_title=any+kill+awards+trophy+3+%281500+kills%29&hack_desc=25+dc+0b+0f+10+00+00+60+4e+46+98+11+00+60+cf+0d+66+a0+17+4f+b9+05+01%3Cbr+%2F%3E%0D%0A25+dc+0b+0f+00+00+00+60+4e+46+98+11+00+60+cf+0d+66+a0+17+4f+b9+05+01+
        const string HackSubmitURL = "http://konghack.com/games/hack_submit_resp.php";

        Boolean haserror = false;

        //List<KongHackGame> _games=new List<KongHackGame>();
        List<String> _terms = new List<string>();
        AutoCompleteStringCollection _titles=new AutoCompleteStringCollection();

        public KongHack(string aob1, string aob2, string hacktitle)
        {
            InitializeComponent();
            try
            {
                tb_uname.Text = Properties.Settings.Default.KHUserName;
                tb_pass.Text = Properties.Settings.Default.KHPassword;
                comboBox1.SelectedIndex = Properties.Settings.Default.KHDomainComboIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error::" + ex.Message, "eror");
            }

            cb_gameTitle.AutoCompleteCustomSource = _titles;

            //check inputs
            if (string.IsNullOrEmpty(hacktitle) || string.IsNullOrEmpty(aob1) 
                || string.IsNullOrEmpty(aob2) || aob1.Length != aob2.Length)
            {
                if (aob1.Length != aob2.Length)
                {
                    MessageBox.Show("ERROR:::AoBs do not match", "error submitting hack", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR::: Missing Input Field", "error submitting hack", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btn_submit.Enabled=false;
                haserror = true;
            }
            tb_hacktitle.Text = hacktitle;
            tb_aob.Text = aob1 + "<br />"+ aob2;
            comboBox1.SelectedIndex = 0;
        }
        
        private void KongHack_Shown(object sender, EventArgs e)
        {
            if (haserror)
            {
                Close();
            }
        }
        private void KongHack_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Properties.Settings.Default.KHPassword = tb_pass.Text;
                Properties.Settings.Default.KHUserName = tb_uname.Text;
                Properties.Settings.Default.KHDomainComboIndex = comboBox1.SelectedIndex;
                Properties.Settings.Default.Save();

                _titles.Clear();
                //_games.Clear();
                _terms.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error::" + ex.Message, "eror");
            }
        }
        
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath.Contains("search"))
            {
                //{\"id\":(\d+),\"name\":\"([\w\d\s]+)\"
                System.Diagnostics.Debug.WriteLine("got to game search jason");
                
                MatchCollection mc = Regex.Matches(webBrowser1.DocumentText,@"{.id.:(\d+),.name.:.([\w\d\s]+).");
                foreach (Match m in mc)
                {
                    KongHackGame kh=new KongHackGame(Convert.ToInt32( m.Groups[1].Value),m.Groups[2].Value);
                    //_games.Add(kh);
                    if (!cb_gameTitle.Items.Contains(kh))
                    {
                        cb_gameTitle.Items.Add(kh);
                        _titles.Add(m.Groups[2].Value);
                    }
                    
                }


            }
            else if (e.Url.AbsolutePath.Contains("login.php")&& !webBrowser1.DocumentText.Contains("Invalid Credentials"))
            {
                webBrowser1.Document.Cookie = "";
                string postdata = "bounce=" + "&username=" + tb_uname.Text + "&password=" + tb_pass.Text;
                PostFormData(loginURL, postdata);
            }
        }

        private void cb_gameTitle_KeyUp(object sender, KeyEventArgs e)
        {
            if (cb_gameTitle.Text.Length == 3 && !_terms.Contains(cb_gameTitle.Text.Replace(' ', '+')))
            {
                _terms.Add(cb_gameTitle.Text.Replace(' ', '+'));
                webBrowser1.Navigate(searchURL + cb_gameTitle.Text.Replace(' ', '+'));
            }
            else if (cb_gameTitle.Text.Length >= 5 && 1 == (cb_gameTitle.Text.Length % 2))
            {
                //_titles.Clear();
                //_games.Clear();
                //cb_gameTitle.Items.Clear();
                webBrowser1.Navigate(searchURL + cb_gameTitle.Text.Replace(' ', '+'));
            }
        }

        private void tb_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Login();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (true||webBrowser1.Document.Cookie.Contains("auth"))
            {
                submitHack();
            }
            else
            {
                MessageBox.Show("You must log in to Submit a hack!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ClearData();
            }
            System.Diagnostics.Debug.WriteLine(webBrowser1.Document.Cookie);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (!webBrowser1.Document.Cookie.Contains("auth"))
            {
                ClearData();
                webBrowser1.Navigate("konghack.com/login.php");
            }
            else
            {
                MessageBox.Show("User already logged in!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ClearData()
        {
            _terms.Clear();
            _titles.Clear();
            cb_gameTitle.Items.Clear();
            cb_gameTitle.Text = string.Empty;
        }

        private void PostFormData(string url, string data)
        {
            ASCIIEncoding a = new ASCIIEncoding();
            byte[] postbytes = a.GetBytes(data);
            //System.Diagnostics.Debug.WriteLine("");
            //foreach (byte x in postbytes)
            //    System.Diagnostics.Debug.Write((char)x);
            //System.Diagnostics.Debug.WriteLine("");
            webBrowser1.Navigate(url, "", postbytes, "Content-Type: application/x-www-form-urlencoded\r\n");
        }

        private void submitHack()
        {
            //game_id=
            //&hack_service=
            //&hack_title=
            //&hack_desc=

            //get service ID
            char serviceID;
            switch (comboBox1.SelectedIndex)
            {
                case 0: serviceID = 'K'; break;
                case 1: serviceID = 'N'; break;
                case 2: serviceID = 'A'; break;
                case 3: serviceID = 'F'; break;
                case 4: serviceID = 'C'; break;
                case 5: serviceID = 'M'; break;
                default: serviceID = 'T'; break;
            }
            try
            {
                string postdata = "game_id=" + ((KongHackGame)cb_gameTitle.SelectedItem).id +
                    "&hack_service=" + serviceID +
                    "&hack_title=" + tb_hacktitle.Text +
                    "&hack_desc=" + tb_aob.Text;
                postdata = postdata.Replace(' ', '+');
                PostFormData(HackSubmitURL, postdata);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:::" + ex.Message + Environment.NewLine + "TRY LOGGING IN!!"
                    , "error submitting hack", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearData();
            }

        }

        private void cb_gameTitle_Click(object sender, EventArgs e)
        {
            cb_gameTitle.DroppedDown = true;
        }

        private void cb_gameTitle_TextChanged(object sender, EventArgs e)
        {
            if (cb_gameTitle.Text.Length == 3 && !_terms.Contains(cb_gameTitle.Text.Replace(' ', '+')))
            {
                _terms.Add(cb_gameTitle.Text.Replace(' ', '+'));
                webBrowser1.Navigate(searchURL + cb_gameTitle.Text.Replace(' ', '+'));
            }
            else if (cb_gameTitle.Text.Length >= 5 && 1 == (cb_gameTitle.Text.Length % 2))
            {
                //_titles.Clear();
                //_games.Clear();
                //_terms.Add(cb_gameTitle.Text.Replace(' ', '+'));
                //cb_gameTitle.Items.Clear();
                webBrowser1.Navigate(searchURL + cb_gameTitle.Text.Replace(' ', '+'));
            }
        }
        
        
    }
}
