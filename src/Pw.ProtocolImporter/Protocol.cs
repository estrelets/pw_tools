using System;
using System.Collections.Generic;
using System.Text;

namespace Pw.ProtocolImporter
{
    public class Protocol : StructDescriptor
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public int MaxSize { get; set; }
        public int Prior { get; set; }
    }
}
