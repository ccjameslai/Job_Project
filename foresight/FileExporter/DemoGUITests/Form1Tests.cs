using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExporter;

namespace DemoGUI.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void GetProcSelectSqlTest()
        {
            //Form1 target = new Form1();

            //string expected = "SELECT * FROM PROCESS_OP1L WHERE CONTEXTID = '123_886_3_WVD-24X_C_AOI' " +
            //                  "UNION ALL SELECT * FROM PROCESS_OP1L " +
            //                  "WHERE CONTEXTID = '123_886_1_WVL-F24_L_P_AOI'";

            //string actual = target.GetProcSelectSql(contextIdset);

            //Assert.AreEqual(expected, actual);
        }


        List<string> contextIdset = new List<string>
        {
            "123_886_3_WVD-24X_C_AOI", "123_886_1_WVL-F24_L_P_AOI"
        };
    }
}