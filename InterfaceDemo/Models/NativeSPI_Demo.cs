using System.Collections.Generic;
using System.Text;
using FS.NetDCU;

namespace InterfaceDemo.Models
{
    public class NativeSPI_Demo
    {
        public static byte[] Exchange(string spiDev, byte[] data)
        {
            #region DbgMsg110
            //Debug Message
            List<string> msg110 = new List<string>
            {
                $"spiDev: {spiDev}",
                $"data Write: {Encoding.UTF8.GetString(data, 0, data.Length)}",
            };
            DebugMsg.WriteDbgMsg("110", msg110);
            #endregion

            NspiPort nspi = new NspiPort(spiDev, NspiPort.NspiAccess.READ_WRITE);
            nspi.Exchange(data);

            #region DbgMsg111
            //Debug Message
            List<string> msg111 = new List<string>
            {
                $"spiDev: {spiDev}",
                $"data Read: {Encoding.UTF8.GetString(data, 0, data.Length)}",
            };
            DebugMsg.WriteDbgMsg("111", msg111);
            #endregion

            return data;
        }
    }
}
