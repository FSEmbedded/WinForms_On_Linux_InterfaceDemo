using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using InterfaceDemo.Models;
using System.Globalization;
using System.Threading;
using System.Drawing;

namespace InterfaceDemo
{
    public partial class Form1 : Form
    {
        /* OS specific device names / addresses */
        private string i2cdev_Win = "I2C2:";
        private string spi1dev_Win = "SPI1:";
        private string spi2dev_Win = "SPI2:";
        private string i2cdev_Linux = "/dev/i2c-2";
        private string spi1dev_Linux = "/dev/spidev0.0";
        private string spi2dev_Linux = "/dev/spidev4.1";

        #region Initialization
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            SetOsSpecificUI(DetectOS());
            ActivateUartUi(false);
            EmptyResultLabels();
            SetDescriptionText();

            checkBoxDbgMsg.Checked = DebugMsg.SendDbgMsg;
            SetDebugState();
            #region DbgMsg000
            //Debug Message
            List<string> msg000 = new List<string>
            {
                $"FORM1 INITIALIZED",
            };
            DebugMsg.WriteDbgMsg("000", msg000);
            #endregion
        }

        private PlatformID DetectOS()
        {
            /* NativeSpi is only available for Windows, Linux uses NativeSpiV1 */
            OperatingSystem os = Environment.OSVersion;
            PlatformID pid = os.Platform;
            return pid;
        }

        private void SetOsSpecificUI(PlatformID pid)
        {
            if (pid != PlatformID.WinCE)
            {
                tbSpiDev.Enabled = false;
                tbSpiWriteData.Enabled = false;
                btnNativeSpi.Enabled = false;
                tbI2cDev.Text = i2cdev_Linux;
                tbSpiDev.Text = spi1dev_Linux;
                tbSpiV1Dev.Text = spi2dev_Linux;
            }
            else
            {
                tbI2cDev.Text = i2cdev_Win;
                tbSpiDev.Text = spi1dev_Win;
                tbSpiV1Dev.Text = spi2dev_Win;
            }
        }

        private void EmptyResultLabels()
        {
            lblSpiRead.Text = string.Empty;
            lblSpiResult.Text = string.Empty;
            lblSpiV1Read.Text = string.Empty;
            lblSpiV1Result.Text = string.Empty;
            lblUartRead.Text = string.Empty;
            lblUartResult.Text = string.Empty;
        }

        private void SetDescriptionText()
        {
            lblI2cDescription.Text = $"Preset values for I2C Extension Board.{Environment.NewLine}"+
                 "On EFUS-SINTF, connect to J22-45 (I2C_B_DAT), J22-46 (I2C_B_CLK) and J22-49 (GND).";
            lblSpiDescription.Text = $"This demo uses the NspiPort.Exchange()-method to write and read on the set SPI device.{Environment.NewLine}" +
                $"On EFUS-SINTF, use J22-33 (SPI_A_MISO) and J22-34 (SPI_A_MOSI) or{Environment.NewLine}"+
                $"J22-23 (SPI_B_MISO) and J22-24 (SPI_B_MOSI).{Environment.NewLine}" + 
                 "On Linux, only NativeSPI-V1.dll is available!";
            lblUartDescription.Text = $"On EFUS-SINTF:{Environment.NewLine}" +
                $"COM2 / /dev/ttymxc2: J15-3 (RXD_B_RS232) & J15-5 (TXD_B_RS232){Environment.NewLine}" +
                 "COM4 / /dev/ttymxc5: J22-14 (RXD_D_TTL) & J22-16 (TXD_D_TTL)";
        }
        #endregion

