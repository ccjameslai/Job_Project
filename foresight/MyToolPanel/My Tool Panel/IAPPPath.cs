using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_Tool_Panel
{
	interface IAPPPath
	{
		string ControlPanel { get; }
		
		string MCS { get;  }
		string MCC { get; }
		string DCS { get;  }

		string VMM { get;  }
		string VMS { get;  }
		string VMC { get;  }

		string SICAgent { get;  }
		string SystemMonitor { get;  }

		string SCC { get;  }
		string SCS { get;  }

		string FDCM { get;  }
		string FDCS { get;  }
		string FDCC { get; }
	}
}
