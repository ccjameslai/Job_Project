using Microsoft.VisualStudio.TestTools.UnitTesting;
using SystemPreChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemPreChecker.Tests
{
    [TestClass()]
    public class InstallationCheckerTests
    {
        [TestMethod()]
        public void 驗證是否已經安裝7z()
        {
            InstallationChecker target = new InstallationChecker();

            var actaul = target.Is7zInstalled();

            var expected = true;

            Assert.AreEqual(expected, actaul);
        }

        [TestMethod()]
        public void 驗證是否已經安裝dot_Net_Framework4_0()
        {
            InstallationChecker target = new InstallationChecker();

            var actaul = target.IsIISSetup(@"http://127.0.0.1");

            var expected = true;

            Assert.AreEqual(expected, actaul);
        }

       
       
    }
}