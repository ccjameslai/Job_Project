using System;
using System.Collections.Generic;
using System.IO;

namespace ReplyService
{
    class EtchPieceInfo
    {
        public void GetInfo(string strMessageString, Dictionary<string, string> ChildAndValuePairs)
        {
            Chamber = ChildAndValuePairs["ETCHCHAMBER"];
            Device = ChildAndValuePairs["DEVICE"];
            DeviceType = ChildAndValuePairs["DEVICETYPE"];
            EtchEqpId = ChildAndValuePairs["ETCHEQP"];
            PlatingEqpId = ChildAndValuePairs["PLATINGEQP"];
            Layer = ChildAndValuePairs["VALUENAME"];
            LotId = ChildAndValuePairs["LOTNAME"].Split('_')[0];
            WaferId = ChildAndValuePairs["LOTNAME"].Split('_')[1];
        }

        public string Chamber;

        public string Layer;

        public string Device;

        public string DeviceType;

        public string EtchEqpId;

        public string PlatingEqpId;

        public string LotId;

        public string WaferId;
    }
}