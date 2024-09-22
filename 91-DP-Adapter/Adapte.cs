using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _91_DP_Adapter
{
    public class Adapte
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox", CallingConvention = CallingConvention.Winapi)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint buttons);

        public void Alert(string title, string message, Buttons button)
        { 
            MessageBox(new IntPtr(), message, title, (uint)button);
        }
    }
}
