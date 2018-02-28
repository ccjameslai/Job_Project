using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using fst.AVMUtility;
using Microsoft.Win32;


namespace SystemPreChecker
{
    public class InstallationChecker
    {
        public InstallationChecker()
        {
            displayNames = GetDisplayNamesSet();
        }

        public bool Is7zInstalled()
        {
            foreach (var item in displayNames["local64"])
            {
                if(item.Contains("7-Zip"))
                {
                    return true;
                }
               
            }

            return false;
        }

        
        public bool IsIISSetup(string strServiceURL)
        {
            Boolean bSuccess = false;

            try
            {
                Encoding myEncoding = Encoding.GetEncoding("UTF-8");

                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(strServiceURL);

                req.Method = "GET";

                using (WebResponse wr = req.GetResponse())
                {
                    using (StreamReader myStreamReader = new StreamReader(wr.GetResponseStream(), myEncoding))
                    {
                        bSuccess = true;
                    }
                }
            }
            catch
            {
                bSuccess = false;
            }

            return bSuccess;

        }

        public bool IsfstLibInstalled()
        {
            //var displayNames = GetDisplayNamesSet();

            foreach (var name in displayNames)
            {
                if (name.Value.Contains("ForesightLibary (x64)"))
                {
                    
                }
            }

            return displayNames["local64"].Contains("ForesightLibary (x64)");
        }

        /// <summary>
        /// 取得子機碼displayname
        /// </summary>
        /// <returns></returns>
        private static Dictionary<string, HashSet<string>> GetDisplayNamesSet()
        {
            Dictionary<string, HashSet<string>> output = new Dictionary<string, HashSet<string>>
            {
                {"currnt32", new HashSet<string>() },{"local32", new HashSet<string>() },
                {"currnt64", new HashSet<string>() },{"local64", new HashSet<string>() }
            };


            HashSet<string> displayNames_local32 = GetDisplayNames(RegeditType.local32);
            HashSet<string> displayNames_local64 = GetDisplayNames(RegeditType.local64);
            HashSet<string> displayNames_currnt32 = GetDisplayNames(RegeditType.currnt32);
            HashSet<string> displayNames_currnt64 = GetDisplayNames(RegeditType.currnt64);


            output["currnt32"] = displayNames_currnt32;
            output["currnt64"] = displayNames_currnt64;
            output["local32"] = displayNames_local32;
            output["local64"] = displayNames_local64;

            
            return output;

        }

        private static HashSet<string> GetDisplayNames(RegeditType regType)
        {
            RegistryKey view = null;

            HashSet<string> output = new HashSet<string>();

            if (regType == (RegeditType) 0)
            {
                view = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
            }

            if (regType == (RegeditType) 1)
            {
                view = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            }

            if (regType == (RegeditType) 2)
            {
                view = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
            }

            if (regType == (RegeditType) 3)
            {
                view = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            }

            string algorithmPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\";
            

            using (RegistryKey subKey = view.OpenSubKey(algorithmPath, true))
            {
                if (subKey != null)
                {
                    List<string> subKeyName = subKey.GetSubKeyNames().ToList();

                    foreach (var sk in subKeyName)
                    {
                        RegistryKey rky = subKey.OpenSubKey(sk);

                        string name = (string)rky.GetValue("DisplayName", "");

                        output.Add(name);
                    }
                }

            }

            return output;

        }

        enum RegeditType
        {
            local32 = 0,
            local64,
            currnt32,
            currnt64
        }

        public bool IsMCRInstalled()
        {
            //var displayNames = GetDisplayNamesSet();

            return displayNames["local64"].Contains("MATLAB(R) Compiler Runtime 7.14");
        }

        public string IsSQLNativeInstalled()
        {
            var ODBCDrivers = GetODBCDrivers();

            List<string> versions = new List<string>();

            if (ODBCDrivers.Contains("SQL Server Native Client 10.0"))
            {
                versions.Add("10");
            }

            if (ODBCDrivers.Contains("SQL Server Native Client 11.0"))
            {
                versions.Add("11");
            }

            if (versions.Count == 2)
            {
                return "SQL Server Native Client 10.0" + Environment.NewLine + "SQL Server Native Client 11.0";
            }

            if (versions.Contains("10"))
            {
                return "SQL Server Native Client 10.0";
            }

            if (versions.Contains("11"))
            {
                return "SQL Server Native Client 11.0";
            }

            return "";
            
        }

