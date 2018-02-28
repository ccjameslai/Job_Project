using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReplyService
{
    public class SputterPieceInfo
    {
        public void GetInfo(string strMessageString, Dictionary<string, string> ChildAndValuePairs)
        {
            Device = ChildAndValuePairs["DEVICE"]; // 有設為dispatchkey所以不需轉換
            DeviceType = ChildAndValuePairs["DEVICETYPE"];
            EqpId = ChildAndValuePairs["EQPID"];
            MachineNumber = ChildAndValuePairs["MACHINENUMBER"];
            Layer = ChildAndValuePairs["LAYER"];
            LotId = ChildAndValuePairs["LOTID"];
            WaferId = ChildAndValuePairs["WAFERID"];
        }

        public string Layer;

        public string Device;

        public string DeviceType;

        public string EqpId;

        public string LotId;

        public string WaferId;

        public string MachineNumber;
    }
}