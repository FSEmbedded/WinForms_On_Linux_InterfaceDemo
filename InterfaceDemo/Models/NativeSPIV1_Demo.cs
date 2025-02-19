using System.Collections.Generic;
using System.Text;
using FS.NetDCU;

namespace InterfaceDemo.Models
{
    public class NativeSPIV1_Demo
    {
        public static byte[] Exchange(string spiDev, byte[] data)
        {
            #region DbgMsg120
            //Debug Message
            List<string> msg120 = new List<string>
            {
                $"spiDev: {spiDev}",
                $"data Write: {Encoding.UTF8.GetString(data, 0, data.Length)}",
            };
            DebugMsg.WriteDbgMsg("120", msg120);
            #endregion

            NspiPortV1 nspi = new NspiPortV1(spiDev, NspiPortV1.NspiAccess.READ_WRITE);
            nspi.Exchange(data);

            #region DbgMsg120
            //Debug Message
            List<string> msg121 = new List<string>
            {
                $"spiDev: {spiDev}",
                $"data Read: {Encoding.UTF8.GetString(data, 0, data.Length)}",
            };
            DebugMsg.WriteDbgMsg("121", msg121);
            #endregion

            return data;            
        }
    }
}