        #region I2C
        private void btnI2c_Click(object sender, EventArgs e)
        {
            #region DbgMsg001
            //Debug Message
            List<string> msg001 = new List<string>
            {
                $"i2cdev-string: {tbI2cDev.Text}",
                $"devAddr-string: {tbI2cDevAddr.Text}",
                $"flags-string: {tbI2cFlags.Text}",
                $"mydata0-string: {tbI2cData0.Text}",
                $"mydata1-string: {tbI2cData1.Text}",
                $"mydata2-string: {tbI2cData2.Text}",
            };
            DebugMsg.WriteDbgMsg("001", msg001);
            #endregion

            string i2cDev = tbI2cDev.Text;
            byte i2cDevAddr = byte.Parse(tbI2cDevAddr.Text, NumberStyles.HexNumber);
            byte i2cFlags = byte.Parse(tbI2cFlags.Text, NumberStyles.HexNumber);
            byte i2cData0 = byte.Parse(tbI2cData0.Text, NumberStyles.HexNumber);
            byte i2cData1 = byte.Parse(tbI2cData1.Text, NumberStyles.HexNumber);
            byte i2cData2 = byte.Parse(tbI2cData2.Text, NumberStyles.HexNumber);
            byte[] i2cData = { i2cData0, i2cData1, i2cData2 };

            #region DbgMsg002
            //Debug Message
            List<string> msg002 = new List<string>
            {
                $"i2cDev: {i2cDev}",
                $"i2cDevAddr: {i2cDevAddr}",
                $"i2cFlags: {i2cFlags}",
                $"i2cData0: {i2cData0}",
                $"i2cData1: {i2cData1}",
                $"i2cData2: {i2cData2}",
            };
            DebugMsg.WriteDbgMsg("002", msg002);
            #endregion

            NativeI2C_Demo i2c = new NativeI2C_Demo(i2cDev, i2cDevAddr, i2cFlags);
            i2c.WriteI2C(i2cData);
        }
        #endregion

        #region SPI
        private void btnNativeSpi_Click(object sender, EventArgs e)
        {
            #region DbgMsg010
            //Debug Message
            List<string> msg010 = new List<string>
            {
                $"spiDev-string: {tbSpiDev.Text}",
                $"spiWriteData-string: {tbSpiWriteData.Text}",
            };
            DebugMsg.WriteDbgMsg("010", msg010);
            #endregion

            string spiDev = tbSpiDev.Text;
            byte[] spiWriteData = Encoding.UTF8.GetBytes(tbSpiWriteData.Text);
            int dataLen = spiWriteData.Length;

            #region DbgMsg011
            //Debug Message
            List<string> msg011 = new List<string>
            {
                $"spiDev: {spiDev}",
                $"spiWriteData: {spiWriteData}",
                $"dataLen: {dataLen}",
            };
            DebugMsg.WriteDbgMsg("011", msg011);
            #endregion

            /* Call Exchange Method, returns byte array with read data */
            byte[] spiReadData = NativeSPI_Demo.Exchange(spiDev, spiWriteData);
            /* Display read data in UI */
            if (spiReadData.Length > 0)
                lblSpiRead.Text = Encoding.UTF8.GetString(spiReadData, 0, dataLen);
            else
                lblSpiRead.Text = "Could not read!";

            if (tbSpiWriteData.Text == lblSpiRead.Text)
                WriteResultText(true, lblSpiResult);
            else
                WriteResultText(false, lblSpiResult);
        }

        private void btnNativeSpiV1_Click(object sender, EventArgs e)
        {
            #region DbgMsg020
            //Debug Message
            List<string> msg020 = new List<string>
            {
                $"spiV1Dev-string: {tbSpiV1Dev.Text}",
                $"spiV1WriteData-string: {tbSpiV1WriteData.Text}",
            };
            DebugMsg.WriteDbgMsg("020", msg020);
            #endregion

            string spiDev = tbSpiV1Dev.Text;
            byte[] spiWriteData = Encoding.UTF8.GetBytes(tbSpiV1WriteData.Text);
            int dataLen = spiWriteData.Length;

            #region DbgMsg021
            //Debug Message
            List<string> msg021 = new List<string>
            {
                $"spiDev: {spiDev}",
                $"spiWriteData: {spiWriteData}",
                $"dataLen: {dataLen}",
            };
            DebugMsg.WriteDbgMsg("021", msg021);
            #endregion

            /* Call Exchange Method, returns byte array with read data */
            byte[] spiReadData = NativeSPIV1_Demo.Exchange(spiDev, spiWriteData);
            /* Display read data in UI */
            if (spiReadData.Length > 0)
                lblSpiV1Read.Text = Encoding.UTF8.GetString(spiReadData, 0, dataLen);
            else
                lblSpiV1Read.Text = "Could not read!";

            if (tbSpiV1WriteData.Text == lblSpiV1Read.Text)
                WriteResultText(true, lblSpiV1Result);
            else
                WriteResultText(false, lblSpiV1Result);
        }
        #endregion

