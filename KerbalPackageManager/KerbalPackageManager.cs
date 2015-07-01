using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KerbalPackageManager
{
    public class KPM
    {
        public string SettingsPath { get; set; }
        private Settings settings;


        public KPM()
        {
            SettingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "settings.json");
            if (File.Exists(SettingsPath))
            {
                settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(SettingsPath));
            }
            else
            {
                settings = new Settings();
            }
        }

        public KPM(string settings_path)
        {
            SettingsPath = settings_path;
        }
    }
}
