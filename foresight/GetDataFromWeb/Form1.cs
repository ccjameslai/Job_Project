using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GetDataFromWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_GrabDataStream_Click(object sender, EventArgs e)
        {
            bw_scale.RunWorkerAsync();

        }

        private void btn_StopDataStream_Click(object sender, EventArgs e)
        {
            bw_scale.CancelAsync();
        }

        /// <summary>
        /// Main function
        /// </summary>
        /// <param name="webAddress"></param>
        /// <returns></returns>
        private string ShowLoadCellVolunm(string webAddress)
        {
            WebRequest myRequest = WebRequest.Create(webAddress);

            myRequest.Method = "Get";

            WebResponse myResponse = myRequest.GetResponse();

            StreamReader sr = new StreamReader(myResponse.GetResponseStream());

            try
            {
                string result = sr.ReadToEnd();

                int firstIndx = result.IndexOf(":");
                int lastIndx = result.IndexOf("</h1>");
                
                var reader = result.Substring((firstIndx + 1), (lastIndx - firstIndx - 1)).Trim() + Environment.NewLine;

                return reader;
            }
            finally
            {
                sr.Close();

                myResponse.Close();
            }
  
        }

        private void bw_scale_DoWork(object sender, DoWorkEventArgs e)
        {
            if (bw_scale.CancellationPending)
            {
                return;
            }

            string ipAddress = ip_address.Text;

            string webAddress = string.Format(@"http://{0}/", ipAddress);

            while (!bw_scale.CancellationPending)
            {
                e.Result = ShowLoadCellVolunm(webAddress);

                bw_scale.ReportProgress(1, e.Result);
            }
            
        }

        private void bw_scale_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!bw_scale.IsBusy)
            {
                MessageBox.Show("Stop grabbing load cell data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bw_scale_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            load_cell.AppendText(e.UserState.ToString());
        }
    }
}
