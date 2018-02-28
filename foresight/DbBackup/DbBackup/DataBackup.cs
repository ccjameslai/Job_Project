using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fst.DC.Toolkit.Database;
using fst.DC.Toolkit.Utility;

namespace DbBackup
{
    public class DataBackup
    {
        public DataBackup()
        {
            
        }
        public DataBackup(DataBaseInformation dbInfo)
        {
            this.dbInfo = dbInfo;
        }
        
        private DataBaseInformation dbInfo;

        public List<string> SearchUserName()
        {
            

            List<string> UserNames = new List<string>
            {
                "FATEK_CDB1", "FATEK_STDB2", "FATEK_CDB", "FATEK_CDB2"
            };

            return UserNames;
        }

        public void Export()
        {
            string exportCmd = "exp " + dbInfo.UID + "/" + dbInfo.UID + "@" + dbInfo.DSN +
                               " file=F:\\DbBackup" + @"\" + dbInfo.DSN + @"\" + dbInfo.UID + ".dmp";
            
            try
            {
                RunCmd(exportCmd);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

      

        private void RunCmd(string exportCmd)
        {
            //Process p = new Process
            //{
            //    StartInfo = new ProcessStartInfo
            //    {
            //        FileName = @"cmd.exe",
            //        Arguments = @"/k " + exportCmd,
            //        UseShellExecute = true,
            //        CreateNoWindow = true
            //    },

            //    EnableRaisingEvents = true,
            //};

            //p.Exited += (s, e) => { System.Diagnostics.Process oTemp = (System.Diagnostics.Process)s; oTemp.Close(); };

            Process p = new Process();

            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = @"/c " + exportCmd;
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.CreateNoWindow = true;

            p.Start();

            p.WaitForExit();

            Compress();

            DeleteDumpFile();
        }

        private void Compress()
        {
            string dumpfilePath = @"F:\DbBackup\" + dbInfo.DSN + @"\" + dbInfo.UID;

            //Process p = new Process
            //{
            //    StartInfo = new ProcessStartInfo
            //    {
            //        FileName = @"C:\Program Files\7-zip\7z.exe",
            //        Arguments = "a -tzip " + dumpfilePath + ".zip " + dumpfilePath + ".dmp",
            //        UseShellExecute = true,
            //        CreateNoWindow = true
            //    },

            //    EnableRaisingEvents = true,
            //};

            //p.Exited += (s, e) => { System.Diagnostics.Process oTemp = (System.Diagnostics.Process)s; oTemp.Close(); };

            Process p = new Process();
            p.StartInfo.FileName = @"C:\Program Files\7-zip\7z.exe";
            p.StartInfo.Arguments = "a -tzip " + dumpfilePath + ".7z " + dumpfilePath + ".dmp";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;

            p.Start();

            p.WaitForExit();
        }

        private void DeleteDumpFile()
        {
            string dumpfilePath = @"F:\DbBackup\" + dbInfo.DSN + @"\" + dbInfo.UID +".dmp";

            File.Delete(dumpfilePath);
        }
    }
}
