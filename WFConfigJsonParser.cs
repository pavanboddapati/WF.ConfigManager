using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF.ConfigManager
{
    internal class WFConfigJsonParser
    {
        internal static void ParseConfigFile()
        {
            using (StreamReader sr = new StreamReader("WFConfig.json"))
            {
                string jsonString = sr.ReadToEnd();
                var result = JsonConvert.DeserializeObject<ConfigData>(jsonString);
            }
        }
    }
}
