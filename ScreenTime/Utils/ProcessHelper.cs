using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ScreenTime.Utils
{
    public class ProcessHelper
    {
        [DllImport("psapi.dll")]
        static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, [In][MarshalAs(UnmanagedType.U4)] int nSize);
        public static string GetPathFromProcessId(Process process)
        {
            var sb = new StringBuilder(1024);
            if (GetModuleFileNameEx(process.Handle, IntPtr.Zero, sb, sb.Capacity) > 0)
            {
                return sb.ToString();
            }
            return String.Empty;
        }

        public static string GetPathFromProcessusName(string processusName)
        {
            try
            {
                return ProcessHelper.GetPathFromProcessId(Process.GetProcessesByName(processusName)[0]);
            }
            catch (Exception ex)
            {
                return String.Empty;
            }
        }

        public static bool IsRunningProcessusByName(string processusName)
        {
            if (Process.GetProcessesByName(processusName).Length > 0)
                return true;
            return false;
        }
    }
}
