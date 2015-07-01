using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KerbalPackageManager
{
    public class Mod
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public ModData Data { get; set; }

        public Mod(string name, string description, string website, ModData data)
        {
            Name = name;
            Description = description;
            Website = website;
            Data = data;
        }

        public Mod()
        {
        }
    }
}
