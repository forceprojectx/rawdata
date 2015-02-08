using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Raw_Data_AoB_Extractor
{
    class Updater
    {
        internal const string downloadURL = "http://www.forceprojectx.com/services/rawdata";
        internal const string versionsURL = "http://logicalspear.forceprojectx.com/versions?app=rdaob";
        public void threadmain(object isUserInitiated)
        {
            //wait for form1
            //while (Application.OpenForms["Form1"] != null)
            //{
            //    System.Threading.Thread.Sleep(200);
            //}
            String updateServerInfo = GetVersion();
            String currentversion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            String[] updateInfo = updateServerInfo.Split('|');
            if (updateInfo[0] != null && updateInfo[0] != "")
            {
                if (currentversion != updateInfo[0] && ((bool)isUserInitiated || Properties.Settings.Default.nextupdatenotification < DateTime.Now))
                {
                    // If the no button was pressed ...
                    string message = "Current Version: "
                        + currentversion + Environment.NewLine
                        + "A newer version(" + updateInfo[0] + ") is available. Would you like to download it now?" + Environment.NewLine + Environment.NewLine
                        + "Changes in version ";
                    foreach (string s in updateInfo)
                    {
                        message += s + Environment.NewLine;
                    }
                    DialogResult result;
                    try
                    {
                        result = (new UpdateMessageBox(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, message)).ShowDialog();
                        //result = (new UpdateMessageBox(message)).ShowDialog(Application.OpenForms["Form1"]);

                        // If the yes button was pressed ...
                        if (result == DialogResult.Yes)
                        {
                            // open project webpage
                            System.Diagnostics.Process.Start(downloadURL);
                        }
                        else if (result == DialogResult.Ignore)
                        {
                            //store the date +7 days
                            System.Diagnostics.Debug.WriteLine("remind in 7 days pressed");
                            try
                            {
                                Properties.Settings.Default.nextupdatenotification = DateTime.Today.Add(new TimeSpan(7, 0, 0, 0));
                                Properties.Settings.Default.Save();
                            }
                            catch (Exception err)
                            {
                                System.Diagnostics.Debug.WriteLine(err.Message);
                            }
                        }
                        else
                        {
                            //DialogResult.Cancel
                            System.Diagnostics.Debug.WriteLine("ignore pressed");
                        }
                    }
                    catch (Exception ex)
                    {
                        //this.WindowState = FormWindowState.Normal;
                        System.Diagnostics.Debug.WriteLine(ex.Message);
                        //result = (new UpdateMessageBox(message)).ShowDialog();
                        //this.TopMost = true;
                    }
                }
                else if ((bool)isUserInitiated)
                {
                    const string caption = "FPX Update Checker";
                    var result = MessageBox.Show("There are currently no new updates available.",
                    caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
        }

        public string GetVersion()
        {
            string str3 = "";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(versionsURL);
                request.KeepAlive = true;
                request.Headers.Add("Accept-Language", "en-us,en;q=0.5");
                request.UserAgent = "ForceProject";
                request.Timeout = 2000;
                request.Method = "GET";
                request.ProtocolVersion = HttpVersion.Version10;
                request.AllowAutoRedirect = false;
                ServicePointManager.ServerCertificateValidationCallback = delegate
                {
                    return true;
                };
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string str = reader.ReadToEnd();
                            string str2 = response.Headers.ToString();
                            reader.Close();
                            response.Close();
                            stream.Close();
                            str3 = str;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return str3;
        }
    };
    }

