using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Amatsu
{
    public class Log
    {
        private static string _date {get; set;}

        public static void Init()
        {
            Console.WriteLine("Initialization started...");
            _date = DateTime.Now.ToShortDateString().Replace('.', '-').Replace('/', '-');
        }

        public static void Write(string thingToWrite)
        {
            var logText = new StringBuilder();
            logText.Append($"{DateTime.Now}: {thingToWrite}\r\n");
            File.AppendAllText(_date + ".log", logText.ToString());
            logText.Clear();
        }

        public static void Report(string thingToWrite)
        {
            var logText = new StringBuilder();
            logText.Append($"{DateTime.Now}: {thingToWrite}\r\n");
            File.AppendAllText(_date + "_report.log", logText.ToString());
            logText.Clear();
        }
    }
}
