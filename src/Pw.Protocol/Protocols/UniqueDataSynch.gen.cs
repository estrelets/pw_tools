﻿using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using Pw.Serializer;
using Pw.RpcDatas;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
[OpCode(3117)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class UniqueDataSynch
{
[Order(0)]
public char Finish {get; set; }
[Order(1)]
public GUniqueDataElemNode[] Values {get; set; }
}
}