        private HashSet<string> GetODBCDrivers()
        {
            string ODBCPath = @"SOFTWARE\Wow6432Node\ODBC\ODBCINST.INI";

            List<string> ODBCDriversInRegedit = Registry.LocalMachine.OpenSubKey(ODBCPath).GetSubKeyNames().ToList();

            HashSet<string> ODBCDrivers = new HashSet<string>();

            foreach (var driver in ODBCDriversInRegedit)
            {
                ODBCDrivers.Add(driver);
            }

            return ODBCDrivers;
        }

        public bool IsMySQLInstalled()
        {
            var ODBCDrivers = GetODBCDrivers();

            if (ODBCDrivers.Contains("MySQL ODBC 5.2 ANSI Driver"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string IsOracleInstalled()
        {
            var ODBCDrivers = GetODBCDrivers();

            List<string> versions = new List<string>();

            if (ODBCDrivers.Contains("Oracle in OraClient11g_home1"))
            {
                versions.Add("OraClient11g");
            }

            if (ODBCDrivers.Contains("Oracle in OraDb11g_home1"))
            {
                versions.Add("OraDb11g");
            }

            if (ODBCDrivers.Contains("Oracle in OraClient10g_home1"))
            {
                versions.Add("OraClient10g");
            }

            if (ODBCDrivers.Contains("Oracle in OraDb10g_home1"))
            {
                versions.Add("OraDb10g");
            }

            StringBuilder output = new StringBuilder();

            foreach (var version in versions)
            {
                output.Append(version).AppendLine();  
            }

            return output.ToString();
        }

        public Dictionary<string, string> IsSQLiteInstalled()
        {
            Dictionary<string, string> location = new Dictionary<string, string>();

            if (displayNames["local32"].Contains("SQLite ODBC Driver (remove only)"))
            {
                location["local32"] = "1";
            }

            if (displayNames["local64"].Contains("SQLite ODBC Driver (remove only)"))
            {
                location["local64"] = "1";
            }

            if (displayNames["currnt32"].Contains("SQLite ODBC Driver (remove only)"))
            {
                location["currnt32"] = "1";
            }

            if (displayNames["currnt64"].Contains("SQLite ODBC Driver (remove only)"))
            {
                location["currnt64"] = "1";
            }

            return location;
        }

        public void Install7z()
        {
            //InstallAPPs("7z1604-x64.exe");
            InstallAPPs("7z.bat");
        }

        public void InstallfstLib()
        {
            if (IntPtr.Size == 8)
            {
                InstallAPPs("ForesightLibary_setup_V1.2_x64.exe");
            }

            if (IntPtr.Size == 4)
            {
                InstallAPPs("ForesightLibary_setup_V1.2_x86.exe");
            }          
        }

        private void InstallAPPs(string appName)
        {
            //ProcessStartInfo info = new ProcessStartInfo();

            //info.FileName = appName;
            //info.WorkingDirectory = @"C:\Users\James\Job_Proj\SystemPreChecker\ApiTester\bin\Debug\AppBatch";
            //info.UseShellExecute = false;

            //Process.Start(info);
            try
            {
                Process oProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = appName,
                        Arguments = "",
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        RedirectStandardOutput = true
                    },

                    EnableRaisingEvents = true
                };

                oProcess.Exited += (s, e) => { System.Diagnostics.Process oTemp = (System.Diagnostics.Process)s; oTemp.Close(); };

                oProcess.Start();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InstallMCR()
        {
            InstallAPPs("MCRInstaller_64.exe");

            Thread.Sleep(2000);

            InstallAPPs("MCRInstaller_x86.exe");
        }

        public void InstallMySQL()
        {
            Process.Start("mysql-connector-odbc-5.2.6-win32.msi");
        }


        public List<Port> PortCheck(string CPFolder)
        {
            var ports = GetPorts();

            return GetSysstemPorts(ports, CPFolder);
            
        }

        private List<Port> GetSysstemPorts(List<ControlPanel.Port> ports, string CPFolder)
        {
            ControlPanel cp = new ControlPanel(CPFolder);

            var SystemApps = cp.GetSystemInfo();

            List<Port> output = new List<Port>();

            foreach (var port in SystemApps)
            {
                int ProcId = 0;
                if (!String.IsNullOrEmpty(port.Port))
                {
                    cp.IsPortListen(Convert.ToInt32(port.Port), out ProcId);
                }
                

                Port p = new Port
                {
                    Process_name = port.SystemName,
                    Name = port.WindowTitle,
                    Port_number = port.Port,
                    ProcID = ProcId
                };

                output.Add(p);
            }

            return output;
        }

        public string QueryPCOperationTime()
        {
            EventLog eventlog = new EventLog();

            //"Application"应用程序, "Security"安全, "System"系统
            eventlog.Log = "System";

            EventLogEntryCollection elec = eventlog.Entries;

            StringBuilder sb = new StringBuilder();

            foreach (EventLogEntry entry in elec)
            {
                if (entry.InstanceId == 12)
                {
                    sb.AppendFormat("Date={0}, Time of Reboot={1};",
                        entry.TimeGenerated.ToLongDateString(), entry.TimeGenerated.ToLongTimeString());

                    sb.AppendLine();
                }

                if (entry.InstanceId == 13)
                {
                    sb.AppendFormat("Date={0}, Time of Shutdown={1};",
                        entry.TimeGenerated.ToLongDateString(), entry.TimeGenerated.ToLongTimeString());

                    sb.AppendLine();
                }
            }
            
            return sb.ToString();
        }

        private List<ControlPanel.Port> GetPorts()
        {
            List<ControlPanel.Port> output = new List<ControlPanel.Port>();

            ControlPanel cp = new ControlPanel();

            foreach (var app in SystemApps)
            {
                Process[] p = Process.GetProcessesByName(app);

                if (p.Length < 1)
                {
                    ControlPanel.Port cppWithoutActivated = new ControlPanel.Port
                    {
                        name = app,
                        port_number = null,
                        process_name = app
                    };

                    output.Add(cppWithoutActivated);

                    continue;
                }

                int pid = p[0].Id;

                int port = 0;
                cp.GetListenedPort(pid, out port);

                ControlPanel.Port cpp = new ControlPanel.Port
                {
                    name = app,
                    port_number = port.ToString(),
                    process_name = app
                };

                output.Add(cpp);
            }

            return output;
        }

        private string RunCmd(string cmd)
        {
            Process p = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + cmd,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };


            p.Start();

            return p.StandardOutput.ReadToEnd();
        }

        List<string> SystemApps = new List<string>
        {
            "VMManager", "DCS", "MCClient", "MCServer", "SICAgentClient", "VMClient", "VMServer"
        };

        private Dictionary<string, HashSet<string>> displayNames;

        public class Port
        {
            public string Name { get; set; }
            public string Port_number { get; set; }
            public string Process_name { get; set; }
            public int ProcID { get; set; }
        }

        public List<Port> SearchCurrentProcessByPort(string port_number)
        {
            string pidCmd = "netstat -ano| findstr :" + port_number;

            var pidInfo = RunCmd(pidCmd).Replace("\r\n", "").Split(' ').Where(info => info != "").ToList();

            if (pidInfo.Count < 1)
            {
                Port exceptionPort = new Port
                {
                    Name = "No Process using this Port",
                    Process_name = "No Process using this Port",
                    Port_number = port_number
                };

                return new List<Port> { exceptionPort};
            }

            string pid = pidInfo[pidInfo.Count - 1];

            string processCmd = "tasklist| findstr " + pid;

            var taskInfo = RunCmd(processCmd).Replace("\r\n", "").Split(' ').ToList().Where(info => info != "").ToList();

            Port port = new Port
            {
                Name = taskInfo[0],
                Process_name = taskInfo[0].Split('.')[0],
                Port_number = port_number
            };

            return new List<Port> {port};

        }

        public string CommunicationCheck(string ip)
        {
            Process proc = new Process
            {
                StartInfo=
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + "ping " + ip,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();

            return proc.StandardOutput.ReadToEnd();
        }

        public string DbConnection(ConnectionInfo info)
        {
            using (OdbcConnection cnn = new OdbcConnection())
            {
                cnn.ConnectionString = "DSN=" + info.DSN + ";UID=" + info.UID + ";PWD=" + info.PWD;

                try
                {
                    cnn.Open();

                    return "";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

            }
        }
    }

 }
