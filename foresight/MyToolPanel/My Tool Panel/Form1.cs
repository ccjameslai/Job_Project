using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.IO;


namespace My_Tool_Panel
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			SetTextBox3PwdChar();
			
		}

#region 
		private void ProcessDB_Click(object sender, EventArgs e)
		{
			//DBProcesser process = new DBProcesser("PROCESS_AACVD100", false);

			//process.Insert();

			#region

			//string connectionString = string.Format(@"Data Source={0}; User={1}; Password={2}", textBox1.Text, textBox2.Text, textBox3.Text);
			string connectionString = DataBaseConnection.OracleConnection();

			using (var cnt = new OracleConnection(connectionString))
			{
				cnt.Open();

				//StreamReader reader = new StreamReader(@"C:\Users\James\Desktop\METROLOGY.txt");

				//string contextID = "";

				try
				{
					/*
					for (int j = 3; j <= 15; j++)
					{
						for (int i = 1; i <= 15; i++)
						{
							string sqlCommand = "UPDATE PROCESS_AACVD100 SET TIMETAG = " +
												string.Format(
													@"TO_DATE('2015-11-27 09:{0:00}:{1:00}', 'YYYY-MM-DD HH24:MI:SS') WHERE FIELD_21 = '{2}' AND CONTEXTID = 'AACVD100_NULL00{3:00}X_T'",
													(j * 3), i, i, j);

							OracleCommand orclCmd = new OracleCommand(sqlCommand, cnt);
							orclCmd.ExecuteNonQuery();
						}
					}
					*/

					/*
					SqlForMetrology sql = new SqlForMetrology();
					while (!reader.EndOfStream)
					{
						contextID = reader.ReadLine();

						//string Sqlcmd = GetSqlCommand();

						string Sqlcmd = sql.AbnormalByField(contextID);

						OracleCommand orclCmd = new OracleCommand(Sqlcmd, cnt);

						orclCmd.ExecuteNonQuery();
					 */



					//SqlForProcess sql = new SqlForProcess();

					//string Sqlcmd = sql.AbnormalByPiece();


					//OracleCommand orclCmd = new OracleCommand(Sqlcmd, cnt);

					//orclCmd.ExecuteNonQuery();

					/*
					string Sqlcmd = "";

					for (int pieceNum = 6; pieceNum <= 10; pieceNum++)
					{
						for (int ms = 1; ms <= 15; ms++)
						{
							Sqlcmd = sql.UpdateOneSensorToAbnormalByPiece(ms, pieceNum);
							//Sqlcmd = sql.UpdateSensorsToAbnormalByPiece(ms, pieceNum);

							OracleCommand orclCmd = new OracleCommand(Sqlcmd, cnt);

							orclCmd.ExecuteNonQuery();
						}
					}
					*/


					//*******************************************
					SQLStringMaker ssm = new SQLStringMaker();
					//string sql = ssm.Syssetting();
					//string sql = ssm.Metrology();
					string sql = ssm.Process();

					//string sysColName = "CONTEXTID, TIMETAG,TIME01, FIELD_1, FIELD_2, FIELD_3, FIELD_4,FIELD_5,FIELD_6,FIELD_7,FIELD_8,FIELD_9,FIELD_10,FIELD_11,FIELD_12";
					string sysColName = "CONTEXTID, TIMETAG, FIELD_1";
					string sysSqlCmd = string.Format(@"INSERT INTO PROCESS_AACVD100 ({0}) {1}", sysColName, sql);

					OracleCommand orclCmd = new OracleCommand(sysSqlCmd, cnt);

					orclCmd.ExecuteNonQuery();
					//********************************************

					//DBProcesser dbP = new DBProcesser("METROLOGY", true);

					//dbP.Update();

					//string Sqlcmd = GetSqlCommand();

					//OracleCommand orclCmd = new OracleCommand(Sqlcmd, cnt);

					//orclCmd.ExecuteNonQuery();

				}
				catch (System.Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				finally
				{
					cnt.Close();

					MessageBox.Show("It's done!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}

			#endregion

			
		}

		private string GetSqlCommand(string contextID)
		{
			SqlForMetrology sql = new SqlForMetrology();

			string insertSql = string.Format(@"INSERT INTO METROLOGY {0}", sql.AbnormalByField(contextID));

			return insertSql;

			/*
			SQLStringMaker ssm = new SQLStringMaker();

			string sqlSyssetting = ssm.Syssetting();
			string sqlProcess = ssm.Process();
			string sqlMetrology = ssm.Metrology();

			string sysColName =
				"CONTEXTID, TIMETAG,TIME01, FIELD_1, FIELD_2, FIELD_3, FIELD_4,FIELD_5,FIELD_6,FIELD_7,FIELD_8,FIELD_9,FIELD_10,FIELD_11,FIELD_12";
			string sysSqlCmd = string.Format(@"INSERT INTO SYSSETTING ({0}) {1}", sysColName, sqlSyssetting);

			string proColName = "CONTEXTID, TIMETAG, FIELD_1";
			string proSqlCmd = string.Format(@"INSERT INTO PROCESS_AACVD100 ({0}) {1}", proColName, sqlProcess);

			int fieldNum = 1;
			string fields = "";
			for (int i = 1; i <= fieldNum; i++)
			{
				fields += "FIELD_" + i + ",";
			}
			string metroColName = string.Format(@"CONTEXTID, TIMETAG, {0}", fields.Substring(0, fields.Length - 1));

			string metroSqlCmd = string.Format(@"INSERT INTO METROLOGY ({0}) {1}", metroColName, sqlMetrology);

			//return sysSqlCmd;
			return proSqlCmd;
			//return metroSqlCmd;
			*/
		}

		private string GetSqlCommand()
		{
			SqlForMetrology sql = new SqlForMetrology();

			int fieldNum = 71;
			string fields = "";
			for (int i = 71; i <= fieldNum; i++)
			{
				fields += "FIELD_" + i + ",";
			}

			string insertSql = string.Format(@"INSERT INTO METROLOGY (CONTEXTID, TIMETAG, {0}) {1}", fields.Substring(0, fields.Length - 1), sql.AbnormalByPiece());

			return insertSql;
		}


#endregion
		

		private void SetTextBox3PwdChar()
		{
			textBox3.MaxLength = 10;
			textBox3.PasswordChar = '*';
			textBox3.CharacterCasing = CharacterCasing.Upper;
		}


		private void button_APPCheck_Click(object sender, EventArgs e)
		{
			backgroundWorker1.RunWorkerAsync();
		}

		private void AddNewFiles(List<string> filePath, string strDestinationPath)
		{
			foreach (var path in filePath)
			{
				List<string> sourceDirAndFile = GetLastApp(path);

				File.Copy(sourceDirAndFile[0], Path.Combine(strDestinationPath, sourceDirAndFile[1]), true);
			}
		}

		private void DeleteExistedFiles(string path)
		{
			FileInfo[] files = null;

			if (Directory.Exists(path))
			{
				DirectoryInfo di = new DirectoryInfo(path);
				files = di.GetFiles();
			}

			if (files != null)
			{
				foreach (var file in files)
				{
					File.Delete(file.FullName);
				}
			}
		}

		private List<string> GetLastApp(string path)
		{
			FileInfo[] files = null;

			if (Directory.Exists(path))
			{
				DirectoryInfo di = new DirectoryInfo(path);
				files = di.GetFiles();
			}

			DateTime writeTime = Convert.ToDateTime(@"2015/1/1 下午 00:00:00");

			List<string> output = new List<string>();
			string storedfile = "";
			string sourceDir = "";

			if (files != null)
			{
				foreach (var fname in files)
				{
					if (!Is7zfile(fname))
					{
						continue;
					}

				    if (IsHardwareLocked(fname))
				    {
				        continue;
				    }

					if (IsLastDate(writeTime, fname))
					{
						writeTime = fname.LastWriteTime;

						storedfile = fname.Name;

						sourceDir = fname.FullName;
					}
				}

				output.Add(sourceDir);
				output.Add(storedfile);
			}

			return output;
		}

	    private bool IsHardwareLocked(FileInfo fname)
	    {
	        return fname.Name.Contains("[bin.H]");
        }

	    private List<string> GetFilePath(IAPPPath path, bool flag)
		{
			List<string> filepath = new List<string>();

			filepath.Add(path.ControlPanel);
			filepath.Add(path.DCS);
			filepath.Add(path.SICAgent);
			filepath.Add(path.SystemMonitor);

			if (flag)
			{
				filepath.Add(path.MCC);
				filepath.Add(path.MCS);
				filepath.Add(path.VMC);
				filepath.Add(path.VMM);
				filepath.Add(path.VMS);
			}
			else
			{
				filepath.Add(path.SCC);
				filepath.Add(path.SCS);
				filepath.Add(path.FDCC);
				filepath.Add(path.FDCM);
				filepath.Add(path.FDCS);
			}

			return filepath;
		}

		private bool IsLastDate(DateTime writeTime, FileInfo fname)
		{
			return writeTime < fname.LastWriteTime;
		}

		private bool Is7zfile(FileInfo fname)
		{
			return ("7z" == fname.Name.Substring(fname.Name.Length - 2, 2)) ? true : false;
		}


		private void btnCheckOCAP_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();

			string dbConnetionSetting = DataBaseConnection.OracleConnection();

			using (var connection = new OracleConnection(dbConnetionSetting))
			{
				connection.Open();

				string ContextID = GetContextID(connection);
				string StrategyID = textBox5.Text;

				if (ContextID == null || StrategyID == null)
				{
					return;
				}

				Dictionary<string, double[]> interval = GetUSLAndLSL(connection, StrategyID);

				Dictionary<string, double> values = GetValue(connection, ContextID);

				if (values != null && interval != null)
				{
					IsOvertheSpec(interval, values);	
				}

				connection.Close();
			}
		}

		private string GetContextID(OracleConnection orclconnt)
		{
			string pieceID = textBox4.Text;

			string sql = "SELECT CONTEXTID FROM CONTEXTHISTORY WHERE PIECEID = '" + string.Format("{0}", pieceID) + "'";

			OracleCommand orclCmd = new OracleCommand(sql, orclconnt);

			OracleDataReader reader = orclCmd.ExecuteReader();

			if (reader.HasRows)
			{
				reader.Read();

				return Convert.ToString(reader.GetInt32(0));
			}
			else
				return null;
		}

		private void IsOvertheSpec(Dictionary<string, double[]> interval, Dictionary<string, double> values)
		{
			bool NotAnyError = true;

			foreach (var kvp in values)
			{
				if (kvp.Value > interval[kvp.Key][0] || kvp.Value < interval[kvp.Key][1])
				{
					MessageBox.Show("Indicator Out SPEC!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

					NotAnyError = false;

					return;
				}
			}

			if (NotAnyError)
				listBox1.Items.Add("ALL Good!!");
		}

		private Dictionary<string, double> GetValue(OracleConnection connection, string ContextID)
		{
			Dictionary<string, double> temp = new Dictionary<string, double>();

			int counter = 1;

			for (int indx = 1; indx <= 26; indx++)
			{
				string Sql =
				"SELECT * FROM " + string.Format(@"INDICATORVALUE_V{0:00}", indx) + " V, ( " +
				"SELECT CONTEXTID, STRATEGYID FROM CONTEXTHISTORY " +
				string.Format(@"WHERE CONTEXTID = '{0}'", ContextID) +
				" ) C " +
				"WHERE V.CONTEXTID = C.CONTEXTID";

				OracleCommand orclCmd = new OracleCommand(Sql, connection);

				OracleDataReader reader = orclCmd.ExecuteReader();

				if (reader.HasRows)
				{
					
					int number = reader.FieldCount;

					reader.Read();

					for (int i = 0; i < number - 4; i++)
					{
						try
						{
							temp.Add(Convert.ToString(counter), reader.GetDouble(i + 2));

							counter++;
						}
						catch (System.Exception ex)
						{
							break;
						}
						
					}

				}
				else
				{
					MessageBox.Show("ContextID: " + string.Format(@"{0}", ContextID) + " No Found");

					return null;
				}
			}

			return temp;
		}

		private Dictionary<string, double[]> GetUSLAndLSL(OracleConnection connection, string StrategyID)
		{
			Dictionary<string, double[]> temp = new Dictionary<string, double[]>();
			
			
			string Sql =
				"SELECT I.STRATEGYID, I.INDICATORID, I.USL, I.LSL " +
				"FROM INDICATOR I," +
				"( SELECT STRATEGYID, INDICATORID " +
				"FROM INDICATORVALUE_META " +
				string.Format("WHERE StrategyID = '{0}'", StrategyID) +
				") V " +
				"WHERE I.STRATEGYID = V.STRATEGYID " +
				"AND I.INDICATORID = V.INDICATORID " + 
				"ORDER BY INDICATORID";

			OracleCommand orclCmd = new OracleCommand(Sql, connection);

			OracleDataReader reader = orclCmd.ExecuteReader();

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					double[] value = new double[2];

					value[0] = reader.GetDouble(2);
					value[1] = reader.GetDouble(3);

					temp.Add(reader.GetDouble(1).ToString(), value);
				}
			}
			else
			{
				MessageBox.Show("StrategyID: " + string.Format(@"{0}", StrategyID) + " No Found");

				return null;
			}

			return temp;
		}


		const string avmPath = @"\\140.116.86.150\11.RD Department\13.Lastest Version of System App\AVM System";
		const string fdcPath = @"\\\140.116.86.150\11.RD Department\13.Lastest Version of System App\FDC System";

		private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			string strDestinationPath = radioButton1.Checked ? avmPath : fdcPath;

			DeleteExistedFiles(strDestinationPath);

			backgroundWorker1.ReportProgress(30);

			List<string> filePath = radioButton1.Checked ? GetFilePath(new AVMSystem(), radioButton1.Checked) : GetFilePath(new FDCSystem(), radioButton1.Checked);

			backgroundWorker1.ReportProgress(60);

		    try
		    {
                AddNewFiles(filePath, strDestinationPath);
            }
		    catch (Exception ex)
		    {
		        throw new Exception(ex.Message);
		    }
			

			backgroundWorker1.ReportProgress(100);
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			MessageBox.Show("IT'S ALL YOURS!!");
		}

		private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
			progressBar1.Value = e.ProgressPercentage;
		}

	}
}
