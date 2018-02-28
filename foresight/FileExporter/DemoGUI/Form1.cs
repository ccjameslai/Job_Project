using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fst.DC.Toolkit.Database;
using fst.DC.Toolkit.Utility;
using FileExporter;
using Newtonsoft.Json;

namespace DemoGUI
{
    public partial class Form1 : Form
    {
        private DatabaseInformation dbInfo;
        private DbAgent dbAgent;
        
        public Form1()
        {
            InitializeComponent();
        }

      
        private void ConnectToDb()
        {
            string filePath = Directory.GetCurrentDirectory() + @"\system.ini";

            dbInfo = FstDatabaseInformationReader.GetFromIni(filePath, "STDB");

            dbAgent = DbAgentFactory.CreateDbAgent(dbInfo);
        }

       
        public enum TableName
        {
            SYSSETTING,
            PROCESS_OP1L,
            PROCESS_OP1R,
            PROCESS_OP2,
            PROCESS_OP3,
            METROLOGY_OP1L,
            METROLOGY_OP1R,
            METROLOGY_OP2,
            METROLOGY_OP3
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            string configPath = Application.StartupPath + @"\system.ini";

            string sourceFilePath = "";

            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                sourceFilePath = dialog.FileName;
            }
            
            string connectionString = MyExtends.GetConnectionStringFromIniForSQLBulkCopy(configPath);

            using (StreamReader sr = new StreamReader(sourceFilePath))
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string content = sr.ReadLine();

                DataTable sourceData = JsonConvert.DeserializeObject<DataTable>(content);

                conn.Open();

                string destinationTable = GetDestinationTable(sourceFilePath);
                
                SqlBulkCopy sbc = new SqlBulkCopy(conn)
                {
                    BatchSize = 1000,
                    BulkCopyTimeout = 60,
                    DestinationTableName = destinationTable,
                };

                SetColumnMappings(sbc);

                sbc.WriteToServer(sourceData);

                sbc.Close();

            }
        
        }

        private static void SetColumnMappings(SqlBulkCopy sbc)
        {
            sbc.ColumnMappings.Add("CONTEXTID", "CONTEXTID");
            sbc.ColumnMappings.Add("TIMETAG", "TIMETAG");
            sbc.ColumnMappings.Add("TIME01", "TIME01");
            sbc.ColumnMappings.Add("FIELD_1", "FIELD_1");
            sbc.ColumnMappings.Add("FIELD_2", "FIELD_2");
            sbc.ColumnMappings.Add("FIELD_3", "FIELD_3");
            sbc.ColumnMappings.Add("FIELD_4", "FIELD_4");
            sbc.ColumnMappings.Add("FIELD_5", "FIELD_5");
            sbc.ColumnMappings.Add("FIELD_6", "FIELD_6");
            sbc.ColumnMappings.Add("FIELD_7", "FIELD_7");
            sbc.ColumnMappings.Add("FIELD_8", "FIELD_8");
            sbc.ColumnMappings.Add("FIELD_9", "FIELD_9");
            sbc.ColumnMappings.Add("FIELD_10", "FIELD_10");
            sbc.ColumnMappings.Add("FIELD_11", "FIELD_11");
            sbc.ColumnMappings.Add("FIELD_12", "FIELD_12");
        }

        private static string GetDestinationTable(string sourceFilePath)
        {
            string destinationTable = "";

            if (Path.GetFileName(sourceFilePath).Split('_')[0] == "SYS")
            {
                destinationTable = "SYSSETTING";
            }

            if (Path.GetFileName(sourceFilePath).Split('_')[0] == "PROCOP1L")
            {
                destinationTable = "PROCESS_OP1L";
            }

            if (Path.GetFileName(sourceFilePath).Split('_')[0] == "PROCOP2")
            {
                destinationTable = "PROCESS_OP2";
            }

            if (Path.GetFileName(sourceFilePath).Split('_')[0] == "PROCOP3")
            {
                destinationTable = "PROCESS_OP3";
            }

            if (Path.GetFileName(sourceFilePath).Split('_')[0] == "METROP1L")
            {
                destinationTable = "METROLOGY_OP1L";
            }

            if (Path.GetFileName(sourceFilePath).Split('_')[0] == "METROP2")
            {
                destinationTable = "METROLOGY_OP2";
            }

            if (Path.GetFileName(sourceFilePath).Split('_')[0] == "METROP3")
            {
                destinationTable = "METROLOGY_OP3";
            }

            return destinationTable;
        }

   

        private void button_Export_Click(object sender, EventArgs e)
        {
            ConnectToDb();

            string outputDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                                       @"\Export_" + DateTime.Now.ToString("yyyyMMdd");

            Exporter expo = new Exporter(dbAgent, outputDirectoryPath);

            Constraints constraints = SetConstraintsInfo();
            
            List<string> contextIds = new List<string>();
            expo.ExportSyssettingDataByJsonSerializeObject(constraints, out contextIds);

            textBox_IdCount.Text = contextIds.Count.ToString();

            expo.ExportProcessAndMetrologyDataByJsonSerializeObject(contextIds);

            expo.Compress();

            expo.DeleteDirectoryWithFiles(outputDirectoryPath);

        }

        private Constraints SetConstraintsInfo()
        {
            Constraints constraints = new Constraints();

            constraints.StartTime = StartTimePicker.Value.ToString("u").Substring(0, 19);

            constraints.EndTime = EndTimePicker.Value.ToString("u").Substring(0, 19);

            constraints.WheelType = "886";

            return constraints;
        }

       
    }
    
}
