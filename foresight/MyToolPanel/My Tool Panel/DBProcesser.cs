using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace My_Tool_Panel
{
	class DBProcesser
	{
		private string Contextid;
		private string Timetag;
		private string Time01;
		private string Fields;
		private string TableName;

		private List<string> Values;

		private bool _isNullOrExist;

		public DBProcesser(string tableName, bool isNullOrExist)
		{
			TableName = tableName;

			_isNullOrExist = isNullOrExist;

			//Fields = GetFields(1);

			//Values = GetValues();
		}

		public void Insert()
		{
			string sqlCommand = GetSqlCommand();

			ExecuteSql(sqlCommand);
		}

		public void Update()
		{
			string sqlSelect = "SELECT * FROM METROLOGY WHERE CONTEXTID = 'AACVD100_NEGT0006Y_T'";

			ExecuteSql(sqlSelect);
		}

		private string GetFields(int numberOffields)
		{
			string fields = "";
			for (int i = 1; i <= numberOffields; i++)
			{
				fields += fields + ", 'FIELD_" + i + "', ";
			}

			return fields.Substring(0, fields.Length - 2);
		}

		private List<string> GetValues()
		{
			List<string> values = new List<string>();

			OpenFileDialog openFile = new OpenFileDialog();

			string file = "";
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				openFile.FileName = file;
			}

			StreamReader reader = new StreamReader(file);

			while (!reader.EndOfStream)
			{
				string[] temp = reader.ReadLine().Split(',');

				
			}

			return values;
		}

		private string  GetSqlCommand()
		{
			string sqlInsert = "";
			if (TableName == "SYSSETTING")
			{
				sqlInsert = "INSERT INTO " + string.Format(@"{0} (CONTEXTID, TIMETAG, TIME01 {1})", TableName, Fields);
			}
			else
			{
				sqlInsert = "INSERT INTO " + string.Format(@"{0} (CONTEXTID, TIMETAG {1})", TableName, Fields);
			}

			const int dataNumber = 15;

			string sqlSelect = "";
			for (int times = 1; times <= dataNumber; times++)
			{
				sqlSelect = "SELECT " + string.Format(@"{0}", Values) + " FROM DUAL UNION ALL ";
			}
			sqlSelect = sqlSelect.Substring(0, sqlSelect.Length - 11);

			return sqlInsert + " " + sqlSelect;
		}

		private void ExecuteSql(string sqlCommand)
		{
			string dbInfo = DataBaseConnection.OracleConnection();

			using (var cnt = new OracleConnection(dbInfo))
			{
				cnt.Open();

				try
				{
					//OracleCommand orclCmd = new OracleCommand(sqlCommand, cnt);

					//OracleDataReader reader = orclCmd.ExecuteReader();

					//reader.Read();

					string fields = "";
					for (int indx = 2; indx <= 34; indx++)
					{
						string value = "0";
						
						fields += "FIELD_" + indx + " = " + "'" + value + "', ";
					}
					fields = fields.Substring(0, fields.Length - 2);

					string sqlUpdate = "UPDATE METROLOGY SET " + fields + " WHERE CONTEXTID = 'AACVD100_ZERO0001Y_T'";

					OracleCommand sqlCmd = new OracleCommand(sqlUpdate, cnt);

					sqlCmd.ExecuteNonQuery();
				}
				catch (System.Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				finally
				{
					cnt.Close();
				}
			}
		}

		private string ProcessData(OracleCommand orclCmd)
		{
			OracleDataReader orclReader = orclCmd.ExecuteReader();


			List<string> tempvalue = new List<string>();

			string fields = "";
			for (int indx = 2; indx <= 68; indx++)
			{
				fields += "FIELD_" + indx + " = " + "'-" + orclReader.GetString(indx) + "', ";
			}
			fields = fields.Substring(0, fields.Length - 2);

			return "UPDATE METROLOGY SET " + fields + " WHERE CONTEXTID = 'AACVD100_NEGT0006Y_T'";
		}

		

	}
}
