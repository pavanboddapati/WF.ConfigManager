using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF.ConfigManager
{
    public class ConfigData
    {
        public List<BSCData> BSCData { get; set; }
        public List<AppData> AppData { get; set; }
    }

    public class BSCData
    {
        public string ApplicationId { get; set; }
        public string AppManager { get; set; }
        public string BSCContact { get; set; }
        public string PrimaryContact { get; set; }
    }

    public class AppData
    {
        public string AppId { get; set; }
        public string AppName { get; set; }
        public int CRPriority { get; set; }
    }
}
