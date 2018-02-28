using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemPreChecker;
using Microsoft.Win32;
using MRG.Controls.UI;

namespace ApiTester
{
    public partial class Form1 : Form
    {
        private List<string> DSNSet;

        public Form1()
        {
            InitializeComponent();

            DSNSet = new List<string>();

            DSNSet.AddRange(EnumDsn(Registry.LocalMachine));

            foreach (var name in DSNSet)
            {
                comboBox_DSN.Items.Add(name);
            }
           
        }

        private static Bitmap GetCross()
        {
            Image img = Image.FromFile(@"remove.png");

            Bitmap cross = new Bitmap(img); 

            return cross;
        }

        private void button_APPChecker_Click(object sender, EventArgs e)
        {
            backgroundWorker_7z.RunWorkerAsync();

            backgroundWorker_IIS.RunWorkerAsync();

            backgroundWorker_fstLib.RunWorkerAsync();

            backgroundWorker_MCR.RunWorkerAsync();

            backgroundWorker_SQL.RunWorkerAsync();

            backgroundWorker_MySQL.RunWorkerAsync();

            backgroundWorker_Oracle.RunWorkerAsync();

            backgroundWorker_SQLite.RunWorkerAsync();

            

        }

        

        private void backgroundWorker_7z_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            e.Result = checker.Is7zInstalled();
        }

