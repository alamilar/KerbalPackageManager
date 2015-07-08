﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KerbalPackageManager
{
    public class ModData
    {
        public enum Destination
        {
            GameData
        };
        public string RemotePath { get; set; }
        public string LocalPath { get; set; }
        public Destination DestinationPath { get; set; }

    }
}
