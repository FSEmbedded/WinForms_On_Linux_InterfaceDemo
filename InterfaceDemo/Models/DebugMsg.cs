using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace InterfaceDemo
{
    class DebugMsg
    {
        public static bool SendDbgMsg = false;

        public static void WriteDbgMsg(string msg)
        {
            if (SendDbgMsg)
            {
                string dbgMsg = $"DEBUG{msg}{Environment.NewLine}";
                dbgMsg += $"{Environment.NewLine}============================================={Environment.NewLine}";
                Debug.WriteLine(dbgMsg);
            }
        }

        public static void WriteDbgMsg(string msgNo, List<string> messages)
        {
            if (SendDbgMsg)
            {
                string dbgMsg = $"DEBUG{msgNo}{Environment.NewLine}";
                foreach (string message in messages)
                {
                    dbgMsg += $"    {message}{Environment.NewLine}";
                }
                dbgMsg += $"{Environment.NewLine}============================================={Environment.NewLine}";
                Debug.WriteLine(dbgMsg);
            }
        }
    }
}
