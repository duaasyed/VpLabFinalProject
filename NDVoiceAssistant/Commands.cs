using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechRecognizer
{
    class Commands : IBindCommands
    {
        private Dictionary<string, string> dictCmd;
        public Commands()
        {
            this.DictCmd = new Dictionary<string, string>();
        }

        public Dictionary<string, string> DictCmd { get => dictCmd; set => dictCmd = value; }

        public Dictionary<string, string> ReadFile(string filePath)
        {
            Dictionary<string, string> obj = new Dictionary<string, string>();
            if (File.Exists(filePath))
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    string temp = string.Empty;
                    while ((temp = streamReader.ReadLine()) != null)
                    {
                        var cmd = temp.Split(';');
                        obj.Add(cmd[0], cmd[1]);
                    }
                }               
            }
            return obj;
        }
        public void WriteFile(string cmd, string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(cmd);
            }
        }
    }
}