using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Tool_Panel
{
	class SQLStringMaker
	{
		private StringBuilder sb;

		public string Syssetting()
		{
			sb = new StringBuilder();

			for (int num = 11; num <= 20; num++)
			{
				string sqlSyssetting = string.Format(@"SELECT 'AACVD100_NEGT00{0:00}Y_T', TO_DATE('2015-12-04 10:{1:00}:00', 'YYYY-MM-DD HH24:MI:SS'), TO_DATE('2015-12-04 10:{2:00}:00', 'YYYY-MM-DD HH24:MI:SS')
												, 'AACVD100','CHT_NEGTY','GOAmulti','ZZ5Z727600', 'NEGT00{3:00}Y_T','Z','26','Z06-099609','1204aa','1204aa','cvdbFRI_DEC_12_20_04_01_2015_Z06-099609','T' FROM DUAL", num, (num * 2), (num + 10), num);

				sb.Append(sqlSyssetting);
				sb.Append(" UNION ALL ");
			}

			return sb.ToString().Substring(0, sb.ToString().Length - 11);
		}

		public string Process()
		{
			sb = new StringBuilder();

			for (int num = 11; num <= 20; num++)
			{
				for (int ms = 1; ms <= 15; ms++)
				{
					string sqlProcess = string.Format(@"SELECT 'AACVD100_NEGT00{0:00}Y_T', TO_DATE('2015-12-04 10:{1:00}:{2:00}', 'YYYY-MM-DD HH24:MI:SS'), '1' FROM DUAL", num, (num * 2), ms);

					sb.Append(sqlProcess);
					sb.Append(" UNION ALL ");
				}
			}

			return sb.ToString().Substring(0, sb.ToString().Length - 11);
		}


		public string Metrology()
		{
			sb = new StringBuilder();

			for (int num = 11; num <= 20; num++)
			{
				string sqlMetrology = string.Format(@"SELECT 'AACVD100_NEGT00{0:00}Y_T', TO_DATE('2015-12-7 18:{1:00}:00', 'YYYY-MM-DD HH24:MI:SS'), 'T' FROM DUAL", num, num);

				sb.Append(sqlMetrology);
				sb.Append(" UNION ALL ");
			}

			return sb.ToString().Substring( 0, sb.ToString().Length - 11);
		}



	}
}