        #region UART
        /* UART Values */
        private string UartValueRead = string.Empty;
        private string UartValueWrite = string.Empty;
        private string UartPortSender;
        private string UartPortReceiver;
        private int UartBaudrate = 115200;
        private int UartDatabit = 8;
        private string UartHandshake = "None";
        private string UartParity = "None";
        private double UartStopbit = 1;
        private List<int> UartBaudrates = new List<int> { 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 57600, 115200, 230400, 460800, 921600 };
        private List<int> UartDatabits = new List<int> { 7, 8 };
        private List<string> UartHandshakes = new List<string> { "None", "XOnXOff", "RequestToSend", "RequestToSendXOnXOff" };
        private List<double> UartStopbits = new List<double> { 0, 1, 1.5, 2 };
        private List<string> UartParities = new List<string> { "None", "Odd", "Even", "Mark", "Space" };

        private void btnGetSerialPorts_Click(object sender, EventArgs e)
        {
            string[] ports = UART_Demo.GetAvailableSerialPorts();

            if (ports.Length > 0)
            {
                ActivateUartUi(true);
                FillUartUi(ports);
                #region DbgMsg030
                //Debug Message
                List<string> msg030 = new List<string>
                {
                   $"{ports.Length} SERIAL PORTS FOUND"
                };
                DebugMsg.WriteDbgMsg("030", msg030);
                #endregion
            }
            else
            {
                ActivateUartUi(false);
                #region DbgMsg031
                //Debug Message
                List<string> msg031 = new List<string>
                {
                    $"COULD NOT FIND ANY SERIAL PORTS"
                };
                DebugMsg.WriteDbgMsg("031", msg031);
                #endregion
            }
        }

        private void btnUart_Click(object sender, EventArgs e)
        {
            GetUartValues();

            #region DbgMsg032
            //Debug Message
            List<string> msg032 = new List<string>
            {
                $"Port Sender: {UartPortSender}",
                $"Port Receiver: {UartPortReceiver}",
                $"Baudrate: {UartBaudrate}",
                $"Data Bit: {UartDatabit}",
                $"Stop Bit: {UartStopbit}",
                $"Parity: {UartParity}",
                $"Handshake: {UartHandshake}",
            };
            DebugMsg.WriteDbgMsg("032", msg032);
            #endregion

            /* Create new objects UART_Demo for read and write */
            UART_Demo UartSender = new UART_Demo(UartPortSender, UartBaudrate, UartDatabit, UartStopbit, UartParity, UartHandshake);
            UART_Demo UartReceiver;

            /* Check if sender and receiver use the same port */
            bool samePort = (UartPortSender == UartPortReceiver);
            if (samePort)
                UartReceiver = UartSender;
            else
                UartReceiver = new UART_Demo(UartPortReceiver, UartBaudrate, UartDatabit, UartStopbit, UartParity, UartHandshake);

            /* Create new UART read thread*/
            Thread uartReadThread = new Thread(() => { UartValueRead = UartReceiver.ReadLoop(); });
            uartReadThread.Start();
            /* Create new UART write thread*/
            Thread uartWriteThread = new Thread(() => { UartSender.WriteLoop(UartValueWrite); });
            uartWriteThread.Start();

            /* Run for a while, then close */
            Thread.Sleep(100);

            /* Close ports properly */
            UartSender.Close();
            if (!samePort)
                UartReceiver.Close();

            /* Wait for threads to finish */
            uartWriteThread.Join();
            /* Get value for messageRead */
            uartReadThread.Join();

            lblUartRead.Text = UartValueRead;

            if (UartValueWrite == UartValueRead)
                WriteResultText(true, lblUartResult);
            else
                WriteResultText(false, lblUartResult);
        }

