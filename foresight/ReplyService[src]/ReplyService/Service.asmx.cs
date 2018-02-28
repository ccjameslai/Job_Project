using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Data.Odbc;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Net;
using System.IO.Compression;
using System.Data.OracleClient;
using System.Web.Services.Protocols;
using System.Xml;
using System.Collections;
using System.Threading;
using System.Diagnostics;
using fst.AVMUtility;
using fst.TopISI;

namespace ReplyService
{
    /// <summary>
    ///Service1 的摘要描述
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)] 
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下一行。
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    { 
        [WebMethod(Description = "Dispatch Reply (OCAP) V1.0")]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Xml)]
        public string MESConsole(int iMessageID, string strMessageString)
        {
            string strSuccess = "Success";

            if (iMessageID == 1) //1為 Online
            {
                try
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    string tt = Server.MapPath("~/App_Data/system.ini");
                    string t1 = Server.MapPath("system.ini");
                    string t2 = Server.MapPath("~/system.ini");
                    ResultStructure pResultStructure = ResultParser.GetResult(strMessageString, Server.MapPath("~/App_Data/system.ini"));
                    //ResultStructure pResultStructure = ResultParser.GetResult(strMessageString, Server.MapPath(@"C:\Users\James\Desktop\system.ini"));
                    sw.Stop();

                    strSuccess += string.Format(", CaseName: {0}, ContextID: {1}, PhaseType: {2}, IsAction: {3}, AVMData has {4} Result, ISDInfo NeedMeasure: {5}, ISDInfo Remark: {6}, Elapsed: {7} sec",
                                                pResultStructure.CaseName,
                                                pResultStructure.ContextID,
                                                pResultStructure.Type,
                                                pResultStructure.IsAction,
                                                pResultStructure.AVMData.Rows.Count,
                                                pResultStructure.mISDInfo.NeedMeasure,
                                                pResultStructure.mISDInfo.Remark,
                                                (double)sw.ElapsedMilliseconds / 1000
                                                );

                    // 執行想要的行為
                    DoSomething(pResultStructure.ContextID);
                    
                }
                catch (System.Exception ex)
                {
                    strSuccess = "Fail, " + ex.ToString();
                }
            }
            else if (iMessageID == 0) //0為 Offline
            {
                //if Offline do nothing
                strSuccess = "Success, do nothing";
            }

            return strSuccess;
        }

        /// <summary>
        /// 想要的行為
        /// </summary>
        /// <param name="strMessageString"></param>
        private void DoSomething(string strMessageString)
        {
            // 視製程選擇類別來使用
            PhotoPieceInfo piece = new PhotoPieceInfo(); 
            //EtchPieceInfo piece = new EtchPieceInfo();
            //SputterPieceInfo piece = new SputterPieceInfo();

            // 從SICClient取得相關資訊
            var ChildAndValuePairs = GetChildAndValuePairs(strMessageString);

            // 取得生產履歷資訊
            piece.GetInfo(strMessageString, ChildAndValuePairs);


            TopISI topISI = new TopISI();

            //DataTable dt = topISI.getTopISI(strMessageString, 5);
            DataTable dt = topISI.getTopISI(strMessageString, 5);

        }

        private Dictionary<string, string> GetChildAndValuePairs(string strMessageString)
        {
            // Xml處理器
            BaseCommandXml bc = new BaseCommandXml();

            bc.LoadXml(strMessageString);

            // 取得生產履歷相關資訊
            XmlNodeList node = bc.GetXmlNodeListOfParameter("PieceInfo");

            Dictionary<string, string> ChildAndValuePairs = new Dictionary<string, string>();

            foreach (XmlNode param in node)
            {
                var child = param.Attributes["name"].Value;
                var value = param.InnerText;

                ChildAndValuePairs.Add(child, value);
            }
            return ChildAndValuePairs;
        }
    }

    
}