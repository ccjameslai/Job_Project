using System.Runtime.InteropServices;
using System.Text;

namespace DemoGUI
{
    static class MyExtends
    {
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath">完整路徑</param>
        /// <returns></returns>
        public static string GetConnectionStringFromIniForSQLBulkCopy(string filePath)
        {
            int size = 888;//temp file source size 

            StringBuilder sb = new StringBuilder(size); //temp file source

            int i = GetPrivateProfileString("RECOVER STDB", "ConnectionString", "", sb, size, filePath);

            return sb.ToString();
        }
    }
}
