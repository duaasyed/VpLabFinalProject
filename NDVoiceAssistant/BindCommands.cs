using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechRecognizer
{
    interface IBindCommands
    {
        Dictionary<string, string> ReadFile(string filePath);
        void WriteFile(string cmd,string path);
    }
}
