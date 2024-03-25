using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace MessageBox
{
    internal class Program
    {
        [DllImport("user32.dll")]
        /*int MessageBoxW(
          [in, optional] HWND hWnd,
          [in, optional] LPCWSTR lpText,
          [in, optional] LPCWSTR lpCaption,
          [in] UINT uType
        );*/

        public static extern int MessageBoxW(
            IntPtr hWnd,
            [param: MarshalAs(UnmanagedType.LPWStr)] string lpText,
            [param: MarshalAs(UnmanagedType.LPWStr)] string lpTitle,
            UInt32 uType
            );

        static void Main(string[] args)
        {
            int box = MessageBoxW(IntPtr.Zero, "Hello Pwnzr", "This is title", 0);
            Console.ReadKey();
        }
    }
}
