using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public class Speake
    {
        public static void Speak(string s)
        {
            #region
            //写
            string content = string.Empty;
            FileStream fs = new FileStream(Application.StartupPath + "\\voice.vbs", FileMode.OpenOrCreate, FileAccess.Write);
            fs.SetLength(0);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            content = s.Trim();//移除空白字符
            content = @"CreateObject(""SAPI.SpVoice"").Speak""".Trim() + content + @"""".Trim();
            sw.Write(content);
            sw.Close();
            ProcessStartInfo Info = new ProcessStartInfo
            {
                FileName = "voice.vbs",
                WorkingDirectory = Application.StartupPath
            };//新的进程
            Process proc;
            try
            {
                proc = Process.Start(Info);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                return;
            }

            #endregion
        }
    }

}
