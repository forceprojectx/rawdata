using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;

namespace Raw_Data_AoB_Extractor
{
    static class Program
    {
        internal static bool updatershowing = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //while (x --> 0)//x goes to 0
            //{
            //    Console.Out.WriteLine("x=" + x);
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            try
            {
                Updater updates = new Updater();
                Thread updateChecker = new Thread(new ParameterizedThreadStart(updates.threadmain));
                updateChecker.Name = "Update Agent";
                updateChecker.Start(false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Console.WriteLine( CheckUpdates());

            Application.Run(new Form1());
            
            //updateChecker.Join();
        }


    }
}
