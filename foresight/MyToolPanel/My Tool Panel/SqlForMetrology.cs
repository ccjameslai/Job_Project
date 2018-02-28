using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace My_Tool_Panel
{
	class SqlForMetrology
	{
		public string AbnormalByField(string contextID)
		{
			string abnormalValue = GetAbnormalValue();
			
			return string.Format(@"UPDATE METROLOGY SET FIELD_71 = '{0}' WHERE CONTEXTID = '{1}'  ", abnormalValue, contextID);
		}

		public string AbnormalByPiece()
		{
			string sensorValue = "";
			for (int i = 1; i <=70; i++)
			{
				sensorValue += "'" + GetAbnormalValue() + "'" + ", ";
			}

			string Sql = string.Format(@"SELECT 'AACVD100_NULL0002X_T', TO_DATE('2015-11-27 10:02', 'YYYY-MM-DD HH24:MI:SS'), 'T', {0} FROM DUAL", sensorValue.Substring(0, sensorValue.Length - 2));

			return Sql;
		}


		private string GetAbnormalValue()
		{
			Random random = new Random(Guid.NewGuid().GetHashCode());
			
			int valueType = random.Next(1, 6);

			string abnormalValue = "";

			switch (valueType)
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
				case (int)ValueType.Alph:
					abnormalValue = "2^2";
					break;
				default:
					break;
			} 
			
			return abnormalValue;
		}





	}



	public enum ValueType: int
	{
		ExtremMax = 1,
		ExtemeMin,
		NagtiveValue,
		Alph,
		Null,
	}
}
