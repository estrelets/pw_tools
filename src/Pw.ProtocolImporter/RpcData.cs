using System;
using System.Collections.Generic;
using System.Text;

namespace Pw.ProtocolImporter
{
    public class RpcData : StructDescriptor
    {
        public string Name { get; set; }
        public RpcDataAttr Attr { get; set; }
        public int? Debug { get; set; }
        public string BdbTable { get; set; }
        public string Key { get; set; }
    }

    public enum RpcDataAttr
    {
        None,
        Vector
    }
}
