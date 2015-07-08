using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalPackageManager
{
    public class ModManager
    {
        private List<Mod> mod_list;
        private Settings settings;

        public ModManager(string ModDirectory, Settings Settings)
        {
            settings = Settings;
        }

    }
}
