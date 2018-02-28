using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Tool_Panel
{
	static class DataBaseConnection
	{
		public static string OracleConnection()
		{
			string DSN = "DB232";
			string UID = "WIN_CDB";
			string PWD = "WIN_CDB";
			
			return string.Format(@"Data Source={0}; User={1}; Password={2}", DSN, UID, PWD);
		}
	}
}
