using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Tool_Panel
{
	class AVMSystem:IAPPPath
	{
		#region IAPPPath 成員

		public string ControlPanel
		{
			get
			{
				return @"\\140.116.86.150\06.ControlPanelVersionControl\Exe";
			}
			
		}

		public string MCS
		{
			get
			{
				return @"\\140.116.86.150\02.AVMVersionControl\00.Project Version Control\(V01)Internal Project\AVM V01.00.04\MC System\Beta\MC System V01.00.14\MC Server\Exe";
			}
			
		}

		public string MCC
		{
			get
			{
				return
					@"\\140.116.86.150\02.AVMVersionControl\00.Project Version Control\(V01)Internal Project\AVM V01.00.04\MC System\Beta\MC System V01.00.14\MC Client\Exe";
			}
			
		}

		public string DCS
		{
			get
			{
				return @"\\140.116.86.150\02.AVMVersionControl\00.Project Version Control\(V01)Internal Project\AVM V01.00.04\DCS\Exe";
			}
			
		}

		public string VMM
		{
			get
			{
				return @"\\140.116.86.150\02.AVMVersionControl\00.Project Version Control\(V01)Internal Project\AVM V01.00.04\VM Manager\Exe\AfterZValue";
			}
			
		}

		public string VMS
		{
			get
			{
				return @"\\140.116.86.150\02.AVMVersionControl\00.Project Version Control\(V01)Internal Project\AVM V01.00.04\VM Server\Exe\(2)AfterZValue";
			}
			
		}

		public string VMC
		{
			get
			{
				return @"\\140.116.86.150\02.AVMVersionControl\00.Project Version Control\(V01)Internal Project\AVM V01.00.04\VM Client\Exe";
			}
			
		}

		public string SICAgent
		{
			get
			{
				return @"\\140.116.86.150\02.AVMVersionControl\00.Project Version Control\(V01)Internal Project\AVM V01.00.04\SIC Agent\Exe";
			}
			
		}

		public string SystemMonitor
		{
			get
			{
				return @"\\140.116.86.150\02.AVMVersionControl\00.Project Version Control\(V01)Internal Project\AVM V01.00.04\SystemMonitor";
			}
			
		}

		public string SCC
		{
			get
			{
				throw new NotImplementedException();
			}
			
		}

		public string SCS
		{
			get
			{
				throw new NotImplementedException();
			}
			
		}

		public string FDCM
		{
			get
			{
				throw new NotImplementedException();
			}
			
		}

		public string FDCS
		{
			get
			{
				throw new NotImplementedException();
			}
			
		}

		public string FDCC
		{
			get
			{
				throw new NotImplementedException();
			}
			
		}

		#endregion
	}
}
