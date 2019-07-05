using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using Pw.Serializer;
using Pw.RpcDatas;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
[OpCode(552)]
[GeneratedCode("Pw.ProtocolImporter", "1")]
public class MatrixResponse
{
[Order(0)]
public uint Response {get; set; }
}
}
