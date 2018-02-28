using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReplyService
{
    public class PhotoPieceInfo
    {
        public void GetInfo(string strMessageString, Dictionary<string, string> ChildAndValuePairs)
        {
            Chamber = ChildAndValuePairs["DCHAMBER2"];
            MachineNumber = ChildAndValuePairs["DMACHINENUMBER"];
            DeviceType = ChildAndValuePairs["DDEVICETYPE"];
            Device = ChildAndValuePairs["DDEVICE"];
            EqpId = ChildAndValuePairs["DEQPID"];
            Layer = ChildAndValuePairs["DLAYER"];
            LotId = ChildAndValuePairs["LOTID"];
            WaferId = ChildAndValuePairs["WAFERID"];
        }

        public string Chamber;

        public string Layer;

        public string Device;

        public string DeviceType;

        public string EqpId;

        public string LotId;

        public string WaferId;

        public string MachineNumber;
    }
}