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
        public Settings Settings;
        public ModManager Manager;

        public KPM()
        {
            SettingsPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "settings.json");
            if (File.Exists(SettingsPath))
            {
                Settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(SettingsPath));
            }
            else
            {
                Settings = new Settings();
            }

            Manager = new ModManager(Path.GetTempPath(), Settings);
        }

        public KPM(string settings_path)
        {
            SettingsPath = settings_path;
        }

        public void SaveSettings()
        {
            string settings_json = JsonConvert.SerializeObject(Settings);
            File.WriteAllText(SettingsPath, settings_json);
        }


        
    }
}
