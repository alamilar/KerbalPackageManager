using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KerbalPackageManager;
using Newtonsoft.Json;
using System.IO;

namespace TestDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new KPM();
            manager.Settings.KerbalPath = @"C:\Program Files (x86)\Steam\steamapps\common\Kerbal Space Program";
        }
    }
}
