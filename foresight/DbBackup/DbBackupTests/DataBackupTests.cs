using Microsoft.VisualStudio.TestTools.UnitTesting;
using DbBackup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbBackup.Tests
{
    [TestClass()]
    public class DataBackupTests
    {
        [TestMethod()]
        public void SearchUserNameTest()
        {
            DataBackup dbp = new DataBackup();

            var excepted = UserNames;

            var actual = dbp.SearchUserName();

            Assert.AreEqual(excepted[0], actual[0]);
            Assert.AreEqual(excepted[1], actual[1]);
            Assert.AreEqual(excepted[2], actual[2]);
            Assert.AreEqual(excepted[3], actual[3]);

        }

        

        private List<string> UserNames = new List<string>
        {
            "FATEK_CDB1", "FATEK_STDB2", "FATEK_CDB", "FATEK_CDB2"
        };
    }
}