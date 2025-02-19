using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace InterfaceDemo.Models
{
    class UART_Demo
    {
        private readonly SerialPort serialPort;
        private bool keepRunning = true;

        public UART_Demo(string port, int baudrate, int dataBit, double stopBit, string parity, string handshake)
        {
            /* Create a new SerialPort object */
            serialPort = new SerialPort()
            {
                /* Change settings to selected values from UI */
                PortName = port,
                BaudRate = baudrate,
                DataBits = dataBit,
                StopBits = ConvertStopBit(stopBit),
                Parity = ConvertParity(parity),
                Handshake = ConvertHandshake(handshake),
                ReadTimeout = 500,
                WriteTimeout = 500
            };

            serialPort.Open();
        }

        public static string[] GetAvailableSerialPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            return ports;
        }

        public void Close()
        {
            keepRunning = false;
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        public string ReadLoop()
        {
            #region DbgMsg130
            //Debug Message
            List<string> msg130 = new List<string>
            {
                "UART_Demo.Read()",
                $"PortName: {serialPort.PortName}",
                $"BaudRate: {serialPort.BaudRate}",
                $"DataBits: {serialPort.DataBits}",
                $"StopBits: {serialPort.StopBits}",
                $"Parity: {serialPort.Parity}",
                $"Handshake: {serialPort.Handshake}",
            };
            DebugMsg.WriteDbgMsg("130", msg130);
            #endregion
            string valueRead = string.Empty;

            while (keepRunning)
            {
                try
                {
                    /* Read message on selected port */
                    valueRead = serialPort.ReadLine();
                }
                catch (TimeoutException)
                {
                    // Ignore timeouts to allow continuous reading
                }
            }

            return valueRead;
        }

        public void WriteLoop(string message)
        {
            #region DbgMsg131
            //Debug Message
            List<string> msg131 = new List<string>
            {
                "UART_Demo.Write()",
                $"PortName: {serialPort.PortName}",
                $"BaudRate: {serialPort.BaudRate}",
                $"DataBits: {serialPort.DataBits}",
                $"StopBits: {serialPort.StopBits}",
                $"Parity: {serialPort.Parity}",
                $"Handshake: {serialPort.Handshake}",
            };
            DebugMsg.WriteDbgMsg("131", msg131);
            #endregion
            while (keepRunning)
            {
                try
                {
                    /* Write message to selected port */
                    serialPort.WriteLine(message);
                }
                catch (TimeoutException) { }

                Thread.Sleep(200);
            }
        }

        #region Converter
        private static Handshake ConvertHandshake(string handshakeString)
        {
            Handshake handshake;
            switch (handshakeString)
            {
                case "None":
                    handshake = Handshake.None;
                    break;
                case "XOnXOff":
                    handshake = Handshake.XOnXOff;
                    break;
                case "RequestToSend":
                    handshake = Handshake.RequestToSend;
                    break;
                case "RequestToSendXOnXOff":
                    handshake = Handshake.RequestToSendXOnXOff;
                    break;
                default:
                    handshake = Handshake.None;
                    break;
            }

            return handshake;
        }

        private static StopBits ConvertStopBit(double stopBitDouble)
        {
            StopBits bits = StopBits.One;

            if (stopBitDouble == 0)
                bits = StopBits.None;
            if (stopBitDouble == 1)
                bits = StopBits.One;
            if (stopBitDouble == 1.5)
                bits = StopBits.OnePointFive;
            if (stopBitDouble == 2)
                bits = StopBits.Two;

            return bits;
        }

        private static Parity ConvertParity(string parityString)
        {
            Parity par;
            switch (parityString)
            {
                case "None":
                    par = Parity.None;
                    break;
                case "Odd":
                    par = Parity.Odd;
                    break;
                case "Even":
                    par = Parity.Even;
                    break;
                case "Mark":
                    par = Parity.Mark;
                    break;
                case "Space":
                    par = Parity.Space;
                    break;
                default:
                    par = Parity.None;
                    break;
            }

            return par;
        }
        #endregion
    }
}
