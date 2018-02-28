using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using fst.DC.Toolkit.Database;
using Newtonsoft.Json;

namespace FileExporter
{
    public class Exporter
    {
        private string destinationFilePath;
        private DbAgent dbAgent;
        private int upperLimitOfPieceCount;
        private string exportDiretory;

        public Exporter(DbAgent dbAgent, string exportDiretory)
        {
            this.dbAgent = dbAgent;

            upperLimitOfPieceCount = 800;

            this.exportDiretory = exportDiretory;

            if (!Directory.Exists(exportDiretory))
            {
                Directory.CreateDirectory(exportDiretory);
            }
        }

        public void ToExcel(DataTable sourceTable)
        {
            CheckExistedFile();

            ExportToExcel(sourceTable);
        }

        public void ToCsv()
        {
             
        }

        private void ExportToExcel(DataTable sourceTable)
        {
            XLWorkbook wb = new XLWorkbook();

            wb.AddWorksheet(sourceTable, "sheet1");

            destinationFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                  @"\ExtractedData_" + DateTime.Now.ToString("yyyyMMddHHmmss") +
                                  @"\Output.xlsx";

            wb.SaveAs(destinationFilePath);

            wb.Dispose();
        }

        private void CheckExistedFile()
        {
            if (File.Exists(destinationFilePath))
            {
                File.Delete(destinationFilePath);
            }
        }

        public void ToExcel(DataTable sourceTable, string targetTable)
        {
            CheckExistedFile();

            ExportToExcel(sourceTable, targetTable);
        }

        private void ExportToExcel(DataTable sourceTable, string targetTable)
        {
            XLWorkbook wb = new XLWorkbook();

            wb.AddWorksheet(sourceTable, "sheet1");

            destinationFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                  @"\ExtractedData_" + DateTime.Now.ToString("yyyyMMddHHmmss") +
                                  @"\" + targetTable + ".xlsx";

            wb.SaveAs(destinationFilePath);

            wb.Dispose();
        }

        public void ExportSyssettingDataByJsonSerializeObject(Constraints constraints, out List<string> contextIdSet)
        {
            DataTable syssetting = GetSyssettingTable(constraints);

            contextIdSet = (from DataRow row in syssetting.Rows select row[0].ToString()).ToList();

            string jsonSyssetting = JsonConvert.SerializeObject(syssetting);

            using (StreamWriter sw = new StreamWriter(exportDiretory + @"\Sys_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt"))
            {
                sw.WriteLine(jsonSyssetting);
            }

            
        }

        
        private void ExportDataToTxtByJsonSerializeObject(int paging, List<string> workIds, string tableName)
        {
            string selectSql = GetSelectSql(workIds, tableName);

            DataTable sourceTable = dbAgent.Driver.ExecuteReaderToDataTable(selectSql);

            string jsonData = JsonConvert.SerializeObject(sourceTable);

            string fileName = tableName.Split('_')[0].Substring(0, 4) + "_" + tableName.Split('_')[1] + "_" + paging + "_" +
                              DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

            using (StreamWriter sw = new StreamWriter(exportDiretory + @"\" + fileName))
            {
                sw.WriteLine(jsonData);
            }
        }

        private string GetSelectSql(List<string> workIds, string sourceTable)
        {
            string idSet = "";

            foreach (var id in workIds)
            {
                idSet += "'" + id + "',";
            }

            return "SELECT * FROM " + sourceTable + " WHERE CONTEXTID IN(" + idSet.Substring(0, idSet.Length - 1) + ")";
        }

        private List<int> GetPageTake(int pages, List<string> contextIdSet)
        {
            List<int> takeCounts = new List<int>();

            for (int j = 0; j < pages - 1; j++)
            {
                takeCounts.Add(upperLimitOfPieceCount);
            }

            takeCounts.Add(contextIdSet.Count - (pages - 1) * upperLimitOfPieceCount);

            return takeCounts;
        }

        private DataTable GetSyssettingTable(Constraints constraints)
        {
            string sysSelectSql = "SELECT * FROM SYSSETTING WHERE FIELD_10 = '" + constraints.WheelType + 
                   "' AND TIMETAG > cast('" + constraints.StartTime + "' AS datetime) " +
                   "AND TIMETAG < cast('" + constraints.EndTime + "' AS datetime) ORDER BY TIMETAG";

            return dbAgent.Driver.ExecuteReaderToDataTable(sysSelectSql);
        }


        public void ExportProcessAndMetrologyDataByJsonSerializeObject(List<string> contextIds)
        {
            // if choosed ContextId is larger than 800, paging output
            int pages = (contextIds.Count / upperLimitOfPieceCount) + 1;

            List<int> takeCounts = GetPageTake(pages, contextIds);

            for (int i = 0; i < pages; i++)
            {
                var workIds = contextIds.Skip(i * upperLimitOfPieceCount).Take(takeCounts[i]).ToList();

                ExportDataToTxtByJsonSerializeObject((i + 1), workIds, "PROCESS_OP1L");
                ExportDataToTxtByJsonSerializeObject((i + 1), workIds, "PROCESS_OP2");
                ExportDataToTxtByJsonSerializeObject((i + 1), workIds, "PROCESS_OP3");
                ExportDataToTxtByJsonSerializeObject((i + 1), workIds, "METROLOGY_OP1L");
                ExportDataToTxtByJsonSerializeObject((i + 1), workIds, "METROLOGY_OP2");
                ExportDataToTxtByJsonSerializeObject((i + 1), workIds, "METROLOGY_OP3");
            }

        }

        
        /// <summary>
        /// 用7z壓縮
        /// </summary>
        /// <param name="filePath">7z執行檔的路徑</param>
        /// <param name="zipPath">壓完後檔案的路徑</param>
        /// <param name="sdir">要被壓的檔案路徑</param>
        public void Compress()
        {
            Process p = new Process();
            p.StartInfo.FileName = @"C:\Program Files\7-zip\7z.exe";
            p.StartInfo.Arguments = "a -tzip" + " " + exportDiretory + ".zip" + " " + exportDiretory;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.WaitForExit();
            p.Close();

        }

        public void DeleteDirectoryWithFiles(string directoryPath)
        {
            List<string> files = Directory.GetFiles(directoryPath).ToList();

            foreach (var file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            Directory.Delete(directoryPath);
        }
    }
}