        private void GetUartValues()
        {
            UartValueWrite = tbUartWriteData.Text;
            UartValueRead = string.Empty;
            UartPortSender = cbUartSender.SelectedItem.ToString();
            UartPortReceiver = cbUartReceiver.SelectedItem.ToString();
            UartBaudrate = UartBaudrates[cbUartBaudrate.SelectedIndex];
            UartDatabit = UartDatabits[cbUartDataBit.SelectedIndex];
            UartStopbit = UartStopbits[cbUartStopBit.SelectedIndex];
            UartParity = UartParities[cbUartParity.SelectedIndex];
            UartHandshake = UartHandshakes[cbUartHandshake.SelectedIndex];
        }

        private void ActivateUartUi(bool active)
        {
            cbUartSender.Enabled = active;
            cbUartReceiver.Enabled = active;
            cbUartDataBit.Enabled = active;
            cbUartStopBit.Enabled = active;
            cbUartBaudrate.Enabled = active;
            cbUartParity.Enabled = active;
            cbUartHandshake.Enabled = active;
            tbUartWriteData.Enabled = active;
            btnUart.Enabled = active;
        }

        private void FillUartUi(string[] ports)
        {
            cbUartSender.DataSource = ports;
            cbUartReceiver.DataSource = ports;
            cbUartSender.BindingContext = new BindingContext();
            cbUartReceiver.BindingContext = new BindingContext();

            cbUartDataBit.DataSource = UartDatabits;
            cbUartStopBit.DataSource = UartStopbits;
            cbUartBaudrate.DataSource = UartBaudrates;
            cbUartParity.DataSource = UartParities;
            cbUartHandshake.DataSource = UartHandshakes;

            cbUartDataBit.SelectedIndex = UartDatabits.IndexOf(UartDatabit);
            cbUartStopBit.SelectedIndex = UartStopbits.IndexOf(UartStopbit);
            cbUartBaudrate.SelectedIndex = UartBaudrates.IndexOf(UartBaudrate);
            cbUartParity.SelectedIndex = UartParities.IndexOf(UartParity);
            cbUartHandshake.SelectedIndex = UartHandshakes.IndexOf(UartHandshake);
        }
        #endregion

        #region DebugMsg
        private void checkBoxDbgMsg_CheckStateChanged(object sender, EventArgs e)
        {
            SetDebugState();
        }

        private void SetDebugState()
        {
            if (checkBoxDbgMsg.CheckState == CheckState.Checked)
            {
                DebugMsg.SendDbgMsg = true;
                #region DbgMsg000
                //Debug Message
                List<string> msg000 = new List<string>
                {
                    $"DEBUG MESSAGES ACTIVATED",
                };
                DebugMsg.WriteDbgMsg("000", msg000);
                #endregion
            }

            else
            {
                #region DbgMsg000
                //Debug Message
                List<string> msg000 = new List<string>
                {
                    $"DEBUG MESSAGES DEACTIVATED",
                };
                DebugMsg.WriteDbgMsg("000", msg000);
                #endregion
                DebugMsg.SendDbgMsg = false;
            }
        }
        #endregion

        private void WriteResultText(bool success, Label label)
        {
            if (success)
            {
                label.Text = "Success!";
                label.ForeColor = Color.Green;
            }
            else
            {
                label.Text = "Failed!";
                label.ForeColor = Color.Red;
            }
        }
    }
}
