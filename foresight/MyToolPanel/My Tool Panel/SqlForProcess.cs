using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Tool_Panel
{
	class SqlForProcess
	{
		public string AbnormalByPiece()
		{
			StringBuilder sb = new StringBuilder();

			string selectSql = "";

			string abnormalValue = "'5','0','0','0','9418.4','24331.7','2855.8','0','0','341.8','370.2','1496.35','2.14','5.71','11173.98','4.39','-60.78','754.23','1035'";
				//"'1','0','0','0','0','0','2602','0','26022.6','341.5','370','2689.44','3.23','3.84','918.66','0','-1.62','31.98','600'";
			
			for (int i = 1; i <= 10; i++)
			{
				for (int ms = 1; ms <= 15; ms++)
				{
					sb.Append(string.Format(@"SELECT 'AACVD100_CTN200{0:00}Y_T', TO_DATE('2015-12-03 09:{1:00}:{2:00}', 'YYYY-MM-DD HH24:MI:SS'), {3} FROM DUAL", i, (i + 40), ms, abnormalValue));

					sb.Append(" UNION ALL ");
				}
			}

			string fieldName = "";

			int fieldNum = 19;
			for (int i = 1; i <= fieldNum; i++)
			{
				fieldName += "FIELD_" + i + ",";
			}

			selectSql = string.Format(@"INSERT INTO PROCESS_AACVD100 (CONTEXTID, TIMETAG, {0}) {1}", fieldName.Substring(0, fieldName.Length - 1), sb.ToString().Substring(0, sb.ToString().Length - 11));

			return selectSql;
		}


		public string UpdateOneSensorToAbnormalByPiece(int ms, int pieceNum)
		{
			Random random = new Random(Guid.NewGuid().GetHashCode());
			int indexOfField = random.Next(2, 20);
			int abnormalType = random.Next(1, 5);

			string abnormalValue = "";

			switch (abnormalType)
			{
				case (int)ValueType.ExtremMax:
					abnormalValue = random.Next(8000, 9000).ToString();
					break;
				case (int)ValueType.ExtemeMin:
					abnormalValue = random.Next(10, 19).ToString();
					break;
				case (int)ValueType.NagtiveValue:
					abnormalValue = random.Next(-8, 0).ToString();
					break;
				case (int)ValueType.Null:
					abnormalValue = "";
					break;
				default:
					break;
			}


			string updateSql = string.Format(@"UPDATE PROCESS_AACVD100 SET FIELD_{0} = '{1}' WHERE TIMETAG = TO_DATE('2015-11-30 12:{2:00}:{3:00}', 'YYYY-MM-DD HH24:MI:SS') AND CONTEXTID = 'AACVD100_ABNM00{4:00}X_T'",
				indexOfField, abnormalValue, pieceNum, ms, pieceNum);

			return updateSql;
		}


		public string UpdateSensorsToAbnormalByPiece(int ms, int pieceNum)
		{
			Random random = new Random(Guid.NewGuid().GetHashCode());

			int sensorNumber = random.Next(1, 20);
			
			//string abnormalValue = "";

			//Dictionary<int, string> fieldAndAbnormalType = new Dictionary<int, string>();

			List<int> fieldIndex = new List<int>();
			List<string> abnormalValue = new List<string>();

			Dictionary<int, int> storedNum = new Dictionary<int, int>();

			for (int i = 1; i <= sensorNumber; i++)
			{
				int abnormalType = random.Next(1, 5);

				GetAbnormalValue(abnormalType, random, ref abnormalValue);

				GetWithoutReplayedIndex(random, ref storedNum, ref fieldIndex);

				//fieldAndAbnormalType.Add(random.Next(2, 20), abnormalValue);
			}

			string updateContent = "";
			//foreach (var kvp in fieldAndAbnormalType)
			//{
			//	updateContent += "FIELD_" + kvp.Key + " = '" + kvp.Value + "', ";
			//}

			for (int i = 0; i < fieldIndex.Count; i++)
			{
				updateContent += "FIELD_" + fieldIndex[i] + " = '" + abnormalValue[i] + "', ";
			}


			string updateSql = string.Format(@"UPDATE PROCESS_AACVD100 SET {0} WHERE TIMETAG = TO_DATE('2015-11-30 12:{1:00}:{2:00}', 'YYYY-MM-DD HH24:MI:SS') AND CONTEXTID = 'AACVD100_ABNM09{3:00}X_T'",
				updateContent.Substring(0, updateContent.Length - 2), pieceNum, ms, pieceNum);

			return updateSql;
		}

		private void GetWithoutReplayedIndex(Random random, ref Dictionary<int, int> storedNum, ref List<int> fieldIndex)
		{
			int ranNum = random.Next(2, 20);

			if (!storedNum.ContainsKey(ranNum))
			{
				storedNum.Add(ranNum, 1);

				fieldIndex.Add(ranNum);
			}
		}

		private void GetAbnormalValue(int abnormalType, Random random, ref List<string> abnormalValue)
		{
			switch (abnormalType)
			{
				case (int)ValueType.ExtremMax:
					abnormalValue.Add(random.Next(8000, 9000).ToString());
					break;
				case (int)ValueType.ExtemeMin:
					abnormalValue.Add(random.Next(10, 19).ToString());
					break;
				case (int)ValueType.NagtiveValue:
					abnormalValue.Add(random.Next(-8, 0).ToString());
					break;
				case (int)ValueType.Null:
					abnormalValue.Add("");
					break;
				default:
					break;
			}
		}
	}
}
