using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CefSharp.MinimalExample.WinForms
{
    public class ShellConnector
    {

        public void OpenNotepad()
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
    }
}