        private void backgroundWorker_7z_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool) e.Result)
            {
                pictureBox_7z.Image = GetTick();

                button_Install.Visible = false;
            }
            else
            {
                pictureBox_7z.Image = GetCross();

                button_Install.Visible = true;
            }
        }
        private void backgroundWorker_IIS_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            e.Result = checker.IsIISSetup(@"http://127.0.0.1/");
        }

        private void backgroundWorker_IIS_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                pictureBox_IIS.Image = GetTick();
            }
            else
            {
                pictureBox_IIS.Image = GetCross();
            }
            
        }

        private static Bitmap GetTick()
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(@"accept.png");

            Bitmap tick = new Bitmap(img);

            return tick;
        }

    

        private void backgroundWorker_fstLib_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            e.Result = checker.IsfstLibInstalled();
        }

        private void backgroundWorker_fstLib_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                pictureBox_fstlib.Image = GetTick();

                button_Install_fstlib.Visible = false;
            }
            else
            {
                pictureBox_fstlib.Image = GetCross();

                button_Install_fstlib.Visible = true;
            }
        }

        private void backgroundWorker_MCR_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            e.Result = checker.IsMCRInstalled();
        }

        private void backgroundWorker_MCR_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                pictureBox_MCR.Image = GetTick();
            }
            else
            {
                pictureBox_MCR.Image = GetCross();
            }
        }

        private void backgroundWorker_SQL_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            e.Result = checker.IsSQLNativeInstalled();
        }

        private void backgroundWorker_SQL_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!string.IsNullOrEmpty((string)e.Result))
            {
                pictureBox_SQL.Image = GetTick();

                button_SQLServVersion.Visible = true;
            }
            else
            {
                pictureBox_SQL.Image = GetCross();
            }
           
        }

        private void backgroundWorker_MySQL_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            e.Result = checker.IsMySQLInstalled();
           
        }

        private void backgroundWorker_MySQL_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                pictureBox_MySQL.Image = GetTick();
            }
            else
            {
                pictureBox_MySQL.Image = GetCross();

                button_InstallMySQL.Visible = true;
            }
        }

        private void backgroundWorker_Oracle_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            e.Result = checker.IsOracleInstalled();
        }

        private void backgroundWorker_Oracle_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!string.IsNullOrEmpty((string)e.Result))
            {
                pictureBox_Oracle.Image = GetTick();

                button_OracleVersion.Visible = true;
            }
            else
            {
                pictureBox_Oracle.Image = GetCross();
            }
        }

        private void backgroundWorker_SQLite_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            e.Result = checker.IsSQLiteInstalled();
        }

        private void backgroundWorker_SQLite_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if ((bool)e.Result)
            //{
            //    pictureBox_SQLite.Image = GetTick();
            //}
            //else
            //{
            //    pictureBox_SQLite.Image = GetCross();
            //}

            Dictionary<string, string> results = (Dictionary<string, string>) e.Result;

            bool IsInstalled = false;

            foreach (var result in results)
            {
                if (result.Value == "1")
                {
                    IsInstalled = true;

                }
            }

            if (IsInstalled)
            {
                pictureBox_SQLite.Image = GetTick();

                button_SQLiteLocation.Visible = true;
            }
            else
            {
                pictureBox_SQLite.Image = GetCross();
            }
        }

        private void button_SQLServVersion_Click(object sender, EventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            string version = checker.IsSQLNativeInstalled();

            MessageBox.Show(version, "SQL Server Version");
        }

        private void button_OracleVersion_Click(object sender, EventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            string version = checker.IsOracleInstalled();

            MessageBox.Show(version, "Oracle Version");
        }

        private void button_Install_Click(object sender, EventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            checker.Install7z();          
        }

        private void button_Install_fstlib_Click(object sender, EventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            checker.InstallfstLib();
        }

        private void button_InstallMCR_Click(object sender, EventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            checker.InstallMCR();
        }

        private void button_MySQL_Click(object sender, EventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            checker.InstallMySQL();
        }

        private void button_PortStatus_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_CPFolder.Text))
            {
                MessageBox.Show("Folder path is null");

                return;
            }

            InstallationChecker checker = new InstallationChecker();

            var systemPorts = checker.PortCheck(textBox_CPFolder.Text);

            ShowResultInGridView(systemPorts, dataGridView_PortCheck.Rows);
        }

        private void ShowResultInGridView(List<InstallationChecker.Port> systemPorts, DataGridViewRowCollection gridViewRows)
        {
            dataGridView_PortCheck.Rows.Clear();

            DataGridViewRowCollection rows = gridViewRows;

            int indx = 0;
            foreach (var sysport in systemPorts)
            {
                if (String.IsNullOrEmpty(sysport.Port_number))
                {
                    rows.Add(sysport.Process_name, sysport.Port_number, null);

                    indx++;

                    continue;
                }

                if (sysport.ProcID == -1)
                {
                    rows.Add(sysport.Process_name, sysport.Port_number, null);

                    rows[indx].Cells[2].Style.BackColor = Color.Red;

                    indx++;

                    continue;
                }
                
                rows.Add(sysport.Process_name, sysport.Port_number, null);

                rows[indx].Cells[2].Style.BackColor = Color.Green;

                indx++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            var currentProcessWithPort = checker.SearchCurrentProcessByPort(textBox_Port.Text);

            ShowResultInGridView(currentProcessWithPort, dataGridView_PortCheck.Rows);
        }

        private void button_QueryPCStatus_Click(object sender, EventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            List<string> PCoperationTime = checker.QueryPCOperationTime().Replace("\r\n", "").Split(';').ToList();
            
            ShowResultInGridView(PCoperationTime, dataGridView_QueryPCOperationTime.Rows);
        }

        private void ShowResultInGridView(List<string> PCRecords, DataGridViewRowCollection gridViewRows)
        {
            dataGridView_QueryPCOperationTime.Rows.Clear();

            DataGridViewRowCollection rows = gridViewRows;

            PCRecords.Reverse();

            foreach (var record in PCRecords)
            {
                if (String.IsNullOrEmpty(record))
                {
                    continue;
                }

                string dateOfPCStatus = record.Split(',')[0].Split('=')[1] + " " + record.Split(',')[1].Split('=')[1];
                string PCStatus = record.Split(',')[1].Split('=')[0];

                rows.Add(dateOfPCStatus, PCStatus);
            }
        }

        private void button_Communication_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(comboBox_DSN.Text) || String.IsNullOrEmpty(textBox_COMU_UID.Text) ||
                String.IsNullOrEmpty(textBox_COMU_PWD.Text))
            {
                MessageBox.Show("Connection Information is not sufficient.", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            int indx = comboBox_DSN.SelectedIndex;

            ConnectionInfo conInfo = new ConnectionInfo();
            conInfo.UID = textBox_COMU_UID.Text;
            conInfo.PWD = textBox_COMU_PWD.Text;
            conInfo.DSN = DSNSet[indx];

            InstallationChecker checker = new InstallationChecker();

            var outputString = checker.DbConnection(conInfo).Replace("\r\n", "+").Split('+')[0];

            if (String.IsNullOrEmpty(outputString))
            {
                MessageBox.Show("Connection existed !");
            }
            else
            {
                MessageBox.Show(outputString, "Can not connect to "+ conInfo.DSN + " !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            
        }

        private IEnumerable<string> EnumDsn(RegistryKey rootKey)
        {
            RegistryKey regKey = rootKey.OpenSubKey(@"Software\ODBC\ODBC.INI\ODBC Data Sources");

            if (regKey != null)
            {
                foreach (var name in regKey.GetValueNames())
                {
                    string value = regKey.GetValue(name, "").ToString();

                    yield return name;
                }
            }
        }

        private void backgroundWorker_Ping_DoWork(object sender, DoWorkEventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            e.Result = checker.CommunicationCheck(textBox_IP.Text);

            LoadingCircle lc = new LoadingCircle();
            lc.Active = true;

        }

        private void backgroundWorker_Ping_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBox_Communication.Text = (string) e.Result;

            loadingCircle_Ping.Active = false;

            loadingCircle_Ping.Visible = false;
        }

        private void backgroundWorker_DBConnt_DoWork(object sender, DoWorkEventArgs e)
        {
            int indx = comboBox_DSN.SelectedIndex;

            ConnectionInfo conInfo = new ConnectionInfo();
            conInfo.UID = textBox_COMU_UID.Text;
            conInfo.PWD = textBox_COMU_PWD.Text;
            conInfo.DSN = DSNSet[indx];

            InstallationChecker checker = new InstallationChecker();

            e.Result = checker.DbConnection(conInfo);
        }

        private void button_Ping_Click(object sender, EventArgs e)
        {
            backgroundWorker_Ping.RunWorkerAsync();

            loadingCircle_Ping.Visible = true;

            loadingCircle_Ping.Active = true;
            
        }

        private void backgroundWorker_Ping_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void button_SQLiteLocation_Click(object sender, EventArgs e)
        {
            InstallationChecker checker = new InstallationChecker();

            Dictionary<string, string> message = checker.IsSQLiteInstalled();

            StringBuilder sb = new StringBuilder();

            foreach (var location in message)
            {
                if (location.Value == "1")
                {
                    sb.Append(location.Key);
                }
            }

            MessageBox.Show(sb.ToString(), "Location and bit");
        }
    }
}
