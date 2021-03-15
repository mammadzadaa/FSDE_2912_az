using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15_03_21
{
    [StructLayout(LayoutKind.Sequential)]
    struct COLORREF
    {
        public byte R;
        public byte G;
        public byte B;
    }
    static class MessageBox
    {
        // #define MB_OK 1 
        // int MessageBoxW(void *parent, const wchar_t *text, const wchar_t *title, int buttons);

        [DllImport("user32.dll", EntryPoint = "MessageBoxW", CharSet = CharSet.Unicode)]
        public static extern int Show(IntPtr hParent, string text, string title, int buttons);
    }

    static class C
    {
        [DllImport("msvcrt.dll", EntryPoint = "printf", CharSet = CharSet.Ansi)]
        public static extern int PrintFromat(string format, __arglist);
    }
    class Program
    {      

        static void Main(string[] args)
        {

            PInvoke.Kernel32.Beep(300,1000);
            PInvoke.Kernel32.SetConsoleTitle("Hello");


            MessageBox.Show(IntPtr.Zero,"Hello World","Welcoming",3);
            C.PrintFromat("%s %d + %d = %d\n",__arglist("Sample:",3,2,5));

            ////Process.Start("notepad");
            //var processes = Process.GetProcesses();
            //foreach (var pro in processes)
            //{
            //    Console.WriteLine(pro.ProcessName);
            //}
        }
    }
}
