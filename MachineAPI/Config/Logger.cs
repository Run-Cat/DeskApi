using System;
using System.Collections.Generic;
using System.IO;

namespace MachineAPI.Config
{
    class Logger
    {
        private static readonly List<string> log = new List<string>();

        private static readonly string file = @"c:\log\" + DateTime.Now.ToString("yyyyMMdd") + "_" + Init.Port + "_api_host.log";

        public static void Save(string txt)
        {
            if (log.Count > 500)
            {
                Save();
            }
            else
            {
                log.Add(txt);
            }
        }

        public static void Save()
        {
            try
            {
                File.AppendAllLines(file, log);
            }
            catch { }

            log.Clear();
        }
    }
}
