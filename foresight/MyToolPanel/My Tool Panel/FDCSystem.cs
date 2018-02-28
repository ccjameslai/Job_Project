using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Tool_Panel
{
	class FDCSystem:IAPPPath
	{

		#region IAPPPath 成員

		public string ControlPanel
		{
			get { return @"\\140.116.86.150\06.ControlPanelVersionControl\Exe"; }
		}

		public string MCS
		{
			get { throw new NotImplementedException(); }
		}

		public string MCC
		{
			get { throw new NotImplementedException(); }
		}

		public string DCS
		{
			get { return @"\\140.116.86.150\02.AVMVersionControl\00.Project Version Control\(V01)Internal Project\AVM V01.00.04\DCS\Exe"; }
		}

		public string VMM
		{
			get { throw new NotImplementedException(); }
		}

		public string VMS
		{
			get { throw new NotImplementedException(); }
		}

		public string VMC
		{
			get { throw new NotImplementedException(); }
		}

		public string SICAgent
		{
			get { return @"\\140.116.86.150\02.AVMVersionControl\00.Project Version Control\(V01)Internal Project\AVM V01.00.04\SIC Agent\Exe"; }
		}

		public string SystemMonitor
		{
			get { return @"\\140.116.86.150\02.AVMVersionControl\00.Project Version Control\(V01)Internal Project\AVM V01.00.04\SystemMonitor"; }
		}

		public string SCC
		{
			get { return @"\\140.116.86.150\03.FDCVersionControl\3. SC System\SC System V01.00.03\SC Client\Exe"; }
		}

		public string SCS
		{
			get { return @"\\140.116.86.150\03.FDCVersionControl\3. SC System\SC System V01.00.03\SC Server\Exe"; }
		}

		public string FDCM
		{
			get { return @"\\140.116.86.150\03.FDCVersionControl\2. FDC Manager\Exe"; }
		}

		public string FDCS
		{
			get { return @"\\140.116.86.150\03.FDCVersionControl\5. FDC Server\Exe"; }
		}

		public string FDCC
		{
			get { return @"\\140.116.86.150\03.FDCVersionControl\1. FDC Client"; }
		}

		#endregion
	}
}
