﻿using System;
using System.Collections.Generic;

namespace helloWorld.Data
{
    public partial class SchemaVersion
    {
        public int VersionRank { get; set; }
        public int InstalledRank { get; set; }
        public string Version { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string Script { get; set; } = null!;
        public int? Checksum { get; set; }
        public string InstalledBy { get; set; } = null!;
        public DateTime InstalledOn { get; set; }
        public int ExecutionTime { get; set; }
        public bool Success { get; set; }
    }
}
