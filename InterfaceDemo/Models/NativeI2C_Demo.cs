using System.Collections.Generic;
using FS.NetDCU;

namespace InterfaceDemo.Models
{
    public class NativeI2C_Demo
    {
        private string i2cdev;
        private byte devAddr;
        private byte flags;
        NI2CFile ni2c;
        NI2CFile.NI2C_MSG_HEADER[] mymsg;

        public NativeI2C_Demo(string i2cdev, byte devAddr, byte flags)
        {
            this.i2cdev = i2cdev;
            this.devAddr = (byte)(devAddr << 1); // Shift 1 bit
            this.flags = flags;

            /* Create NI2CFile object */
            ni2c = new NI2CFile(i2cdev, NI2CFile.NI2CAccess.WRITE);

            SetDeviceToReadMode();
        }

        private void SetDeviceToReadMode()
        {
            /* Set I2C Device to read mode */
            byte[] config = new byte[]
                {
                    0x06, 0x00, 0x00,
                };

            #region DbgMsg100
            //Debug Message
            List<string> msg100 = new List<string>
            {
                $"i2cdev: {i2cdev}",
                $"devAddr: {devAddr}",
                $"flags: {flags}",
                $"length:{config.Length.ToString()}",
            };
            DebugMsg.WriteDbgMsg("100", msg100);
            #endregion

            WriteI2C(config);
        }

        public void WriteI2C(byte[] mydata)
        {
            mymsg = new NI2CFile.NI2C_MSG_HEADER[]
                {
                    new NI2CFile.NI2C_MSG_HEADER(devAddr, flags, (ushort)mydata.Length)
                };

            #region DbgMsg101
            //Debug Message
            List<string> msg101 = new List<string>
            {
                $"devAddr: {devAddr}",
                $"flags: {flags}",
                $"length:{mydata.Length.ToString()}",
            };
            DebugMsg.WriteDbgMsg("101", msg101);
            #endregion

            /* Schedule transmission request */
            ni2c.Schedule(mymsg, mydata);
        }
    }
}
